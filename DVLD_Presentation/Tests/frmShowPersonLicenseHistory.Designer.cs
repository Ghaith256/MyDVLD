namespace DVLD_Presentation.Tests
{
    partial class frmShowPersonLicenseHistory
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
            ucShowInfo = new ucShowInfo();
            ucShowDriverLicensesHistory = new DVLD_Presentation.User_Controls.ucShowDriverLicensesHistory();
            SuspendLayout();
            // 
            // ucShowInfo
            // 
            ucShowInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucShowInfo.Location = new Point(4, 12);
            ucShowInfo.Name = "ucShowInfo";
            ucShowInfo.Size = new Size(530, 416);
            ucShowInfo.TabIndex = 0;
            // 
            // ucShowDriverLicensesHistory
            // 
            ucShowDriverLicensesHistory.BackColor = Color.FromArgb(0, 15, 33);
            ucShowDriverLicensesHistory.Location = new Point(540, 25);
            ucShowDriverLicensesHistory.Name = "ucShowDriverLicensesHistory";
            ucShowDriverLicensesHistory.Size = new Size(631, 387);
            ucShowDriverLicensesHistory.TabIndex = 1;
            // 
            // frmShowPersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(1183, 444);
            Controls.Add(ucShowDriverLicensesHistory);
            Controls.Add(ucShowInfo);
            Name = "frmShowPersonLicenseHistory";
            Text = "frmShowPersonLicenseHistory";
            Load += frmShowPersonLicenseHistory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ucShowInfo ucShowInfo;
        private User_Controls.ucShowDriverLicensesHistory ucShowDriverLicensesHistory;
    }
}