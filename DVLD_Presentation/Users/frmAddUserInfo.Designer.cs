namespace DVLD_Presentation.Users
{
    partial class frmAddUserInfo
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
            txtPassword = new Sunny.UI.UITextBox();
            txtUsername = new Sunny.UI.UITextBox();
            txtConfirmPassword = new Sunny.UI.UITextBox();
            lblUsername = new Sunny.UI.UILabel();
            lblConfirmPassword = new Sunny.UI.UILabel();
            lblPassword = new Sunny.UI.UILabel();
            btnSave = new Button();
            lblUserInfo = new Sunny.UI.UILabel();
            chkIsActive = new CheckBox();
            lnkUpdatePerson = new LinkLabel();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.FillColor = Color.FromArgb(55, 65, 81);
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(185, 130);
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
            // txtUsername
            // 
            txtUsername.FillColor = Color.FromArgb(55, 65, 81);
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(184, 77);
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
            // txtConfirmPassword
            // 
            txtConfirmPassword.FillColor = Color.FromArgb(55, 65, 81);
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(185, 190);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.MinimumSize = new Size(1, 16);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(5);
            txtConfirmPassword.RectColor = Color.FromArgb(47, 59, 73);
            txtConfirmPassword.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtConfirmPassword.ScrollBarStyleInherited = false;
            txtConfirmPassword.ShowText = false;
            txtConfirmPassword.Size = new Size(131, 24);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPassword.Watermark = "";
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.FromArgb(47, 59, 73);
            lblUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(26, 78);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.BackColor = Color.FromArgb(47, 59, 73);
            lblConfirmPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(27, 190);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(139, 23);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.FromArgb(47, 59, 73);
            lblPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(27, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 23);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(120, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 30);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblUserInfo
            // 
            lblUserInfo.BackColor = Color.FromArgb(47, 59, 73);
            lblUserInfo.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserInfo.ForeColor = Color.White;
            lblUserInfo.Location = new Point(27, 23);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(139, 31);
            lblUserInfo.TabIndex = 22;
            lblUserInfo.Text = "User Info";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.ForeColor = Color.White;
            chkIsActive.Location = new Point(27, 240);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(79, 22);
            chkIsActive.TabIndex = 23;
            chkIsActive.Text = "IsActive";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lnkUpdatePerson
            // 
            lnkUpdatePerson.ActiveLinkColor = Color.FromArgb(249, 115, 22);
            lnkUpdatePerson.AutoSize = true;
            lnkUpdatePerson.BackColor = Color.FromArgb(47, 59, 73);
            lnkUpdatePerson.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkUpdatePerson.LinkColor = Color.White;
            lnkUpdatePerson.Location = new Point(12, 295);
            lnkUpdatePerson.Name = "lnkUpdatePerson";
            lnkUpdatePerson.Size = new Size(98, 16);
            lnkUpdatePerson.TabIndex = 24;
            lnkUpdatePerson.TabStop = true;
            lnkUpdatePerson.Text = "UpdatePerson";
            lnkUpdatePerson.VisitedLinkColor = Color.White;
            lnkUpdatePerson.LinkClicked += linkUpdatePerson_LinkClicked;
            // 
            // frmAddUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(329, 340);
            Controls.Add(lnkUpdatePerson);
            Controls.Add(chkIsActive);
            Controls.Add(lblUserInfo);
            Controls.Add(btnSave);
            Controls.Add(lblPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddUserInfo";
            Text = "frmAddUserInfo";
            Load += frmAddUserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Sunny.UI.UILabel lblUsername;
        private Sunny.UI.UILabel lblConfirmPassword;
        private Sunny.UI.UILabel lblPassword;
        private Button btnSave;
        private Sunny.UI.UILabel lblUserInfo;
        private CheckBox chkIsActive;
        private LinkLabel lnkUpdatePerson;
    }
}