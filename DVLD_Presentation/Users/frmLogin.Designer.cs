namespace DVLD_Presentation.Users
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPassword = new Sunny.UI.UILabel();
            lblUsername = new Sunny.UI.UILabel();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            btnLogin = new Button();
            chkRememberMe = new CheckBox();
            pbShowPassword = new PictureBox();
            txtPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.FromArgb(47, 59, 73);
            lblPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(57, 99);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 23);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.FromArgb(47, 59, 73);
            lblUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(57, 46);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.FillColor = Color.FromArgb(55, 65, 81);
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(175, 46);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.RectColor = Color.FromArgb(47, 59, 73);
            txtUsername.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtUsername.ScrollBarStyleInherited = false;
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(131, 24);
            txtUsername.TabIndex = 0;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "";
            // 
            // txtPassword
            // 
            txtPassword.Controls.Add(pbShowPassword);
            txtPassword.FillColor = Color.FromArgb(55, 65, 81);
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(175, 98);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.RectColor = Color.FromArgb(47, 59, 73);
            txtPassword.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtPassword.ScrollBarStyleInherited = false;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(131, 24);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(249, 115, 22);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(117, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = Color.White;
            chkRememberMe.Location = new Point(57, 143);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(146, 23);
            chkRememberMe.TabIndex = 24;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // pbShowPassword
            // 
            pbShowPassword.BackColor = Color.Transparent;
            pbShowPassword.Cursor = Cursors.Hand;
            pbShowPassword.Location = new Point(98, 1);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(25, 24);
            pbShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbShowPassword.TabIndex = 3;
            pbShowPassword.TabStop = false;
            pbShowPassword.Click += pbShowPassword_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(329, 246);
            Controls.Add(chkRememberMe);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmLogin";
            Load += frmLogin_Load;
            txtPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UILabel lblUsername;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Button btnLogin;
        private CheckBox chkRememberMe;
        private PictureBox pbShowPassword;
    }
}