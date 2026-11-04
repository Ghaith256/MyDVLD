using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUserBusiness? _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUserBusiness.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("New Password and Confirm Password do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_User == null) 
                return;

            if (_User.ChangePassword(txtOldPassword.Text.Trim(), txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Changed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Current password is incorrect!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
                txtOldPassword.SelectAll();
            }
        }
    }
}