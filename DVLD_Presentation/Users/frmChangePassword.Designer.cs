namespace DVLD_Presentation.Users
{
    partial class frmChangePassword
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
            components = new System.ComponentModel.Container();
            txtOldPassword = new Sunny.UI.UITextBox();
            txtNewPassword = new Sunny.UI.UITextBox();
            txtConfirmPassword = new Sunny.UI.UITextBox();
            lblOldPassword = new Sunny.UI.UILabel();
            lblConfirmPassword = new Sunny.UI.UILabel();
            lblNewPassword = new Sunny.UI.UILabel();
            btnSave = new Button();
            lblChangePassword = new Sunny.UI.UILabel();
            errPasswordMatch = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errPasswordMatch).BeginInit();
            SuspendLayout();
            // 
            // txtOldPassword
            // 
            txtOldPassword.FillColor = Color.FromArgb(55, 65, 81);
            txtOldPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtOldPassword.ForeColor = Color.White;
            txtOldPassword.Location = new Point(181, 51);
            txtOldPassword.Margin = new Padding(4, 5, 4, 5);
            txtOldPassword.MinimumSize = new Size(1, 16);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Padding = new Padding(5);
            txtOldPassword.RectColor = Color.FromArgb(47, 59, 73);
            txtOldPassword.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtOldPassword.ScrollBarStyleInherited = false;
            txtOldPassword.ShowText = false;
            txtOldPassword.Size = new Size(131, 24);
            txtOldPassword.TabIndex = 4;
            txtOldPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtOldPassword.Watermark = "";
            // 
            // txtNewPassword
            // 
            txtNewPassword.FillColor = Color.FromArgb(55, 65, 81);
            txtNewPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtNewPassword.ForeColor = Color.White;
            txtNewPassword.Location = new Point(181, 100);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.MinimumSize = new Size(1, 16);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Padding = new Padding(5);
            txtNewPassword.RectColor = Color.FromArgb(47, 59, 73);
            txtNewPassword.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtNewPassword.ScrollBarStyleInherited = false;
            txtNewPassword.ShowText = false;
            txtNewPassword.Size = new Size(131, 24);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtNewPassword.Watermark = "";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.FillColor = Color.FromArgb(55, 65, 81);
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(181, 147);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.MinimumSize = new Size(1, 16);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(5);
            txtConfirmPassword.RectColor = Color.FromArgb(47, 59, 73);
            txtConfirmPassword.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtConfirmPassword.ScrollBarStyleInherited = false;
            txtConfirmPassword.ShowText = false;
            txtConfirmPassword.Size = new Size(131, 24);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPassword.Watermark = "";
            // 
            // lblOldPassword
            // 
            lblOldPassword.BackColor = Color.FromArgb(47, 59, 73);
            lblOldPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldPassword.ForeColor = Color.White;
            lblOldPassword.Location = new Point(12, 51);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(139, 23);
            lblOldPassword.TabIndex = 9;
            lblOldPassword.Text = "Old Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.BackColor = Color.FromArgb(47, 59, 73);
            lblConfirmPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(12, 148);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(139, 23);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.BackColor = Color.FromArgb(47, 59, 73);
            lblNewPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.White;
            lblNewPassword.Location = new Point(12, 100);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(139, 23);
            lblNewPassword.TabIndex = 11;
            lblNewPassword.Text = "New Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(107, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 30);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblChangePassword
            // 
            lblChangePassword.BackColor = Color.FromArgb(47, 59, 73);
            lblChangePassword.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChangePassword.ForeColor = Color.White;
            lblChangePassword.Location = new Point(-2, 0);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(202, 31);
            lblChangePassword.TabIndex = 23;
            lblChangePassword.Text = "Change Password";
            // 
            // errPasswordMatch
            // 
            errPasswordMatch.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(325, 260);
            Controls.Add(lblChangePassword);
            Controls.Add(btnSave);
            Controls.Add(lblNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtOldPassword);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Cornsilk;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)errPasswordMatch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox txtOldPassword;
        private Sunny.UI.UITextBox txtNewPassword;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Sunny.UI.UILabel lblOldPassword;
        private Sunny.UI.UILabel lblConfirmPassword;
        private Sunny.UI.UILabel lblNewPassword;
        private Button btnSave;
        private Sunny.UI.UILabel lblChangePassword;
        private ErrorProvider errPasswordMatch;
    }
}