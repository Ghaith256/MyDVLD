namespace DVLD_Presentation.International_Driving_License
{
    partial class frmShowDriverInternationalLicenseInfo
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
            ucDriverInternationalLicenseInfo = new DVLD_Presentation.User_Controls.ucDriverInternationalLicenseInfo();
            SuspendLayout();
            // 
            // ucDriverInternationalLicenseInfo
            // 
            ucDriverInternationalLicenseInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucDriverInternationalLicenseInfo.Location = new Point(12, 12);
            ucDriverInternationalLicenseInfo.Name = "ucDriverInternationalLicenseInfo";
            ucDriverInternationalLicenseInfo.Size = new Size(582, 379);
            ucDriverInternationalLicenseInfo.TabIndex = 0;
            // 
            // frmShowDriverInternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(595, 395);
            Controls.Add(ucDriverInternationalLicenseInfo);
            Name = "frmShowDriverInternationalLicenseInfo";
            Text = "frmShowDriverInternationalLicenseInfo";
            Load += frmShowDriverInternationalLicenseInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.ucDriverInternationalLicenseInfo ucDriverInternationalLicenseInfo;
    }
}