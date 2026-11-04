using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests
{
    public partial class frmScheduledTest : Form
    {
        private int _AppointmentID = -1;
        private int _TestTypeID = -1;
        private clsTestAppointmentBusiness? _Appointment;

        public frmScheduledTest(int AppointmentID, int TestTypeID)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestTypeID = TestTypeID;
        }

        private void frmScheduledTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            _Appointment = clsTestAppointmentBusiness.GetTestAppointmentInfoByID(_AppointmentID);

            if (_Appointment == null)
            {
                MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblAnswerLocalApplicationID.Text = _Appointment.LocalDrivingLicenseApplicationID.ToString();
            lblAnswerDate.Text = _Appointment.AppointmentDate.ToShortDateString();
            lblAnswerFees.Text = _Appointment.PaidFees.ToString();
            lblAnswerTestID.Text = _Appointment.TestAppointmentID.ToString();

            clsLocalDrivingLicenseApplicationBusiness? LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(_Appointment.LocalDrivingLicenseApplicationID);

            if (LocalApp != null)
            {
                clsLicenseClassBusiness? LicenseClass = clsLicenseClassBusiness.GetLicenseClassInfoByID(LocalApp.LicenseClassID);
                if (LicenseClass != null)
                    lblAnswerClassName.Text = LicenseClass.ClassName;

                lblAnswerName.Text = LocalApp.ApplicationInfo.PersonInfo != null ? LocalApp.ApplicationInfo.PersonInfo.FullName : "Unknown Person";
            }

            int TotalTrials = clsTestAppointmentBusiness.GetTotalTrialsPerTest(_Appointment.LocalDrivingLicenseApplicationID, _TestTypeID);
            lblAnswerTrial.Text = (TotalTrials + 1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Appointment == null)
            {
                MessageBox.Show("Appointment data not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbPass.Checked && !rbFail.Checked)
            {
                MessageBox.Show("Please select a result (Pass or Fail).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsTestBusiness NewTest = new clsTestBusiness();
            NewTest.TestAppointmentID = _AppointmentID;
            NewTest.TestResult = rbPass.Checked;
            NewTest.Notes = txtNotes.Text.Trim();
            NewTest.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (NewTest.AddNewTest())
            {
                _Appointment.LockTestAppointment();
                MessageBox.Show($"Test result saved successfully! Test ID = {NewTest.TestID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save test result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}