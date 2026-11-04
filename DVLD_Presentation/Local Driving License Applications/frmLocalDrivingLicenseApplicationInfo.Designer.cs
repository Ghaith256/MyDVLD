namespace DVLD_Presentation.Local_Driving_License_Applications
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            ucApplicationBasicInfo = new DVLD_Presentation.User_Controls.ucApplicationBasicInfo();
            ucLocalDrivingLicenseApplicationInfo = new DVLD_Presentation.User_Controls.ucLocalDrivingLicenseApplicationInfo();
            SuspendLayout();
            // 
            // ucApplicationBasicInfo
            // 
            ucApplicationBasicInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucApplicationBasicInfo.Location = new Point(22, 180);
            ucApplicationBasicInfo.Name = "ucApplicationBasicInfo";
            ucApplicationBasicInfo.Size = new Size(555, 369);
            ucApplicationBasicInfo.TabIndex = 0;
            // 
            // ucLocalDrivingLicenseApplicationInfo
            // 
            ucLocalDrivingLicenseApplicationInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucLocalDrivingLicenseApplicationInfo.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucLocalDrivingLicenseApplicationInfo.Location = new Point(22, 12);
            ucLocalDrivingLicenseApplicationInfo.Name = "ucLocalDrivingLicenseApplicationInfo";
            ucLocalDrivingLicenseApplicationInfo.Size = new Size(534, 159);
            ucLocalDrivingLicenseApplicationInfo.TabIndex = 1;
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(592, 561);
            Controls.Add(ucLocalDrivingLicenseApplicationInfo);
            Controls.Add(ucApplicationBasicInfo);
            Name = "frmLocalDrivingLicenseApplicationInfo";
            Text = "frmLocalDrivingLicenseApplicationInfo";
            Load += frmLocalDrivingLicenseApplicationInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.ucApplicationBasicInfo ucApplicationBasicInfo;
        private User_Controls.ucLocalDrivingLicenseApplicationInfo ucLocalDrivingLicenseApplicationInfo;
    }
}