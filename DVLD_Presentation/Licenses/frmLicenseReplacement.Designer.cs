namespace DVLD_Presentation.Licenses
{
    partial class frmLicenseReplacement
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
            lblTitle = new Sunny.UI.UILabel();
            ucDriverLicenseInfo = new DVLD_Presentation.User_Controls.ucDriverLicenseInfo();
            grpReplacementFor = new GroupBox();
            rbLostLicense = new Sunny.UI.UIRadioButton();
            rbDamagedLicense = new Sunny.UI.UIRadioButton();
            ucApplicationInfoForLicenseReplacement = new DVLD_Presentation.User_Controls.ucApplicationInfoForLicenseReplacement();
            btnIssueReplacement = new Button();
            txtSearchLicense = new TextBox();
            pnlTextBorder = new Panel();
            lblLicenseID = new Sunny.UI.UILabel();
            btnSearch = new Button();
            grpReplacementFor.SuspendLayout();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(47, 59, 73);
            lblTitle.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(-3, -1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(388, 35);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "Replacement for Damaged License";
            // 
            // ucDriverLicenseInfo
            // 
            ucDriverLicenseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucDriverLicenseInfo.Location = new Point(-3, 47);
            ucDriverLicenseInfo.Name = "ucDriverLicenseInfo";
            ucDriverLicenseInfo.Size = new Size(578, 503);
            ucDriverLicenseInfo.TabIndex = 24;
            // 
            // grpReplacementFor
            // 
            grpReplacementFor.Controls.Add(rbLostLicense);
            grpReplacementFor.Controls.Add(rbDamagedLicense);
            grpReplacementFor.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpReplacementFor.ForeColor = Color.White;
            grpReplacementFor.Location = new Point(581, 63);
            grpReplacementFor.Name = "grpReplacementFor";
            grpReplacementFor.Size = new Size(290, 63);
            grpReplacementFor.TabIndex = 26;
            grpReplacementFor.TabStop = false;
            grpReplacementFor.Text = "Replacement For";
            // 
            // rbLostLicense
            // 
            rbLostLicense.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbLostLicense.ForeColor = Color.White;
            rbLostLicense.Location = new Point(158, 26);
            rbLostLicense.MinimumSize = new Size(1, 1);
            rbLostLicense.Name = "rbLostLicense";
            rbLostLicense.RadioButtonColor = Color.FromArgb(249, 115, 22);
            rbLostLicense.Size = new Size(114, 29);
            rbLostLicense.TabIndex = 11;
            rbLostLicense.Text = "Lost License";
            rbLostLicense.CheckedChanged += rbLostLicense_CheckedChanged;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.Checked = true;
            rbDamagedLicense.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDamagedLicense.ForeColor = Color.White;
            rbDamagedLicense.Location = new Point(6, 26);
            rbDamagedLicense.MinimumSize = new Size(1, 1);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.RadioButtonColor = Color.FromArgb(249, 115, 22);
            rbDamagedLicense.Size = new Size(159, 29);
            rbDamagedLicense.TabIndex = 10;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // ucApplicationInfoForLicenseReplacement
            // 
            ucApplicationInfoForLicenseReplacement.BackColor = Color.FromArgb(0, 15, 33);
            ucApplicationInfoForLicenseReplacement.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucApplicationInfoForLicenseReplacement.Location = new Point(581, 132);
            ucApplicationInfoForLicenseReplacement.Name = "ucApplicationInfoForLicenseReplacement";
            ucApplicationInfoForLicenseReplacement.Size = new Size(294, 333);
            ucApplicationInfoForLicenseReplacement.TabIndex = 27;
            // 
            // btnIssueReplacement
            // 
            btnIssueReplacement.BackColor = Color.FromArgb(249, 115, 22);
            btnIssueReplacement.FlatAppearance.BorderSize = 0;
            btnIssueReplacement.FlatStyle = FlatStyle.Flat;
            btnIssueReplacement.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueReplacement.ForeColor = Color.White;
            btnIssueReplacement.Location = new Point(662, 490);
            btnIssueReplacement.Name = "btnIssueReplacement";
            btnIssueReplacement.Size = new Size(191, 46);
            btnIssueReplacement.TabIndex = 28;
            btnIssueReplacement.Text = "Issue Replacement";
            btnIssueReplacement.UseVisualStyleBackColor = false;
            btnIssueReplacement.Click += btnIssueReplacement_Click;
            // 
            // txtSearchLicense
            // 
            txtSearchLicense.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchLicense.BorderStyle = BorderStyle.None;
            txtSearchLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchLicense.ForeColor = Color.White;
            txtSearchLicense.Location = new Point(3, 3);
            txtSearchLicense.Multiline = true;
            txtSearchLicense.Name = "txtSearchLicense";
            txtSearchLicense.Size = new Size(230, 26);
            txtSearchLicense.TabIndex = 3;
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchLicense);
            pnlTextBorder.Location = new Point(513, 9);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(233, 32);
            pnlTextBorder.TabIndex = 29;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // lblLicenseID
            // 
            lblLicenseID.BackColor = Color.FromArgb(47, 59, 73);
            lblLicenseID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseID.ForeColor = Color.White;
            lblLicenseID.Location = new Point(407, 14);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(89, 24);
            lblLicenseID.TabIndex = 31;
            lblLicenseID.Text = "License ID:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(785, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmLicenseReplacement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(883, 548);
            Controls.Add(lblLicenseID);
            Controls.Add(pnlTextBorder);
            Controls.Add(btnIssueReplacement);
            Controls.Add(btnSearch);
            Controls.Add(ucApplicationInfoForLicenseReplacement);
            Controls.Add(grpReplacementFor);
            Controls.Add(ucDriverLicenseInfo);
            Controls.Add(lblTitle);
            Name = "frmLicenseReplacement";
            Text = "frmLicenseReplacement";
            Load += frmLicenseReplacement_Load;
            grpReplacementFor.ResumeLayout(false);
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lblTitle;
        private User_Controls.ucDriverLicenseInfo ucDriverLicenseInfo;
        private GroupBox grpReplacementFor;
        private Sunny.UI.UIRadioButton rbLostLicense;
        private Sunny.UI.UIRadioButton rbDamagedLicense;
        private User_Controls.ucApplicationInfoForLicenseReplacement ucApplicationInfoForLicenseReplacement;
        private Button btnIssueReplacement;
        private TextBox txtSearchLicense;
        private Panel pnlTextBorder;
        private Sunny.UI.UILabel lblLicenseID;
        private Button btnSearch;
    }
}