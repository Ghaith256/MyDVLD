namespace DVLD_Presentation.Users
{
    partial class frmShowUserInfo
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
            ucShowAllInfo = new ucShowAllInfo();
            SuspendLayout();
            // 
            // ucShowAllInfo
            // 
            ucShowAllInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucShowAllInfo.Location = new Point(-1, 0);
            ucShowAllInfo.Name = "ucShowAllInfo";
            ucShowAllInfo.Size = new Size(756, 420);
            ucShowAllInfo.TabIndex = 0;
            // 
            // frmShowUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 419);
            Controls.Add(ucShowAllInfo);
            Name = "frmShowUserInfo";
            Text = "frmShowUserInfo";
            Load += frmShowUserInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ucShowAllInfo ucShowAllInfo;
    }
}