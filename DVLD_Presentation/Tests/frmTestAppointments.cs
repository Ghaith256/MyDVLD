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

namespace DVLD_Presentation.Tests
{
    public partial class frmTestAppointments : Form
    {

        private int _LocalAppID;
        private int _TestTypeID;
        private DataTable _dtTestAppointments;

        public frmTestAppointments(int LocalAppID, int TestTypeID) {
            InitializeComponent();
            _LocalAppID = LocalAppID;
            _TestTypeID = TestTypeID;
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {

            clsLocalDrivingLicenseApplicationBusiness? LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(_LocalAppID);

            ucLocalDrivingLicenseApplicationInfo.LoadLocalApplicationData(_LocalAppID);

            if (LocalApp != null)
                ucApplicationBasicInfo.LoadApplicationData(LocalApp.ApplicationID);


            dgvShowLocalDrivingLicenseApplications.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowLocalDrivingLicenseApplications.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowLocalDrivingLicenseApplications.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowLocalDrivingLicenseApplications);
            clsFormatHelper.StyleButton(btnAdd);

            dgvShowLocalDrivingLicenseApplications.AutoGenerateColumns = false;

            _RefreshTestAppointments();


            switch (_TestTypeID) {
                case 1:
                    lblTitleTestAppointments.Text = "Vision Test Appointments";
                    break;
                case 2:
                    lblTitleTestAppointments.Text = "Written Test Appointments";
                    break;
                case 3:
                    lblTitleTestAppointments.Text = "Street Test Appointments";
                    break;
            }

            this.Text = lblTitleTestAppointments.Text;

        }

        private void _RefreshTestAppointments() {
            _dtTestAppointments = clsTestAppointmentBusiness.GetAllTestAppointmentsByLocalAppID(_LocalAppID, _TestTypeID);
            dgvShowLocalDrivingLicenseApplications.DataSource = _dtTestAppointments;
            lblAnswerRecord.Text = _dtTestAppointments.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            frmAddUpdateTest frm = new frmAddUpdateTest(_LocalAppID, _TestTypeID);
            frm.ShowDialog();

            _RefreshTestAppointments();
        }

        private void itemTakeTest_Click(object sender, EventArgs e)
        {
            if (dgvShowLocalDrivingLicenseApplications.CurrentRow != null && dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value != null) {
                int AppointmentID = Convert.ToInt32(dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

                frmScheduledTest frm = new frmScheduledTest(AppointmentID, _TestTypeID);
                frm.ShowDialog();

                _RefreshTestAppointments();
            }


        }

        private void itemEdit_Click(object sender, EventArgs e) {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null || dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value == null)
                return;

            int AppointmentID = Convert.ToInt32(dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            frmAddUpdateTest frm = new frmAddUpdateTest(AppointmentID);
            frm.ShowDialog();

            _RefreshTestAppointments();

        }
    }
}
