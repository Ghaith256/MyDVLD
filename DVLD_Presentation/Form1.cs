using DVLD_Presentation.International_Driving_License;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.Local_Driving_License_Applications;
using DVLD_Presentation.People;
using DVLD_Presentation.Test_Types;
using DVLD_Presentation.Users;

namespace DVLD_Presentation {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople people = new frmManagePeople();

            people.ShowDialog();
        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            frmManageUsers user = new frmManageUsers();

            user.ShowDialog();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.ShowDialog();
        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void btnTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void btnManageLocal_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void btnManageLocalApplications_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void btnAddInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenseApplication frm = new frmAddInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            frmRenewLicenseApplication frm = new frmRenewLicenseApplication();
            frm.ShowDialog();
        }

        private void btnLicenseReplacement_Click(object sender, EventArgs e) {
            frmLicenseReplacement frm = new frmLicenseReplacement();
            frm.ShowDialog();
        }
    }
}
