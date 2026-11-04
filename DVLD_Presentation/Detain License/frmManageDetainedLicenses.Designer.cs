namespace DVLD_Presentation.Detain_License
{
    partial class frmManageDetainedLicenses
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
            dgvShowDetainedLicenses = new DataGridView();
            DetainID = new DataGridViewTextBoxColumn();
            LicenseID = new DataGridViewTextBoxColumn();
            DetainDate = new DataGridViewTextBoxColumn();
            IsReleased = new DataGridViewTextBoxColumn();
            FineFees = new DataGridViewTextBoxColumn();
            ReleaseDate = new DataGridViewTextBoxColumn();
            NationalNo = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            ReleaseApplicationID = new DataGridViewTextBoxColumn();
            cxmManageDetainedLicenses = new ContextMenuStrip(components);
            toolStripMenuItemShowPersonDetails = new ToolStripMenuItem();
            toolStripMenuItemShowLicenseDetails = new ToolStripMenuItem();
            toolStripMenuItemShowPersonLicenseHistory = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            toolStripMenuItemReleaseDetainedLicense = new ToolStripMenuItem();
            btnRelease = new Button();
            btnDetain = new Button();
            cmbFilterBy = new ComboBox();
            lblFilterBy = new Label();
            pnlTextBorder = new Panel();
            txtSearchLicense = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvShowDetainedLicenses).BeginInit();
            cxmManageDetainedLicenses.SuspendLayout();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // dgvShowDetainedLicenses
            // 
            dgvShowDetainedLicenses.AllowUserToAddRows = false;
            dgvShowDetainedLicenses.AllowUserToDeleteRows = false;
            dgvShowDetainedLicenses.BorderStyle = BorderStyle.None;
            dgvShowDetainedLicenses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowDetainedLicenses.Columns.AddRange(new DataGridViewColumn[] { DetainID, LicenseID, DetainDate, IsReleased, FineFees, ReleaseDate, NationalNo, FullName, ReleaseApplicationID });
            dgvShowDetainedLicenses.ContextMenuStrip = cxmManageDetainedLicenses;
            dgvShowDetainedLicenses.EnableHeadersVisualStyles = false;
            dgvShowDetainedLicenses.Location = new Point(12, 67);
            dgvShowDetainedLicenses.Name = "dgvShowDetainedLicenses";
            dgvShowDetainedLicenses.ReadOnly = true;
            dgvShowDetainedLicenses.RowHeadersVisible = false;
            dgvShowDetainedLicenses.RowTemplate.ReadOnly = true;
            dgvShowDetainedLicenses.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowDetainedLicenses.ShowCellErrors = false;
            dgvShowDetainedLicenses.ShowCellToolTips = false;
            dgvShowDetainedLicenses.ShowEditingIcon = false;
            dgvShowDetainedLicenses.ShowRowErrors = false;
            dgvShowDetainedLicenses.Size = new Size(1023, 426);
            dgvShowDetainedLicenses.TabIndex = 21;
            dgvShowDetainedLicenses.CellFormatting += dgvShowDetainedLicenses_CellFormatting;
            // 
            // DetainID
            // 
            DetainID.DataPropertyName = "DetainID";
            DetainID.HeaderText = "Detain ID";
            DetainID.Name = "DetainID";
            DetainID.ReadOnly = true;
            // 
            // LicenseID
            // 
            LicenseID.DataPropertyName = "LicenseID";
            LicenseID.HeaderText = "License ID";
            LicenseID.Name = "LicenseID";
            LicenseID.ReadOnly = true;
            // 
            // DetainDate
            // 
            DetainDate.DataPropertyName = "DetainDate";
            DetainDate.HeaderText = "Detain Date";
            DetainDate.Name = "DetainDate";
            DetainDate.ReadOnly = true;
            // 
            // IsReleased
            // 
            IsReleased.DataPropertyName = "IsReleased";
            IsReleased.HeaderText = "Is Released";
            IsReleased.Name = "IsReleased";
            IsReleased.ReadOnly = true;
            // 
            // FineFees
            // 
            FineFees.DataPropertyName = "FineFees";
            FineFees.HeaderText = "Fine Fees";
            FineFees.Name = "FineFees";
            FineFees.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            ReleaseDate.DataPropertyName = "ReleaseDate";
            ReleaseDate.HeaderText = "Release Date";
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.ReadOnly = true;
            // 
            // NationalNo
            // 
            NationalNo.DataPropertyName = "NationalNo";
            NationalNo.HeaderText = "National No.";
            NationalNo.Name = "NationalNo";
            NationalNo.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // ReleaseApplicationID
            // 
            ReleaseApplicationID.DataPropertyName = "ReleaseApplicationID";
            ReleaseApplicationID.HeaderText = "Release Application ID";
            ReleaseApplicationID.Name = "ReleaseApplicationID";
            ReleaseApplicationID.ReadOnly = true;
            // 
            // cxmManageDetainedLicenses
            // 
            cxmManageDetainedLicenses.Items.AddRange(new ToolStripItem[] { toolStripMenuItemShowPersonDetails, toolStripMenuItemShowLicenseDetails, toolStripMenuItemShowPersonLicenseHistory, toolStripSeparator, toolStripMenuItemReleaseDetainedLicense });
            cxmManageDetainedLicenses.Name = "cxmManageDetainedLicenses";
            cxmManageDetainedLicenses.Size = new Size(226, 120);
            cxmManageDetainedLicenses.Opening += cxmManageDetainedLicenses_Opening;
            // 
            // toolStripMenuItemShowPersonDetails
            // 
            toolStripMenuItemShowPersonDetails.Name = "toolStripMenuItemShowPersonDetails";
            toolStripMenuItemShowPersonDetails.Size = new Size(225, 22);
            toolStripMenuItemShowPersonDetails.Text = "Show Person Details";
            toolStripMenuItemShowPersonDetails.Click += toolStripMenuItemShowPersonDetails_Click;
            // 
            // toolStripMenuItemShowLicenseDetails
            // 
            toolStripMenuItemShowLicenseDetails.Name = "toolStripMenuItemShowLicenseDetails";
            toolStripMenuItemShowLicenseDetails.Size = new Size(225, 22);
            toolStripMenuItemShowLicenseDetails.Text = "Show License Details";
            toolStripMenuItemShowLicenseDetails.Click += toolStripMenuItemShowLicenseDetails_Click;
            // 
            // toolStripMenuItemShowPersonLicenseHistory
            // 
            toolStripMenuItemShowPersonLicenseHistory.Name = "toolStripMenuItemShowPersonLicenseHistory";
            toolStripMenuItemShowPersonLicenseHistory.Size = new Size(225, 22);
            toolStripMenuItemShowPersonLicenseHistory.Text = "Show Person License History";
            toolStripMenuItemShowPersonLicenseHistory.Click += toolStripMenuItemShowPersonLicenseHistory_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(222, 6);
            // 
            // toolStripMenuItemReleaseDetainedLicense
            // 
            toolStripMenuItemReleaseDetainedLicense.Name = "toolStripMenuItemReleaseDetainedLicense";
            toolStripMenuItemReleaseDetainedLicense.Size = new Size(225, 22);
            toolStripMenuItemReleaseDetainedLicense.Text = "Release Detained License";
            toolStripMenuItemReleaseDetainedLicense.Click += toolStripMenuItemReleaseDetainedLicense_Click;
            // 
            // btnRelease
            // 
            btnRelease.BackColor = Color.FromArgb(249, 115, 22);
            btnRelease.FlatAppearance.BorderSize = 0;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.ForeColor = Color.White;
            btnRelease.Location = new Point(913, 12);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(122, 47);
            btnRelease.TabIndex = 47;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = false;
            btnRelease.Click += btnRelease_Click;
            // 
            // btnDetain
            // 
            btnDetain.BackColor = Color.FromArgb(249, 115, 22);
            btnDetain.FlatAppearance.BorderSize = 0;
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.ForeColor = Color.White;
            btnDetain.Location = new Point(761, 12);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(122, 47);
            btnDetain.TabIndex = 48;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = false;
            btnDetain.Click += btnDetain_Click;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National No", "Full Name", "Release Application ID" });
            cmbFilterBy.Location = new Point(104, 23);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(136, 26);
            cmbFilterBy.TabIndex = 50;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(20, 27);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(80, 20);
            lblFilterBy.TabIndex = 49;
            lblFilterBy.Text = "Filter By:";
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchLicense);
            pnlTextBorder.Location = new Point(288, 17);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(286, 32);
            pnlTextBorder.TabIndex = 51;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchLicense
            // 
            txtSearchLicense.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchLicense.BorderStyle = BorderStyle.None;
            txtSearchLicense.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchLicense.ForeColor = Color.White;
            txtSearchLicense.Location = new Point(0, 5);
            txtSearchLicense.Multiline = true;
            txtSearchLicense.Name = "txtSearchLicense";
            txtSearchLicense.Size = new Size(283, 24);
            txtSearchLicense.TabIndex = 3;
            txtSearchLicense.TextChanged += txtSearchLicense_TextChanged;
            // 
            // frmManageDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(1047, 505);
            Controls.Add(pnlTextBorder);
            Controls.Add(cmbFilterBy);
            Controls.Add(lblFilterBy);
            Controls.Add(btnDetain);
            Controls.Add(btnRelease);
            Controls.Add(dgvShowDetainedLicenses);
            Name = "frmManageDetainedLicenses";
            Text = "frmManageDetainedLicenses";
            Load += frmManageDetainedLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowDetainedLicenses).EndInit();
            cxmManageDetainedLicenses.ResumeLayout(false);
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowDetainedLicenses;
        private Button btnRelease;
        private Button btnDetain;
        private DataGridViewTextBoxColumn DetainID;
        private DataGridViewTextBoxColumn LicenseID;
        private DataGridViewTextBoxColumn DetainDate;
        private DataGridViewTextBoxColumn IsReleased;
        private DataGridViewTextBoxColumn FineFees;
        private DataGridViewTextBoxColumn ReleaseDate;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ReleaseApplicationID;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private Panel pnlTextBorder;
        private TextBox txtSearchLicense;
        private ContextMenuStrip cxmManageDetainedLicenses;
        private ToolStripMenuItem toolStripMenuItemShowPersonDetails;
        private ToolStripMenuItem toolStripMenuItemShowLicenseDetails;
        private ToolStripMenuItem toolStripMenuItemShowPersonLicenseHistory;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem toolStripMenuItemReleaseDetainedLicense;
    }
}