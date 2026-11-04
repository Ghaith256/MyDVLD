using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.User_Controls
{
    public partial class ucReleaseInfo : UserControl
    {
        private clsDetainedLicenseBusiness? _Detain;

        public ucReleaseInfo() {
            InitializeComponent();
        }

        public clsDetainedLicenseBusiness? SelectedDetainInfo {
            get { return _Detain; }
        }

        public void LoadData(int LicenseID) {
            _Detain = clsDetainedLicenseBusiness.GetActiveDetainInfoByLicenseID(LicenseID);

            if (_Detain == null) {
                MessageBox.Show("Error: Could not find an active Detain record for License ID = " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAnswerDetainID.Text = _Detain.DetainID.ToString();
            lblAnswerLicenseID.Text = _Detain.LicenseID.ToString();
            lblAnswerDetainDate.Text = _Detain.DetainDate.ToString("dd/MMM/yyyy");
            lblAnswerCreatedBy.Text = clsGlobal.CurrentUser.Username;
            lblAnswerFineFees.Text = _Detain.FineFees.ToString();

            clsApplicationTypeBusiness? AppType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(5);
            decimal ApplicationFees = (AppType != null) ? AppType.ApplicationFees : 0;
            lblAnswerApplicationFees.Text = ApplicationFees.ToString();

            lblAnswerTotalFees.Text = (ApplicationFees + _Detain.FineFees).ToString();

            lblAnswerApplicationID.Text = "[???]";
        }

        public void SetReleaseResult(int ReleaseApplicationID) {
            lblAnswerApplicationID.Text = ReleaseApplicationID.ToString();
        }
    }
}