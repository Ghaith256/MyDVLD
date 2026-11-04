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

namespace DVLD_Presentation.Detain_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private clsLicenseBusiness? _License;
        private readonly int _LicenseID;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            _LicenseID = -1;
        }

        public frmReleaseDetainedLicense(int LicenseID) : this()
        {
            _LicenseID = LicenseID;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            clsFormatHelper.StyleButton(btnSearch);
            clsFormatHelper.StyleButton(btnRelease);

            if (_LicenseID != -1)
                _SearchForLicense(_LicenseID);
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

            if (!_IsEligibleForRelease(License, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _License = License;
            ucReleaseInfo.LoadData(_License.LicenseID);
        }

        private bool _IsEligibleForRelease(clsLicenseBusiness License, out string ErrorMessage)
        {
            ErrorMessage = "";

            if (clsDetainedLicenseBusiness.GetActiveDetainInfoByLicenseID(License.LicenseID) == null)
            {
                ErrorMessage = "This license is not currently detained.";
                return false;
            }

            return true;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (_License == null)
            {
                MessageBox.Show("Please search for a detained license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_IsEligibleForRelease(_License, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsDetainedLicenseBusiness? Detain = ucReleaseInfo.SelectedDetainInfo;

            if (Detain == null)
            {
                MessageBox.Show("Could not load the detain information for this license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplicationTypeBusiness? ApplicationType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(5);
            decimal ApplicationFees = (ApplicationType != null) ? ApplicationType.ApplicationFees : 0;

            clsApplicationBusiness ReleaseApplication = new clsApplicationBusiness();
            ReleaseApplication.ApplicantPersonID = _License.DriverInfo.PersonInfo.PersonID;
            ReleaseApplication.ApplicationDate = DateTime.Now;
            ReleaseApplication.ApplicationTypeID = 5;
            ReleaseApplication.PaidFees = ApplicationFees;
            ReleaseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (!ReleaseApplication.Save())
            {
                MessageBox.Show("Failed to create the release application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Detain.Release(clsGlobal.CurrentUser.UserID, ReleaseApplication.ApplicationID))
            {
                MessageBox.Show("Failed to release the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReleaseApplication.Completed();

            ucReleaseInfo.SetReleaseResult(ReleaseApplication.ApplicationID);
            ucDriverLicenseInfo.LoadInfo(_License.LicenseID);

            MessageBox.Show("License released successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlTextBorder_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(ColorTranslator.FromHtml("#f97316"), 2))
            {
                Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                using (System.Drawing.Drawing2D.GraphicsPath path = clsFormatHelper.GetRoundedRectanglePath(rect, 15))
                {
                    using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#1f2937")))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }


    }
}