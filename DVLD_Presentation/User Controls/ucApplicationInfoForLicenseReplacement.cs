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
    public partial class ucApplicationInfoForLicenseReplacement : UserControl {

        private clsLicenseBusiness? _OldLicense;

        public ucApplicationInfoForLicenseReplacement() {
            InitializeComponent();
        }

        public void LoadData(int OldLicenseID, int ApplicationTypeID) {
            _OldLicense = clsLicenseBusiness.GetLicenseInfoByID(OldLicenseID);

            if (_OldLicense == null) {
                MessageBox.Show("Error: Could not find License with ID = " + OldLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAnswerOldLicenseID.Text = _OldLicense.LicenseID.ToString();
            lblAnswerApplicationDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");

            clsApplicationTypeBusiness? AppType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(ApplicationTypeID);
            
            if (AppType != null)
                lblAnswerApplicationFees.Text = AppType.ApplicationFees.ToString();

            lblAnswerCreatedBy.Text = clsGlobal.CurrentUser.Username;
            lblAnswerLicenseReplacementApplicationID.Text = "[???]";
            lblAnswerReplacedLicenseID.Text = "[???]";
        }

        private void ucApplicationInfoForLicenseReplacement_Load(object sender, EventArgs e) {

        }


        public void SetReplacementResult(int LicenseReplacementApplicationID, int ReplacedLicenseID) {
            lblAnswerLicenseReplacementApplicationID.Text = LicenseReplacementApplicationID.ToString();
            lblAnswerReplacedLicenseID.Text = ReplacedLicenseID.ToString();
        }

    }
}
