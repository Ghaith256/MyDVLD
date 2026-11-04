namespace DVLD_Presentation.Licenses
{
    partial class frmDetainLicense
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
            lblLicenseID = new Sunny.UI.UILabel();
            btnSearch = new Button();
            ucDriverLicenseInfo = new DVLD_Presentation.User_Controls.ucDriverLicenseInfo();
            lblTitle = new Sunny.UI.UILabel();
            pnlTextBorder = new Panel();
            txtSearchLicense = new TextBox();
            ucDetainInfo = new DVLD_Presentation.User_Controls.ucDetainInfo();
            btnDetain = new Button();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // lblLicenseID
            // 
            lblLicenseID.BackColor = Color.FromArgb(47, 59, 73);
            lblLicenseID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseID.ForeColor = Color.White;
            lblLicenseID.Location = new Point(410, 14);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(89, 24);
            lblLicenseID.TabIndex = 37;
            lblLicenseID.Text = "License ID:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(776, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 36;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ucDriverLicenseInfo
            // 
            ucDriverLicenseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucDriverLicenseInfo.Location = new Point(0, 47);
            ucDriverLicenseInfo.Name = "ucDriverLicenseInfo";
            ucDriverLicenseInfo.Size = new Size(578, 503);
            ucDriverLicenseInfo.TabIndex = 34;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(47, 59, 73);
            lblTitle.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, -1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 35);
            lblTitle.TabIndex = 33;
            lblTitle.Text = "Detain License";
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchLicense);
            pnlTextBorder.Location = new Point(521, 9);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(231, 32);
            pnlTextBorder.TabIndex = 38;
            // 
            // txtSearchLicense
            // 
            txtSearchLicense.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchLicense.BorderStyle = BorderStyle.None;
            txtSearchLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchLicense.ForeColor = Color.White;
            txtSearchLicense.Location = new Point(12, 5);
            txtSearchLicense.Multiline = true;
            txtSearchLicense.Name = "txtSearchLicense";
            txtSearchLicense.Size = new Size(199, 24);
            txtSearchLicense.TabIndex = 3;
            // 
            // ucDetainInfo
            // 
            ucDetainInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucDetainInfo.Location = new Point(584, 206);
            ucDetainInfo.Name = "ucDetainInfo";
            ucDetainInfo.Size = new Size(286, 240);
            ucDetainInfo.TabIndex = 39;
            // 
            // btnDetain
            // 
            btnDetain.BackColor = Color.FromArgb(249, 115, 22);
            btnDetain.FlatAppearance.BorderSize = 0;
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.ForeColor = Color.White;
            btnDetain.Location = new Point(716, 477);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(122, 47);
            btnDetain.TabIndex = 40;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = false;
            btnDetain.Click += btnDetain_Click;
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(883, 548);
            Controls.Add(btnDetain);
            Controls.Add(ucDetainInfo);
            Controls.Add(pnlTextBorder);
            Controls.Add(lblLicenseID);
            Controls.Add(btnSearch);
            Controls.Add(ucDriverLicenseInfo);
            Controls.Add(lblTitle);
            Name = "frmDetainLicense";
            Text = "frmDetainLicense";
            Load += frmDetainLicense_Load;
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel lblLicenseID;
        private Button btnSearch;
        private User_Controls.ucDriverLicenseInfo ucDriverLicenseInfo;
        private Sunny.UI.UILabel lblTitle;
        private Panel pnlTextBorder;
        private TextBox txtSearchLicense;
        private User_Controls.ucDetainInfo ucDetainInfo;
        private Button btnDetain;
    }
}