using DVLD_Business;
using DVLD_Presentation.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses
{
    public partial class frmDetainLicense : Form
    {
        private clsLicenseBusiness? _License;
        private readonly int _LicenseID;

        public frmDetainLicense()
        {
            InitializeComponent();
            _LicenseID = -1;
        }

        public frmDetainLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            clsFormatHelper.StyleButton(btnSearch);
            clsFormatHelper.StyleButton(btnDetain);

            if (_LicenseID != -1)
                _SearchForLicense(_LicenseID);

            if (_LicenseID != -1)
            {
                txtSearchLicense.Visible = false;

                pnlTextBorder.Visible = false;
                btnSearch.Visible = false;

                _SearchForLicense(_LicenseID);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchLicense.Text))
            {
                MessageBox.Show("Please enter a License ID to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSearchLicense.Text.Trim(), out int LicenseID))
            {
                MessageBox.Show("Please enter a valid numeric License ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _SearchForLicense(LicenseID);
        }

        private void _SearchForLicense(int LicenseID)
        {
            txtSearchLicense.Text = LicenseID.ToString();

            ucDriverLicenseInfo.LoadInfo(LicenseID);
            _License = null;

            if (ucDriverLicenseInfo.SelectedLicenseInfo == null)
                return;

            clsLicenseBusiness License = ucDriverLicenseInfo.SelectedLicenseInfo;

            if (!_IsEligibleForDetain(License, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _License = License;
            ucDetainInfo.LoadData();
        }

        private bool _IsEligibleForDetain(clsLicenseBusiness License, out string ErrorMessage)
        {
            ErrorMessage = "";

            if (!License.IsActive)
            {
                ErrorMessage = "This license is not active and cannot be detained.";
                return false;
            }

            if (clsDetainedLicenseBusiness.GetActiveDetainInfoByLicenseID(License.LicenseID) != null)
            {
                ErrorMessage = "This license is already detained and has not been released yet.";
                return false;
            }

            return true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (_License == null)
            {
                MessageBox.Show("Please search for an eligible license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_IsEligibleForDetain(_License, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal FineFees = ucDetainInfo.FineFees;

            if (FineFees < 0)
            {
                MessageBox.Show("Fine Fees cannot be negative.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsDetainedLicenseBusiness NewDetain = new clsDetainedLicenseBusiness();
            NewDetain.LicenseID = _License.LicenseID;
            NewDetain.DetainDate = DateTime.Now;
            NewDetain.FineFees = FineFees;
            NewDetain.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            NewDetain.IsReleased = false;

            if (!NewDetain.Save())
            {
                MessageBox.Show("Failed to detain the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ucDetainInfo.SetDetainResult(NewDetain.DetainID, NewDetain.DetainDate);
            ucDriverLicenseInfo.LoadInfo(_License.LicenseID);

            MessageBox.Show("License detained successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}