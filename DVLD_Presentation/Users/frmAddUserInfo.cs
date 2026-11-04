using DVLD_Business;
using DVLD_Presentation.People;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmAddUserInfo : Form
    {
        private int _PersonID;
        private clsUserBusiness? _User;


        public frmAddUserInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmAddUserInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
            lnkUpdatePerson.Visible = (_PersonID != -1);
        }

        private void _LoadData()
        {

            _User = clsUserBusiness.FindByPersonID(_PersonID);

            if (_User != null)
            {
                txtUsername.Text = _User.Username;
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                chkIsActive.Checked = _User.IsActive;
            }
            else
            {
                _User = new clsUserBusiness();
                _User.PersonID = _PersonID;

                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                chkIsActive.Checked = true;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_PersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_User.Mode == clsUserBusiness.enMode.AddNew)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password is required for a new user!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Password and Confirm Password do not match!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _User.SetPassword(txtPassword.Text.Trim());
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                    {
                        MessageBox.Show("Password and Confirm Password do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _User.SetPassword(txtPassword.Text.Trim());
                }
            }

            _User.Username = txtUsername.Text.Trim();
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save()) {
                MessageBox.Show($"User Saved Successfully! User ID = {_User.UserID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Failed to save user data. Please check if username is duplicated.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void linkUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();
        }
    }
}