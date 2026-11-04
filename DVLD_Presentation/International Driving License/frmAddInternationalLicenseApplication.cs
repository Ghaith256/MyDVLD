using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_Presentation.Tests;

namespace DVLD_Presentation.International_Driving_License
{
    public partial class frmAddInternationalLicenseApplication : Form
    {
        private clsInternationalLicenseBusiness _PendingInternationalLicense;

        public frmAddInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmAddInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            clsFormatHelper.StyleButton(btnSearch);
            clsFormatHelper.StyleButton(btnAdd);

            txtSearchLicense.BorderStyle = BorderStyle.None;
            txtSearchLicense.BackColor = ColorTranslator.FromHtml("#1f2937");
            txtSearchLicense.ForeColor = Color.White;
            txtSearchLicense.PlaceholderText = "Search Employees...";

            txtSearchLicense.TextAlign = HorizontalAlignment.Left;
            txtSearchLicense.Top = (pnlTextBorder.Height - txtSearchLicense.Height) / 2;
            txtSearchLicense.Left = 12;
            txtSearchLicense.Width = pnlTextBorder.Width - 24;

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
            _PendingInternationalLicense = null;

            if (ucDriverLicenseInfo.SelectedLicenseInfo == null)
                return;

            clsLicenseBusiness License = ucDriverLicenseInfo.SelectedLicenseInfo;

            if (!_IsEligible(License, out string ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _PendingInternationalLicense = _BuildPendingInternationalLicense(License);
            ucApplicationInfo.LoadApplicationInfo(_PendingInternationalLicense);
        }

        private bool _IsEligible(clsLicenseBusiness License, out string ErrorMessage)
        {
            ErrorMessage = "";

            if (License.LicenseClassInfo.LicenseClassID != 3)
            {
                ErrorMessage = "International licenses can only be issued for Class 3 (Regular) licenses.";
                return false;
            }

            if (!License.IsActive)
            {
                ErrorMessage = "This license is not active.";
                return false;
            }

            if (clsInternationalLicenseBusiness.GetActiveInternationalLicenseIDByDriverID(License.DriverID) != -1)
            {
                ErrorMessage = "This driver already has an active International License.";
                return false;
            }

            return true;
        }

        private clsInternationalLicenseBusiness _BuildPendingInternationalLicense(clsLicenseBusiness License)
        {
            clsInternationalLicenseBusiness? InternationalLicense = new clsInternationalLicenseBusiness();

            InternationalLicense.DriverID = License.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = License.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            InternationalLicense.ApplicationInfo.ApplicantPersonID = License.DriverInfo.PersonInfo.PersonID;
            InternationalLicense.ApplicationInfo.ApplicationDate = DateTime.Now;

            clsApplicationTypeBusiness ApplicationType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(InternationalLicense.ApplicationInfo.ApplicationTypeID);

            InternationalLicense.ApplicationInfo.PaidFees = (ApplicationType != null) ? ApplicationType.ApplicationFees : 0;

            return InternationalLicense;
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            if (_PendingInternationalLicense == null)
            {
                MessageBox.Show("Please search for an eligible license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_PendingInternationalLicense.Save())
            {
                MessageBox.Show("International License issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucApplicationInfo.LoadApplicationInfo(_PendingInternationalLicense);
            }
            else
            {
                MessageBox.Show("Failed to issue the International License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_PendingInternationalLicense == null || _PendingInternationalLicense.InternationalLicenseID == -1)
            {
                MessageBox.Show("This International License has not been issued yet.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmShowDriverInternationalLicenseInfo frm = new frmShowDriverInternationalLicenseInfo(_PendingInternationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }

        private void lnkShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ucDriverLicenseInfo.SelectedLicenseInfo == null)
            {
                MessageBox.Show("Please search for a license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int PersonID = ucDriverLicenseInfo.SelectedLicenseInfo.DriverInfo.PersonInfo.PersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
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

        private void txtSearchLicense_TextChanged(object sender, EventArgs e)
        {

        }
    }
}