namespace DVLD_Presentation.People
{
    partial class frmShowPersonInfo
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
            SuspendLayout();
            // 
            // ucShowInfo
            // 
            ucShowInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucShowInfo.Location = new Point(0, -5);
            ucShowInfo.Name = "ucShowInfo";
            ucShowInfo.Size = new Size(530, 420);
            ucShowInfo.TabIndex = 0;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(526, 408);
            Controls.Add(ucShowInfo);
            Name = "frmShowPersonInfo";
            Text = "frmShowPersonInfo";
            Load += frmShowPersonInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ucShowInfo ucShowInfo;
    }
}