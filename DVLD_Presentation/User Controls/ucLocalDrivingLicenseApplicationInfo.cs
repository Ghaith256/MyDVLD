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
    public partial class ucLocalDrivingLicenseApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplicationBusiness? _LocalApp;

        public bool EnableShowLicense {
            get { return lnkShowLicenseInfo.Enabled; }
            set { lnkShowLicenseInfo.Enabled = value; }
        }

        public ucLocalDrivingLicenseApplicationInfo() {
            InitializeComponent();
        }

        public void LoadLocalApplicationData(int LocalAppID) {

            _LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);

            if (_LocalApp == null) {
                MessageBox.Show("No Local Application with ID = " + LocalAppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAnswerLocalDrivingLicenseApplicationID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();


            int PassedTests = clsLocalDrivingLicenseApplicationBusiness.GetPassedTestsCount(LocalAppID);
            lblAnswerPassedTests.Text = PassedTests.ToString();

            clsLicenseClassBusiness? LicenseClass = clsLicenseClassBusiness.GetLicenseClassInfoByID(_LocalApp.LicenseClassID);

            if (LicenseClass != null)
                lblAnswerLicenseClass.Text = LicenseClass.ClassName;
            

        }



    }
}
