using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_Presentation.User_Controls
{
    public partial class ucShowTestInfo : UserControl {

        private clsLocalDrivingLicenseApplicationBusiness? _LocalAppInfo;
        private int _TestTypeID = -1;

        public DateTimePicker TestDatePicker
        {
            get
            {
                return timeTestDate;
            }
        }

        public ucShowTestInfo() {
            InitializeComponent();
        }

        public int LoadData(int LocalDrivingLicenseApplicationID, int TestTypeID) {

            _TestTypeID = TestTypeID;

            _LocalAppInfo = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID);

            if (_LocalAppInfo == null) {
                MessageBox.Show("Error: Local Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            lblAnswerLocalAppID.Text = _LocalAppInfo.LocalDrivingLicenseApplicationID.ToString();

            clsLicenseClassBusiness? LicenseClass = clsLicenseClassBusiness.GetLicenseClassInfoByID(_LocalAppInfo.LicenseClassID);
            lblAnswerClassName.Text = LicenseClass != null ? LicenseClass.ClassName : "Unknown";

            lblAnswerName.Text = _LocalAppInfo.ApplicationInfo.PersonInfo != null ? _LocalAppInfo.ApplicationInfo.PersonInfo.FullName : "Unknown Person";

            int TrialCount = clsTestAppointmentBusiness.GetTotalTrialsPerTest(LocalDrivingLicenseApplicationID, _TestTypeID);
            lblAnswerTrial.Text = TrialCount.ToString();

            clsTestTypeBusiness? TestType = clsTestTypeBusiness.GetTestTypeInfoByID(_TestTypeID);
            if (TestType != null)
                lblAnswerFees.Text = TestType.TestTypeFees.ToString("0.00");

            return TrialCount;

        }



    }
}
