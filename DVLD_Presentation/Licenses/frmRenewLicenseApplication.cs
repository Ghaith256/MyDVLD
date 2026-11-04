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
    public partial class frmRenewLicenseApplication : Form
    {

        private clsLicenseBusiness? _OldLicense;

        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a License ID to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text.Trim(), out int LicenseID))
            {
                MessageBox.Show("Please enter a valid numeric License ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ucDriverLicenseInfo.LoadInfo(LicenseID);
            _OldLicense = null;

            if (ucDriverLicenseInfo.SelectedLicenseInfo == null)
                return;

            clsLicenseBusiness License = ucDriverLicenseInfo.SelectedLicenseInfo;

            if (!_IsEligibleForRenew(License, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _OldLicense = License;
            ucApplicationNewLicenseInfo.LoadData(_OldLicense.LicenseID);

        }

        private bool _IsEligibleForRenew(clsLicenseBusiness License, out string ErrorMessage)
        {
            ErrorMessage = "";

            if (!License.IsActive)
            {
                ErrorMessage = "This license is not active and cannot be renewed.";
                return false;
            }

            if (License.ExpirationDate.Date > DateTime.Now.Date)
            {
                ErrorMessage = "This license has not expired yet. Only expired licenses can be renewed.";
                return false;
            }

            return true;
        }

        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {

            clsFormatHelper.StyleButton(btnSearch);
            clsFormatHelper.StyleButton(btnRenew);
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

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (_OldLicense == null)
            {
                MessageBox.Show("Please search for an eligible (expired) license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Re-validate in case the state changed since the search.
            if (!_IsEligibleForRenew(_OldLicense, out string ErrorMessage))
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

            clsApplicationTypeBusiness ApplicationType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(2);
            decimal ApplicationFees = (ApplicationType != null) ? ApplicationType.ApplicationFees : 0;

            clsApplicationBusiness RenewApplication = new clsApplicationBusiness();
            RenewApplication.ApplicantPersonID = _OldLicense.DriverInfo.PersonInfo.PersonID;
            RenewApplication.ApplicationDate = DateTime.Now;
            RenewApplication.ApplicationTypeID = 2;
            RenewApplication.PaidFees = ApplicationFees;
            RenewApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (!RenewApplication.Save())
            {
                MessageBox.Show("Failed to create the renew application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLicenseBusiness NewLicense = new clsLicenseBusiness();
            NewLicense.ApplicationID = RenewApplication.ApplicationID;
            NewLicense.DriverID = _OldLicense.DriverID;
            NewLicense.LicenseClassID = _OldLicense.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(_OldLicense.LicenseClassInfo.DefaultValidityLength);
            NewLicense.PaidFees = _OldLicense.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = 2;
            NewLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            string UserNotes = ucApplicationNewLicenseInfo.Notes;
            string RenewalTrace = $"Renewed from License #{_OldLicense.LicenseID}.";
            NewLicense.Notes = string.IsNullOrWhiteSpace(UserNotes) ? RenewalTrace : $"{UserNotes} | {RenewalTrace}";

            if (!NewLicense.Save())
            {
                MessageBox.Show("Failed to issue the renewed license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _OldLicense.IsActive = false;
            _OldLicense.Save();

            RenewApplication.Completed();

            ucApplicationNewLicenseInfo.SetRenewalResult(RenewApplication.ApplicationID, NewLicense.LicenseID);
            ucDriverLicenseInfo.LoadInfo(_OldLicense.LicenseID);

            MessageBox.Show("Driving license renewed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ucApplicationNewLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
