namespace DVLD_Presentation.Main_Menu
{
    partial class frmApplicationsMainMenu
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
            components = new System.ComponentModel.Container();
            lblApplications = new Sunny.UI.UILabel();
            pnlDrivingLicenseServices = new Panel();
            lblDrivingLicenseServices = new Label();
            iconDrivingLicenseServices = new FontAwesome.Sharp.IconPictureBox();
            pnlManageApplications = new Panel();
            cxmManageApplications = new ContextMenuStrip(components);
            toolStripMenuItemLocalLicense = new ToolStripMenuItem();
            toolStripMenuItemInternationalLicense = new ToolStripMenuItem();
            lblManageApplications = new Label();
            iconManageApplications = new FontAwesome.Sharp.IconPictureBox();
            pnlDetainLicenses = new Panel();
            cxmDetainLicenses = new ContextMenuStrip(components);
            toolStripMenuItemManageDetainedLicenses = new ToolStripMenuItem();
            toolStripMenuItemDetainLicense = new ToolStripMenuItem();
            toolStripMenuItemReleaseDetainedLicense = new ToolStripMenuItem();
            lblDetainLicenses = new Label();
            iconDetainLicenses = new FontAwesome.Sharp.IconPictureBox();
            pnlManageApplicationTypes = new Panel();
            lblManageApplicationTypes = new Label();
            iconManageApplicationTypes = new FontAwesome.Sharp.IconPictureBox();
            pnlManageTestTypes = new Panel();
            blManageTestTypes = new Label();
            iconManageTestTypes = new FontAwesome.Sharp.IconPictureBox();
            pnlDrivingLicenseServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDrivingLicenseServices).BeginInit();
            pnlManageApplications.SuspendLayout();
            cxmManageApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconManageApplications).BeginInit();
            pnlDetainLicenses.SuspendLayout();
            cxmDetainLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDetainLicenses).BeginInit();
            pnlManageApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconManageApplicationTypes).BeginInit();
            pnlManageTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconManageTestTypes).BeginInit();
            SuspendLayout();
            // 
            // lblApplications
            // 
            lblApplications.BackColor = Color.FromArgb(47, 59, 73);
            lblApplications.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplications.ForeColor = Color.White;
            lblApplications.Location = new Point(-1, 0);
            lblApplications.Name = "lblApplications";
            lblApplications.Size = new Size(139, 31);
            lblApplications.TabIndex = 23;
            lblApplications.Text = "Applications";
            // 
            // pnlDrivingLicenseServices
            // 
            pnlDrivingLicenseServices.BackColor = Color.FromArgb(12, 22, 50);
            pnlDrivingLicenseServices.Controls.Add(lblDrivingLicenseServices);
            pnlDrivingLicenseServices.Controls.Add(iconDrivingLicenseServices);
            pnlDrivingLicenseServices.Cursor = Cursors.Hand;
            pnlDrivingLicenseServices.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDrivingLicenseServices.Location = new Point(30, 60);
            pnlDrivingLicenseServices.Name = "pnlDrivingLicenseServices";
            pnlDrivingLicenseServices.Size = new Size(305, 69);
            pnlDrivingLicenseServices.TabIndex = 24;
            pnlDrivingLicenseServices.Click += pnlDrivingLicenseServices_Click;
            pnlDrivingLicenseServices.MouseEnter += panel_MouseEnter;
            pnlDrivingLicenseServices.MouseLeave += panel_MouseLeave;
            // 
            // lblDrivingLicenseServices
            // 
            lblDrivingLicenseServices.AutoSize = true;
            lblDrivingLicenseServices.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrivingLicenseServices.ForeColor = Color.White;
            lblDrivingLicenseServices.Location = new Point(62, 24);
            lblDrivingLicenseServices.Name = "lblDrivingLicenseServices";
            lblDrivingLicenseServices.Size = new Size(217, 21);
            lblDrivingLicenseServices.TabIndex = 5;
            lblDrivingLicenseServices.Text = "Driving License Services";
            lblDrivingLicenseServices.Click += pnlDrivingLicenseServices_Click;
            lblDrivingLicenseServices.MouseEnter += panel_MouseEnter;
            lblDrivingLicenseServices.MouseLeave += panel_MouseLeave;
            // 
            // iconDrivingLicenseServices
            // 
            iconDrivingLicenseServices.BackColor = Color.FromArgb(12, 22, 50);
            iconDrivingLicenseServices.Enabled = false;
            iconDrivingLicenseServices.ForeColor = Color.FromArgb(249, 115, 22);
            iconDrivingLicenseServices.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconDrivingLicenseServices.IconColor = Color.FromArgb(249, 115, 22);
            iconDrivingLicenseServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDrivingLicenseServices.IconSize = 53;
            iconDrivingLicenseServices.Location = new Point(3, 3);
            iconDrivingLicenseServices.Name = "iconDrivingLicenseServices";
            iconDrivingLicenseServices.Size = new Size(53, 63);
            iconDrivingLicenseServices.SizeMode = PictureBoxSizeMode.Zoom;
            iconDrivingLicenseServices.TabIndex = 0;
            iconDrivingLicenseServices.TabStop = false;
            iconDrivingLicenseServices.Click += pnlDrivingLicenseServices_Click;
            iconDrivingLicenseServices.MouseEnter += panel_MouseEnter;
            iconDrivingLicenseServices.MouseLeave += panel_MouseLeave;
            // 
            // pnlManageApplications
            // 
            pnlManageApplications.BackColor = Color.FromArgb(12, 22, 50);
            pnlManageApplications.ContextMenuStrip = cxmManageApplications;
            pnlManageApplications.Controls.Add(lblManageApplications);
            pnlManageApplications.Controls.Add(iconManageApplications);
            pnlManageApplications.Cursor = Cursors.Hand;
            pnlManageApplications.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlManageApplications.Location = new Point(33, 165);
            pnlManageApplications.Name = "pnlManageApplications";
            pnlManageApplications.Size = new Size(302, 69);
            pnlManageApplications.TabIndex = 25;
            pnlManageApplications.Click += pnlManageApplications_Click;
            pnlManageApplications.MouseEnter += panel_MouseEnter;
            pnlManageApplications.MouseLeave += panel_MouseLeave;
            // 
            // cxmManageApplications
            // 
            cxmManageApplications.BackColor = Color.FromArgb(0, 15, 33);
            cxmManageApplications.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cxmManageApplications.Items.AddRange(new ToolStripItem[] { toolStripMenuItemLocalLicense, toolStripMenuItemInternationalLicense });
            cxmManageApplications.Name = "cxmNewDrivingLicense";
            cxmManageApplications.ShowImageMargin = false;
            cxmManageApplications.ShowItemToolTips = false;
            cxmManageApplications.Size = new Size(211, 48);
            // 
            // toolStripMenuItemLocalLicense
            // 
            toolStripMenuItemLocalLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItemLocalLicense.ForeColor = Color.White;
            toolStripMenuItemLocalLicense.Name = "toolStripMenuItemLocalLicense";
            toolStripMenuItemLocalLicense.Size = new Size(210, 22);
            toolStripMenuItemLocalLicense.Text = "Local License";
            toolStripMenuItemLocalLicense.Click += toolStripMenuItemLocalLicense_Click;
            // 
            // toolStripMenuItemInternationalLicense
            // 
            toolStripMenuItemInternationalLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItemInternationalLicense.ForeColor = Color.White;
            toolStripMenuItemInternationalLicense.Name = "toolStripMenuItemInternationalLicense";
            toolStripMenuItemInternationalLicense.Size = new Size(210, 22);
            toolStripMenuItemInternationalLicense.Text = "International License";
            toolStripMenuItemInternationalLicense.Click += toolStripMenuItemInternationalLicense_Click;
            // 
            // lblManageApplications
            // 
            lblManageApplications.AutoSize = true;
            lblManageApplications.ContextMenuStrip = cxmManageApplications;
            lblManageApplications.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageApplications.ForeColor = Color.White;
            lblManageApplications.Location = new Point(62, 24);
            lblManageApplications.Name = "lblManageApplications";
            lblManageApplications.Size = new Size(188, 21);
            lblManageApplications.TabIndex = 5;
            lblManageApplications.Text = "Manage Applications";
            lblManageApplications.MouseEnter += panel_MouseEnter;
            lblManageApplications.MouseLeave += panel_MouseLeave;
            // 
            // iconManageApplications
            // 
            iconManageApplications.BackColor = Color.FromArgb(12, 22, 50);
            iconManageApplications.ContextMenuStrip = cxmManageApplications;
            iconManageApplications.Enabled = false;
            iconManageApplications.ForeColor = Color.FromArgb(249, 115, 22);
            iconManageApplications.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconManageApplications.IconColor = Color.FromArgb(249, 115, 22);
            iconManageApplications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconManageApplications.IconSize = 53;
            iconManageApplications.Location = new Point(3, 3);
            iconManageApplications.Name = "iconManageApplications";
            iconManageApplications.Size = new Size(53, 63);
            iconManageApplications.SizeMode = PictureBoxSizeMode.Zoom;
            iconManageApplications.TabIndex = 0;
            iconManageApplications.TabStop = false;
            iconManageApplications.MouseEnter += panel_MouseEnter;
            iconManageApplications.MouseLeave += panel_MouseLeave;
            // 
            // pnlDetainLicenses
            // 
            pnlDetainLicenses.BackColor = Color.FromArgb(12, 22, 50);
            pnlDetainLicenses.ContextMenuStrip = cxmDetainLicenses;
            pnlDetainLicenses.Controls.Add(lblDetainLicenses);
            pnlDetainLicenses.Controls.Add(iconDetainLicenses);
            pnlDetainLicenses.Cursor = Cursors.Hand;
            pnlDetainLicenses.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDetainLicenses.Location = new Point(33, 266);
            pnlDetainLicenses.Name = "pnlDetainLicenses";
            pnlDetainLicenses.Size = new Size(302, 69);
            pnlDetainLicenses.TabIndex = 26;
            pnlDetainLicenses.Click += pnlDetainLicenses_Click;
            pnlDetainLicenses.MouseEnter += panel_MouseEnter;
            pnlDetainLicenses.MouseLeave += panel_MouseLeave;
            // 
            // cxmDetainLicenses
            // 
            cxmDetainLicenses.BackColor = Color.FromArgb(0, 15, 33);
            cxmDetainLicenses.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cxmDetainLicenses.Items.AddRange(new ToolStripItem[] { toolStripMenuItemManageDetainedLicenses, toolStripMenuItemDetainLicense, toolStripMenuItemReleaseDetainedLicense });
            cxmDetainLicenses.Name = "cxmNewDrivingLicense";
            cxmDetainLicenses.ShowImageMargin = false;
            cxmDetainLicenses.ShowItemToolTips = false;
            cxmDetainLicenses.Size = new Size(249, 70);
            // 
            // toolStripMenuItemManageDetainedLicenses
            // 
            toolStripMenuItemManageDetainedLicenses.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItemManageDetainedLicenses.ForeColor = Color.White;
            toolStripMenuItemManageDetainedLicenses.Name = "toolStripMenuItemManageDetainedLicenses";
            toolStripMenuItemManageDetainedLicenses.Size = new Size(248, 22);
            toolStripMenuItemManageDetainedLicenses.Text = "Manage Detained Licenses";
            toolStripMenuItemManageDetainedLicenses.Click += toolStripMenuItemManageDetainedLicenses_Click;
            // 
            // toolStripMenuItemDetainLicense
            // 
            toolStripMenuItemDetainLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItemDetainLicense.ForeColor = Color.White;
            toolStripMenuItemDetainLicense.Name = "toolStripMenuItemDetainLicense";
            toolStripMenuItemDetainLicense.Size = new Size(248, 22);
            toolStripMenuItemDetainLicense.Text = "Detain License";
            toolStripMenuItemDetainLicense.Click += toolStripMenuItemDetainLicense_Click;
            // 
            // toolStripMenuItemReleaseDetainedLicense
            // 
            toolStripMenuItemReleaseDetainedLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItemReleaseDetainedLicense.ForeColor = Color.White;
            toolStripMenuItemReleaseDetainedLicense.Name = "toolStripMenuItemReleaseDetainedLicense";
            toolStripMenuItemReleaseDetainedLicense.Size = new Size(248, 22);
            toolStripMenuItemReleaseDetainedLicense.Text = "Release Detained License";
            toolStripMenuItemReleaseDetainedLicense.Click += toolStripMenuItemReleaseDetainedLicense_Click;
            // 
            // lblDetainLicenses
            // 
            lblDetainLicenses.AutoSize = true;
            lblDetainLicenses.ContextMenuStrip = cxmDetainLicenses;
            lblDetainLicenses.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainLicenses.ForeColor = Color.White;
            lblDetainLicenses.Location = new Point(62, 24);
            lblDetainLicenses.Name = "lblDetainLicenses";
            lblDetainLicenses.Size = new Size(144, 21);
            lblDetainLicenses.TabIndex = 5;
            lblDetainLicenses.Text = "Detain Licenses";
            lblDetainLicenses.MouseEnter += panel_MouseEnter;
            lblDetainLicenses.MouseLeave += panel_MouseLeave;
            // 
            // iconDetainLicenses
            // 
            iconDetainLicenses.BackColor = Color.FromArgb(12, 22, 50);
            iconDetainLicenses.ContextMenuStrip = cxmDetainLicenses;
            iconDetainLicenses.Enabled = false;
            iconDetainLicenses.ForeColor = Color.FromArgb(249, 115, 22);
            iconDetainLicenses.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconDetainLicenses.IconColor = Color.FromArgb(249, 115, 22);
            iconDetainLicenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDetainLicenses.IconSize = 53;
            iconDetainLicenses.Location = new Point(3, 3);
            iconDetainLicenses.Name = "iconDetainLicenses";
            iconDetainLicenses.Size = new Size(53, 63);
            iconDetainLicenses.SizeMode = PictureBoxSizeMode.Zoom;
            iconDetainLicenses.TabIndex = 0;
            iconDetainLicenses.TabStop = false;
            iconDetainLicenses.MouseEnter += panel_MouseEnter;
            iconDetainLicenses.MouseLeave += panel_MouseLeave;
            // 
            // pnlManageApplicationTypes
            // 
            pnlManageApplicationTypes.BackColor = Color.FromArgb(12, 22, 50);
            pnlManageApplicationTypes.Controls.Add(lblManageApplicationTypes);
            pnlManageApplicationTypes.Controls.Add(iconManageApplicationTypes);
            pnlManageApplicationTypes.Cursor = Cursors.Hand;
            pnlManageApplicationTypes.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlManageApplicationTypes.Location = new Point(33, 375);
            pnlManageApplicationTypes.Name = "pnlManageApplicationTypes";
            pnlManageApplicationTypes.Size = new Size(302, 69);
            pnlManageApplicationTypes.TabIndex = 27;
            pnlManageApplicationTypes.Click += pnlManageApplicationTypes_Click;
            pnlManageApplicationTypes.MouseEnter += panel_MouseEnter;
            pnlManageApplicationTypes.MouseLeave += panel_MouseLeave;
            // 
            // lblManageApplicationTypes
            // 
            lblManageApplicationTypes.AutoSize = true;
            lblManageApplicationTypes.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageApplicationTypes.ForeColor = Color.White;
            lblManageApplicationTypes.Location = new Point(62, 24);
            lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            lblManageApplicationTypes.Size = new Size(234, 21);
            lblManageApplicationTypes.TabIndex = 5;
            lblManageApplicationTypes.Text = "Manage Application Types";
            lblManageApplicationTypes.MouseEnter += panel_MouseEnter;
            lblManageApplicationTypes.MouseLeave += panel_MouseLeave;
            // 
            // iconManageApplicationTypes
            // 
            iconManageApplicationTypes.BackColor = Color.FromArgb(12, 22, 50);
            iconManageApplicationTypes.Enabled = false;
            iconManageApplicationTypes.ForeColor = Color.FromArgb(249, 115, 22);
            iconManageApplicationTypes.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconManageApplicationTypes.IconColor = Color.FromArgb(249, 115, 22);
            iconManageApplicationTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconManageApplicationTypes.IconSize = 53;
            iconManageApplicationTypes.Location = new Point(3, 3);
            iconManageApplicationTypes.Name = "iconManageApplicationTypes";
            iconManageApplicationTypes.Size = new Size(53, 63);
            iconManageApplicationTypes.SizeMode = PictureBoxSizeMode.Zoom;
            iconManageApplicationTypes.TabIndex = 0;
            iconManageApplicationTypes.TabStop = false;
            iconManageApplicationTypes.MouseEnter += panel_MouseEnter;
            iconManageApplicationTypes.MouseLeave += panel_MouseLeave;
            // 
            // pnlManageTestTypes
            // 
            pnlManageTestTypes.BackColor = Color.FromArgb(12, 22, 50);
            pnlManageTestTypes.Controls.Add(blManageTestTypes);
            pnlManageTestTypes.Controls.Add(iconManageTestTypes);
            pnlManageTestTypes.Cursor = Cursors.Hand;
            pnlManageTestTypes.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlManageTestTypes.Location = new Point(33, 473);
            pnlManageTestTypes.Name = "pnlManageTestTypes";
            pnlManageTestTypes.Size = new Size(302, 69);
            pnlManageTestTypes.TabIndex = 28;
            pnlManageTestTypes.Click += pnlManageTestTypes_Click;
            pnlManageTestTypes.MouseEnter += panel_MouseEnter;
            pnlManageTestTypes.MouseLeave += panel_MouseLeave;
            // 
            // blManageTestTypes
            // 
            blManageTestTypes.AutoSize = true;
            blManageTestTypes.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            blManageTestTypes.ForeColor = Color.White;
            blManageTestTypes.Location = new Point(62, 24);
            blManageTestTypes.Name = "blManageTestTypes";
            blManageTestTypes.Size = new Size(173, 21);
            blManageTestTypes.TabIndex = 5;
            blManageTestTypes.Text = "Manage Test Types";
            blManageTestTypes.Click += pnlManageTestTypes_Click;
            blManageTestTypes.MouseEnter += panel_MouseEnter;
            blManageTestTypes.MouseLeave += panel_MouseLeave;
            // 
            // iconManageTestTypes
            // 
            iconManageTestTypes.BackColor = Color.FromArgb(12, 22, 50);
            iconManageTestTypes.Enabled = false;
            iconManageTestTypes.ForeColor = Color.FromArgb(249, 115, 22);
            iconManageTestTypes.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconManageTestTypes.IconColor = Color.FromArgb(249, 115, 22);
            iconManageTestTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconManageTestTypes.IconSize = 53;
            iconManageTestTypes.Location = new Point(3, 3);
            iconManageTestTypes.Name = "iconManageTestTypes";
            iconManageTestTypes.Size = new Size(53, 63);
            iconManageTestTypes.SizeMode = PictureBoxSizeMode.Zoom;
            iconManageTestTypes.TabIndex = 0;
            iconManageTestTypes.TabStop = false;
            iconManageTestTypes.Click += pnlManageTestTypes_Click;
            iconManageTestTypes.MouseEnter += panel_MouseEnter;
            iconManageTestTypes.MouseLeave += panel_MouseLeave;
            // 
            // frmApplicationsMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(367, 560);
            Controls.Add(pnlManageTestTypes);
            Controls.Add(pnlManageApplicationTypes);
            Controls.Add(pnlDetainLicenses);
            Controls.Add(pnlManageApplications);
            Controls.Add(pnlDrivingLicenseServices);
            Controls.Add(lblApplications);
            Name = "frmApplicationsMainMenu";
            Text = "frmApplicationsMainMenu";
            Load += frmApplicationsMainMenu_Load;
            MouseEnter += panel_MouseEnter;
            MouseLeave += panel_MouseLeave;
            pnlDrivingLicenseServices.ResumeLayout(false);
            pnlDrivingLicenseServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconDrivingLicenseServices).EndInit();
            pnlManageApplications.ResumeLayout(false);
            pnlManageApplications.PerformLayout();
            cxmManageApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconManageApplications).EndInit();
            pnlDetainLicenses.ResumeLayout(false);
            pnlDetainLicenses.PerformLayout();
            cxmDetainLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconDetainLicenses).EndInit();
            pnlManageApplicationTypes.ResumeLayout(false);
            pnlManageApplicationTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconManageApplicationTypes).EndInit();
            pnlManageTestTypes.ResumeLayout(false);
            pnlManageTestTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconManageTestTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lblApplications;
        private Panel pnlDrivingLicenseServices;
        private Label lblDrivingLicenseServices;
        private FontAwesome.Sharp.IconPictureBox iconDrivingLicenseServices;
        private Panel pnlManageApplications;
        private Label lblManageApplications;
        private FontAwesome.Sharp.IconPictureBox iconManageApplications;
        private Panel pnlDetainLicenses;
        private Label lblDetainLicenses;
        private FontAwesome.Sharp.IconPictureBox iconDetainLicenses;
        private Panel pnlManageApplicationTypes;
        private Label lblManageApplicationTypes;
        private FontAwesome.Sharp.IconPictureBox iconManageApplicationTypes;
        private Panel pnlManageTestTypes;
        private Label blManageTestTypes;
        private FontAwesome.Sharp.IconPictureBox iconManageTestTypes;
        private ContextMenuStrip cxmDetainLicenses;
        private ToolStripMenuItem toolStripMenuItemManageDetainedLicenses;
        private ToolStripMenuItem toolStripMenuItemDetainLicense;
        private ToolStripMenuItem toolStripMenuItemLocalLicense;
        private ToolStripMenuItem toolStripMenuItemInternationalLicense;
        private ContextMenuStrip cxmManageApplications;
        private ToolStripMenuItem toolStripMenuItemReleaseDetainedLicense;
    }
}