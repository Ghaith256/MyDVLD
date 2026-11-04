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

namespace DVLD_Presentation.User_Controls
{
    public partial class ucApplicationNewLicenseInfo : UserControl
    {
        private clsLicenseBusiness _OldLicense;

        public ucApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }

        public string Notes
        {
            get { return txtNotes.Text.Trim(); }
        }

        public void LoadData(int OldLicenseID) {

            _OldLicense = clsLicenseBusiness.GetLicenseInfoByID(OldLicenseID);

            if (_OldLicense == null)
            {
                MessageBox.Show("Error: Could not find License with ID = " + OldLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAnswerOldLicenseID.Text = _OldLicense.LicenseID.ToString();
            lblAnswerApplicationDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblAnswerIssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");

            int DefaultValidityLength = _OldLicense.LicenseClassInfo.DefaultValidityLength;
            lblAnswerExpirationDate.Text = DateTime.Now.AddYears(DefaultValidityLength).ToString("dd/MMM/yyyy");

            clsApplicationTypeBusiness AppType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(2);
            if (AppType != null)
                lblAnswerApplicationFees.Text = AppType.ApplicationFees.ToString();


            lblAnswerLicenseFees.Text = _OldLicense.LicenseClassInfo.ClassFees.ToString();
            lblAnswerTotalFees.Text = (Convert.ToDecimal(lblAnswerApplicationFees.Text) + Convert.ToDecimal(lblAnswerLicenseFees.Text)).ToString();
            lblAnswerCreatedBy.Text = clsGlobal.CurrentUser.Username;
            lblAnswerRenewLicenseApplicationID.Text = "[???]";
            lblAnswerRenewedLicenseID.Text = "[???]";
        }

        public void SetRenewalResult(int RenewLicenseApplicationID, int RenewedLicenseID) {
            lblAnswerRenewLicenseApplicationID.Text = RenewLicenseApplicationID.ToString();
            lblAnswerRenewedLicenseID.Text = RenewedLicenseID.ToString();
        }




    }
}
