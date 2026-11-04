namespace DVLD_Presentation.International_Driving_License
{
    partial class frmAddInternationalLicenseApplication
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
            ucDriverLicenseInfo = new DVLD_Presentation.User_Controls.ucDriverLicenseInfo();
            ucApplicationInfo = new DVLD_Presentation.User_Controls.ucApplicationInfo();
            pnlTextBorder = new Panel();
            txtSearchLicense = new TextBox();
            btnSearch = new Button();
            lblLicenseID = new Sunny.UI.UILabel();
            btnAdd = new Button();
            lnkShowLicensesHistory = new LinkLabel();
            lnkShowLicenseInfo = new LinkLabel();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // ucDriverLicenseInfo
            // 
            ucDriverLicenseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucDriverLicenseInfo.Location = new Point(12, 7);
            ucDriverLicenseInfo.Name = "ucDriverLicenseInfo";
            ucDriverLicenseInfo.Size = new Size(578, 503);
            ucDriverLicenseInfo.TabIndex = 0;
            // 
            // ucApplicationInfo
            // 
            ucApplicationInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucApplicationInfo.Location = new Point(596, 85);
            ucApplicationInfo.Name = "ucApplicationInfo";
            ucApplicationInfo.Size = new Size(569, 282);
            ucApplicationInfo.TabIndex = 1;
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchLicense);
            pnlTextBorder.Location = new Point(742, 12);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(280, 35);
            pnlTextBorder.TabIndex = 14;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchLicense
            // 
            txtSearchLicense.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchLicense.BorderStyle = BorderStyle.None;
            txtSearchLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchLicense.ForeColor = Color.White;
            txtSearchLicense.Location = new Point(0, 2);
            txtSearchLicense.Multiline = true;
            txtSearchLicense.Name = "txtSearchLicense";
            txtSearchLicense.Size = new Size(274, 32);
            txtSearchLicense.TabIndex = 2;
            txtSearchLicense.TextChanged += txtSearchLicense_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1058, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblLicenseID
            // 
            lblLicenseID.BackColor = Color.FromArgb(47, 59, 73);
            lblLicenseID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseID.ForeColor = Color.White;
            lblLicenseID.Location = new Point(596, 23);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(89, 24);
            lblLicenseID.TabIndex = 21;
            lblLicenseID.Text = "License ID:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(249, 115, 22);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1058, 382);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 32);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lnkShowLicensesHistory
            // 
            lnkShowLicensesHistory.ActiveLinkColor = Color.FromArgb(249, 115, 22);
            lnkShowLicensesHistory.AutoSize = true;
            lnkShowLicensesHistory.BackColor = Color.FromArgb(47, 59, 73);
            lnkShowLicensesHistory.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkShowLicensesHistory.LinkColor = Color.White;
            lnkShowLicensesHistory.Location = new Point(612, 398);
            lnkShowLicensesHistory.Name = "lnkShowLicensesHistory";
            lnkShowLicensesHistory.Size = new Size(152, 16);
            lnkShowLicensesHistory.TabIndex = 25;
            lnkShowLicensesHistory.TabStop = true;
            lnkShowLicensesHistory.Text = "Show Licenses History";
            lnkShowLicensesHistory.VisitedLinkColor = Color.White;
            lnkShowLicensesHistory.LinkClicked += lnkShowLicensesHistory_LinkClicked;
            // 
            // lnkShowLicenseInfo
            // 
            lnkShowLicenseInfo.ActiveLinkColor = Color.FromArgb(249, 115, 22);
            lnkShowLicenseInfo.AutoSize = true;
            lnkShowLicenseInfo.BackColor = Color.FromArgb(47, 59, 73);
            lnkShowLicenseInfo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkShowLicenseInfo.LinkColor = Color.White;
            lnkShowLicenseInfo.Location = new Point(825, 398);
            lnkShowLicenseInfo.Name = "lnkShowLicenseInfo";
            lnkShowLicenseInfo.Size = new Size(131, 16);
            lnkShowLicenseInfo.TabIndex = 26;
            lnkShowLicenseInfo.TabStop = true;
            lnkShowLicenseInfo.Text = "Show Licenses Info";
            lnkShowLicenseInfo.VisitedLinkColor = Color.White;
            lnkShowLicenseInfo.LinkClicked += lnkShowLicenseInfo_LinkClicked;
            // 
            // frmAddInternationalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(1177, 522);
            Controls.Add(lnkShowLicenseInfo);
            Controls.Add(lnkShowLicensesHistory);
            Controls.Add(btnAdd);
            Controls.Add(lblLicenseID);
            Controls.Add(btnSearch);
            Controls.Add(pnlTextBorder);
            Controls.Add(ucApplicationInfo);
            Controls.Add(ucDriverLicenseInfo);
            Name = "frmAddInternationalLicenseApplication";
            Text = "frmAddInternationalLicenseApplication";
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.ucDriverLicenseInfo ucDriverLicenseInfo;
        private User_Controls.ucApplicationInfo ucApplicationInfo;
        private Panel pnlTextBorder;
        private Button btnSearch;
        private Sunny.UI.UILabel lblLicenseID;
        private Button btnAdd;
        private LinkLabel lnkShowLicensesHistory;
        private LinkLabel lnkShowLicenseInfo;
        private TextBox txtSearchLicense;
    }
}