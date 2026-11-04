using DVLD_Business;
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
    public partial class frmLicenseReplacement : Form
    {

        private clsLicenseBusiness? _OldLicense;

        public frmLicenseReplacement()
        {
            InitializeComponent();
        }

        private void frmLicenseReplacement_Load(object sender, EventArgs e)
        {
            clsFormatHelper.StyleButton(btnSearch);
            clsFormatHelper.StyleButton(btnIssueReplacement);
        }

        private void _UpdateTitle()
        {
            lblTitle.Text = rbDamagedLicense.Checked ? "Replacement for Damaged License" : "Replacement for Lost License";
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateTitle();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateTitle();
        }

        private int _GetSelectedApplicationTypeID()
        {
            return rbDamagedLicense.Checked ? 4 : 3;
        }

        private byte _GetSelectedIssueReason() {
            return rbDamagedLicense.Checked ? (byte)4 : (byte)3;
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

            ucDriverLicenseInfo.LoadInfo(LicenseID);
            _OldLicense = null;

            if (ucDriverLicenseInfo.SelectedLicenseInfo == null)
                return;

            clsLicenseBusiness License = ucDriverLicenseInfo.SelectedLicenseInfo;

            if (!_IsEligibleForReplacement(License, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _OldLicense = License;
            ucApplicationInfoForLicenseReplacement.LoadData(_OldLicense.LicenseID, _GetSelectedApplicationTypeID());

        }

        private bool _IsEligibleForReplacement(clsLicenseBusiness License, out string ErrorMessage)
        {

            ErrorMessage = "";

            if (!License.IsActive)
            {
                ErrorMessage = "This license is not active and cannot be replaced.";
                return false;
            }

            if (License.ExpirationDate.Date < DateTime.Now.Date)
            {
                ErrorMessage = "This license has expired. Only non-expired licenses can be replaced.";
                return false;
            }

            return true;
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

        private void btnIssueReplacement_Click(object sender, EventArgs e) {

            if (_OldLicense == null)
            {
                MessageBox.Show("Please search for an eligible license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Re-validate in case the state changed since the search.
            if (!_IsEligibleForReplacement(_OldLicense, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_OldLicense.LicenseClassInfo == null)
            {
                MessageBox.Show("Could not load the license class information for this license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_OldLicense.DriverInfo == null || _OldLicense.DriverInfo.PersonInfo == null)
            {
                MessageBox.Show("Could not load the driver/person information for this license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ApplicationTypeID = _GetSelectedApplicationTypeID();
            byte IssueReason = _GetSelectedIssueReason();

            clsApplicationTypeBusiness ApplicationType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(ApplicationTypeID);
            decimal ApplicationFees = (ApplicationType != null) ? ApplicationType.ApplicationFees : 0;

            clsApplicationBusiness ReplacementApplication = new clsApplicationBusiness();
            ReplacementApplication.ApplicantPersonID = _OldLicense.DriverInfo.PersonInfo.PersonID;
            ReplacementApplication.ApplicationDate = DateTime.Now;
            ReplacementApplication.ApplicationTypeID = ApplicationTypeID;
            ReplacementApplication.PaidFees = ApplicationFees;
            ReplacementApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (!ReplacementApplication.Save())
            {
                MessageBox.Show("Failed to create the replacement application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLicenseBusiness NewLicense = new clsLicenseBusiness();
            NewLicense.ApplicationID = ReplacementApplication.ApplicationID;
            NewLicense.DriverID = _OldLicense.DriverID;
            NewLicense.LicenseClassID = _OldLicense.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(_OldLicense.LicenseClassInfo.DefaultValidityLength);
            NewLicense.PaidFees = _OldLicense.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReason;
            NewLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            string ReplacementTrace = rbDamagedLicense.Checked
                ? $"Replaced (Damaged) from License #{_OldLicense.LicenseID}."
                : $"Replaced (Lost) from License #{_OldLicense.LicenseID}.";
            NewLicense.Notes = ReplacementTrace;

            if (!NewLicense.Save())
            {
                MessageBox.Show("Failed to issue the replacement license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _OldLicense.IsActive = false;
            _OldLicense.Save();

            ReplacementApplication.Completed();

            ucApplicationInfoForLicenseReplacement.SetReplacementResult(ReplacementApplication.ApplicationID, NewLicense.LicenseID);
            ucDriverLicenseInfo.LoadInfo(_OldLicense.LicenseID);

            MessageBox.Show("Driving license replacement issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
