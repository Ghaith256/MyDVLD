namespace DVLD_Presentation.Detain_License
{
    partial class frmReleaseDetainedLicense
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
            txtSearchLicense = new TextBox();
            btnRelease = new Button();
            pnlTextBorder = new Panel();
            lblLicenseID = new Sunny.UI.UILabel();
            btnSearch = new Button();
            ucDriverLicenseInfo = new DVLD_Presentation.User_Controls.ucDriverLicenseInfo();
            lblTitle = new Sunny.UI.UILabel();
            ucReleaseInfo = new DVLD_Presentation.User_Controls.ucReleaseInfo();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchLicense
            // 
            txtSearchLicense.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchLicense.BorderStyle = BorderStyle.None;
            txtSearchLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchLicense.ForeColor = Color.White;
            txtSearchLicense.Location = new Point(3, 5);
            txtSearchLicense.Multiline = true;
            txtSearchLicense.Name = "txtSearchLicense";
            txtSearchLicense.Size = new Size(225, 24);
            txtSearchLicense.TabIndex = 3;
            // 
            // btnRelease
            // 
            btnRelease.BackColor = Color.FromArgb(249, 115, 22);
            btnRelease.FlatAppearance.BorderSize = 0;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.ForeColor = Color.White;
            btnRelease.Location = new Point(722, 477);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(122, 47);
            btnRelease.TabIndex = 46;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = false;
            btnRelease.Click += btnRelease_Click;
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchLicense);
            pnlTextBorder.Location = new Point(527, 9);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(231, 32);
            pnlTextBorder.TabIndex = 45;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // lblLicenseID
            // 
            lblLicenseID.BackColor = Color.FromArgb(47, 59, 73);
            lblLicenseID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseID.ForeColor = Color.White;
            lblLicenseID.Location = new Point(416, 14);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(89, 24);
            lblLicenseID.TabIndex = 44;
            lblLicenseID.Text = "License ID:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(782, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ucDriverLicenseInfo
            // 
            ucDriverLicenseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucDriverLicenseInfo.Location = new Point(6, 47);
            ucDriverLicenseInfo.Name = "ucDriverLicenseInfo";
            ucDriverLicenseInfo.Size = new Size(578, 503);
            ucDriverLicenseInfo.TabIndex = 42;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(47, 59, 73);
            lblTitle.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(6, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 35);
            lblTitle.TabIndex = 41;
            lblTitle.Text = "Release License";
            // 
            // ucReleaseInfo
            // 
            ucReleaseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucReleaseInfo.Location = new Point(585, 47);
            ucReleaseInfo.Name = "ucReleaseInfo";
            ucReleaseInfo.Size = new Size(286, 411);
            ucReleaseInfo.TabIndex = 47;
            // 
            // frmReleaseDetainedLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(883, 548);
            Controls.Add(ucReleaseInfo);
            Controls.Add(btnRelease);
            Controls.Add(pnlTextBorder);
            Controls.Add(lblLicenseID);
            Controls.Add(btnSearch);
            Controls.Add(ucDriverLicenseInfo);
            Controls.Add(lblTitle);
            Name = "frmReleaseDetainedLicense";
            Text = "frmReleaseDetainedLicense";
            Load += frmReleaseDetainedLicense_Load;
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearchLicense;
        private Button btnRelease;
        private Panel pnlTextBorder;
        private Sunny.UI.UILabel lblLicenseID;
        private Button btnSearch;
        private User_Controls.ucDriverLicenseInfo ucDriverLicenseInfo;
        private Sunny.UI.UILabel lblTitle;
        private User_Controls.ucReleaseInfo ucReleaseInfo;
    }
}