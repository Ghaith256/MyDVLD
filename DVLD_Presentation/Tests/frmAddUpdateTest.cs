using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests
{
    public partial class frmAddUpdateTest : Form
    {
        private clsTestAppointmentBusiness? _Appointment;
        private int _TrialCount = 0;

        public frmAddUpdateTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            InitializeComponent();

            _Appointment = new clsTestAppointmentBusiness();
            _Appointment.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Appointment.TestTypeID = TestTypeID;
        }

        public frmAddUpdateTest(int TestAppointmentID)
        {
            InitializeComponent();
            _Appointment = clsTestAppointmentBusiness.GetTestAppointmentInfoByID(TestAppointmentID);
        }

        private void frmAddTest_Load(object sender, EventArgs e)
        {

            if (_Appointment == null)
            {
                MessageBox.Show("Error: Appointment data is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            clsFormatHelper.StyleDateTimePicker(ucShowTestInfo.TestDatePicker);

            _TrialCount = ucShowTestInfo.LoadData(_Appointment.LocalDrivingLicenseApplicationID, _Appointment.TestTypeID);

            if (_Appointment.TestAppointmentID == -1)
                _LoadFeesAndRetakeInfoForNewAppointment();
            else
            {
                ucShowTestInfo.TestDatePicker.Value = _Appointment.AppointmentDate;

                pnlRetakeTest.Enabled = false;
                lblAnswerTotalFees.Text = _Appointment.PaidFees.ToString("0.00");
                lblAnswerRetakeApplicationFees.Text = "0.00";

                if (_Appointment.RetakeTestApplicationID != -1)
                    lblAnswerRetakeTestApplicationID.Text = _Appointment.RetakeTestApplicationID.ToString();
                else
                    lblAnswerRetakeTestApplicationID.Text = "N/A";
            }
        }

        private void _LoadFeesAndRetakeInfoForNewAppointment()
        {

            decimal TestFees = 0;
            clsTestTypeBusiness? TestType = clsTestTypeBusiness.GetTestTypeInfoByID(_Appointment.TestTypeID);

            if (TestType != null)
                TestFees = TestType.TestTypeFees;

            if (_TrialCount > 0)
            {
                pnlRetakeTest.Enabled = true;

                clsApplicationTypeBusiness? RetakeAppType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(7);
                decimal RetakeAppFees = RetakeAppType != null ? RetakeAppType.ApplicationFees : 0;

                lblAnswerRetakeApplicationFees.Text = RetakeAppFees.ToString("0.00");
                lblAnswerTotalFees.Text = (TestFees + RetakeAppFees).ToString("0.00");
                lblAnswerRetakeTestApplicationID.Text = "N/A";
            }
            else
            {
                pnlRetakeTest.Enabled = false;
                lblAnswerRetakeApplicationFees.Text = "0.00";
                lblAnswerTotalFees.Text = TestFees.ToString("0.00");
                lblAnswerRetakeTestApplicationID.Text = "N/A";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (_Appointment.TestAppointmentID == -1 && _TrialCount > 0)
            {
                clsApplicationBusiness RetakeApp = new clsApplicationBusiness();

                RetakeApp.ApplicantPersonID = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(_Appointment.LocalDrivingLicenseApplicationID).ApplicationInfo.ApplicantPersonID;
                RetakeApp.ApplicationDate = DateTime.Now;
                RetakeApp.ApplicationTypeID = 7;
                RetakeApp.ApplicationStatus = 3;
                RetakeApp.LastStatusDate = DateTime.Now;
                RetakeApp.PaidFees = Convert.ToDecimal(lblAnswerRetakeApplicationFees.Text);

                RetakeApp.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (!RetakeApp.Save())
                {
                    MessageBox.Show("Failed to create Retake Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Appointment.RetakeTestApplicationID = RetakeApp.ApplicationID;
            }

            _Appointment.AppointmentDate = ucShowTestInfo.TestDatePicker.Value;
            _Appointment.PaidFees = Convert.ToDecimal(lblAnswerTotalFees.Text);

            _Appointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Appointment.Save())
            {
                MessageBox.Show("Appointment Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Failed to save Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ucShowTestInfo_Load(object sender, EventArgs e)
        {
        }
    }
}