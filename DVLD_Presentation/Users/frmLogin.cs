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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_Presentation.Users
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

            pbShowPassword.Image = Properties.Resources.eye_solid;
            pbShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbShowPassword.Cursor = Cursors.Hand;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Empty fields!", "Invalid Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            clsUserBusiness? user = clsUserBusiness.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {

                if (user.IsActive == false)
                {
                    MessageBox.Show("Your account is not active, please contact your admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (chkRememberMe.Checked)
                    clsGlobal.RememberUsernameAndPasswordInRegistry(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                else
                    clsGlobal.RememberUsernameAndPasswordInRegistry("", "");


                clsGlobal.CurrentUser = user;
                this.Hide();

                frmMainMenu frm = new frmMainMenu();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Invalid Username or Password!", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsFormatHelper.StyleButton(btnLogin);

            string? username = "";
            string? password = "";

            if (clsGlobal.GetStoredCredentialFromRegistry(ref username, ref password))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                pbShowPassword.Image = Properties.Resources.eye_slash_solid;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pbShowPassword.Image = Properties.Resources.eye_solid;
            }
        }
    }
}