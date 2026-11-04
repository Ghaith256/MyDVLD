namespace DVLD_Presentation.Licenses
{
    partial class frmRenewLicenseApplication
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
            textBox2 = new TextBox();
            lblLicenseID = new Sunny.UI.UILabel();
            btnSearch = new Button();
            pnlTextBorder = new Panel();
            ucDriverLicenseInfo = new DVLD_Presentation.User_Controls.ucDriverLicenseInfo();
            ucApplicationNewLicenseInfo = new DVLD_Presentation.User_Controls.ucApplicationNewLicenseInfo();
            btnRenew = new Button();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 15, 33);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 26);
            textBox2.TabIndex = 3;
            // 
            // lblLicenseID
            // 
            lblLicenseID.BackColor = Color.FromArgb(47, 59, 73);
            lblLicenseID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseID.ForeColor = Color.White;
            lblLicenseID.Location = new Point(619, 18);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(89, 24);
            lblLicenseID.TabIndex = 23;
            lblLicenseID.Text = "License ID:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1081, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(textBox2);
            pnlTextBorder.Location = new Point(747, 12);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(282, 32);
            pnlTextBorder.TabIndex = 25;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // ucDriverLicenseInfo
            // 
            ucDriverLicenseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucDriverLicenseInfo.Location = new Point(12, 12);
            ucDriverLicenseInfo.Name = "ucDriverLicenseInfo";
            ucDriverLicenseInfo.Size = new Size(578, 503);
            ucDriverLicenseInfo.TabIndex = 26;
            // 
            // ucApplicationNewLicenseInfo
            // 
            ucApplicationNewLicenseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucApplicationNewLicenseInfo.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucApplicationNewLicenseInfo.Location = new Point(596, 66);
            ucApplicationNewLicenseInfo.Name = "ucApplicationNewLicenseInfo";
            ucApplicationNewLicenseInfo.Size = new Size(606, 363);
            ucApplicationNewLicenseInfo.TabIndex = 27;
            ucApplicationNewLicenseInfo.Load += ucApplicationNewLicenseInfo_Load;
            // 
            // btnRenew
            // 
            btnRenew.BackColor = Color.FromArgb(249, 115, 22);
            btnRenew.FlatAppearance.BorderSize = 0;
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRenew.ForeColor = Color.White;
            btnRenew.Location = new Point(1054, 435);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(122, 47);
            btnRenew.TabIndex = 28;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = false;
            btnRenew.Click += btnRenew_Click;
            // 
            // frmRenewLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(1214, 518);
            Controls.Add(ucDriverLicenseInfo);
            Controls.Add(btnRenew);
            Controls.Add(ucApplicationNewLicenseInfo);
            Controls.Add(pnlTextBorder);
            Controls.Add(lblLicenseID);
            Controls.Add(btnSearch);
            Name = "frmRenewLicenseApplication";
            Text = "frmRenewLicenseApplication";
            Load += frmRenewLicenseApplication_Load;
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox2;
        private Sunny.UI.UILabel lblLicenseID;
        private Button btnSearch;
        private Panel pnlTextBorder;
        private User_Controls.ucApplicationNewLicenseInfo ucApplicationNewLicenseInfo;
        private Button btnRenew;
        private User_Controls.ucDriverLicenseInfo ucDriverLicenseInfo;
    }
}