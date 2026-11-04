namespace DVLD_Presentation.Tests
{
    partial class frmIssueDriverLicenseFirstTime
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
            ucLocalDrivingLicenseApplicationInfo = new DVLD_Presentation.User_Controls.ucLocalDrivingLicenseApplicationInfo();
            ucApplicationBasicInfo = new DVLD_Presentation.User_Controls.ucApplicationBasicInfo();
            txtNotes = new Sunny.UI.UITextBox();
            lblNotes = new Sunny.UI.UILabel();
            btnIssue = new Button();
            SuspendLayout();
            // 
            // ucLocalDrivingLicenseApplicationInfo
            // 
            ucLocalDrivingLicenseApplicationInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucLocalDrivingLicenseApplicationInfo.EnableShowLicense = true;
            ucLocalDrivingLicenseApplicationInfo.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucLocalDrivingLicenseApplicationInfo.Location = new Point(12, 12);
            ucLocalDrivingLicenseApplicationInfo.Name = "ucLocalDrivingLicenseApplicationInfo";
            ucLocalDrivingLicenseApplicationInfo.Size = new Size(534, 159);
            ucLocalDrivingLicenseApplicationInfo.TabIndex = 0;
            // 
            // ucApplicationBasicInfo
            // 
            ucApplicationBasicInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucApplicationBasicInfo.Location = new Point(12, 168);
            ucApplicationBasicInfo.Name = "ucApplicationBasicInfo";
            ucApplicationBasicInfo.Size = new Size(534, 369);
            ucApplicationBasicInfo.TabIndex = 1;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(47, 59, 73);
            txtNotes.FillColor = Color.FromArgb(47, 59, 73);
            txtNotes.FillDisableColor = Color.White;
            txtNotes.Font = new Font("Microsoft Sans Serif", 12F);
            txtNotes.ForeColor = Color.White;
            txtNotes.Location = new Point(36, 559);
            txtNotes.Margin = new Padding(4, 5, 4, 5);
            txtNotes.MinimumSize = new Size(1, 16);
            txtNotes.Name = "txtNotes";
            txtNotes.Padding = new Padding(5);
            txtNotes.RectColor = Color.White;
            txtNotes.ShowText = false;
            txtNotes.Size = new Size(362, 67);
            txtNotes.TabIndex = 41;
            txtNotes.TextAlignment = ContentAlignment.MiddleLeft;
            txtNotes.Watermark = "";
            // 
            // lblNotes
            // 
            lblNotes.BackColor = Color.FromArgb(47, 59, 73);
            lblNotes.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotes.ForeColor = Color.White;
            lblNotes.Location = new Point(35, 540);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(89, 23);
            lblNotes.TabIndex = 42;
            lblNotes.Text = "Notes";
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.FromArgb(249, 115, 22);
            btnIssue.FlatAppearance.BorderSize = 0;
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.ForeColor = Color.White;
            btnIssue.Location = new Point(420, 573);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(126, 37);
            btnIssue.TabIndex = 43;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(571, 640);
            Controls.Add(btnIssue);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(ucApplicationBasicInfo);
            Controls.Add(ucLocalDrivingLicenseApplicationInfo);
            Name = "frmIssueDriverLicenseFirstTime";
            Text = "frmShowLicenseInfo";
            Load += frmIssueDriverLicenseFirstTime_Load;
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.ucLocalDrivingLicenseApplicationInfo ucLocalDrivingLicenseApplicationInfo;
        private User_Controls.ucApplicationBasicInfo ucApplicationBasicInfo;
        private Sunny.UI.UITextBox txtNotes;
        private Sunny.UI.UILabel lblNotes;
        private Button btnIssue;
    }
}