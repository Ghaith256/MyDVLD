namespace DVLD_Presentation.International_Driving_License
{
    partial class frmManageInternationalDrivingLicenseApplications
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
            pnlTextBorder = new Panel();
            txtSearchInternationalDrivingLicenseApplication = new TextBox();
            cmbFilterBy = new ComboBox();
            lblFilterBy = new Label();
            btnAddInternationalDrivingLicenseApplication = new Button();
            dgvShowDriverInternationalLicensesHistory = new DataGridView();
            InternationalLicenseID = new DataGridViewTextBoxColumn();
            ApplicationIDInternatonal = new DataGridViewTextBoxColumn();
            LocalLicenseID = new DataGridViewTextBoxColumn();
            IssueDateInternational = new DataGridViewTextBoxColumn();
            ExpirationDateInternational = new DataGridViewTextBoxColumn();
            IsActiveInternational = new DataGridViewTextBoxColumn();
            cxmManageInternationalDrivingLicenseApplications = new ContextMenuStrip(components);
            ShowPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            ShowLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            ShowPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pnlTextBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowDriverInternationalLicensesHistory).BeginInit();
            cxmManageInternationalDrivingLicenseApplications.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchInternationalDrivingLicenseApplication);
            pnlTextBorder.Location = new Point(260, 23);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(200, 26);
            pnlTextBorder.TabIndex = 24;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchInternationalDrivingLicenseApplication
            // 
            txtSearchInternationalDrivingLicenseApplication.Location = new Point(3, 11);
            txtSearchInternationalDrivingLicenseApplication.Name = "txtSearchInternationalDrivingLicenseApplication";
            txtSearchInternationalDrivingLicenseApplication.Size = new Size(197, 23);
            txtSearchInternationalDrivingLicenseApplication.TabIndex = 0;
            txtSearchInternationalDrivingLicenseApplication.TextAlign = HorizontalAlignment.Center;
            txtSearchInternationalDrivingLicenseApplication.TextChanged += txtSearchInternationalDrivingLicenseApplication_TextChanged;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "L.D.L.AppID", "National No.", "Full Name", "Status" });
            cmbFilterBy.Location = new Point(106, 22);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(136, 26);
            cmbFilterBy.TabIndex = 23;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(22, 26);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(80, 20);
            lblFilterBy.TabIndex = 22;
            lblFilterBy.Text = "Filter By:";
            // 
            // btnAddInternationalDrivingLicenseApplication
            // 
            btnAddInternationalDrivingLicenseApplication.BackColor = Color.White;
            btnAddInternationalDrivingLicenseApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddInternationalDrivingLicenseApplication.ForeColor = Color.White;
            btnAddInternationalDrivingLicenseApplication.Location = new Point(495, 18);
            btnAddInternationalDrivingLicenseApplication.Name = "btnAddInternationalDrivingLicenseApplication";
            btnAddInternationalDrivingLicenseApplication.Size = new Size(126, 28);
            btnAddInternationalDrivingLicenseApplication.TabIndex = 25;
            btnAddInternationalDrivingLicenseApplication.Text = "Add";
            btnAddInternationalDrivingLicenseApplication.UseVisualStyleBackColor = false;
            btnAddInternationalDrivingLicenseApplication.Click += btnAddInternationalDrivingLicenseApplication_Click;
            // 
            // dgvShowDriverInternationalLicensesHistory
            // 
            dgvShowDriverInternationalLicensesHistory.AllowUserToAddRows = false;
            dgvShowDriverInternationalLicensesHistory.AllowUserToDeleteRows = false;
            dgvShowDriverInternationalLicensesHistory.BorderStyle = BorderStyle.None;
            dgvShowDriverInternationalLicensesHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowDriverInternationalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowDriverInternationalLicensesHistory.Columns.AddRange(new DataGridViewColumn[] { InternationalLicenseID, ApplicationIDInternatonal, LocalLicenseID, IssueDateInternational, ExpirationDateInternational, IsActiveInternational });
            dgvShowDriverInternationalLicensesHistory.EnableHeadersVisualStyles = false;
            dgvShowDriverInternationalLicensesHistory.Location = new Point(22, 65);
            dgvShowDriverInternationalLicensesHistory.Name = "dgvShowDriverInternationalLicensesHistory";
            dgvShowDriverInternationalLicensesHistory.ReadOnly = true;
            dgvShowDriverInternationalLicensesHistory.RowHeadersVisible = false;
            dgvShowDriverInternationalLicensesHistory.RowTemplate.ReadOnly = true;
            dgvShowDriverInternationalLicensesHistory.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowDriverInternationalLicensesHistory.ShowCellErrors = false;
            dgvShowDriverInternationalLicensesHistory.ShowCellToolTips = false;
            dgvShowDriverInternationalLicensesHistory.ShowEditingIcon = false;
            dgvShowDriverInternationalLicensesHistory.ShowRowErrors = false;
            dgvShowDriverInternationalLicensesHistory.Size = new Size(599, 426);
            dgvShowDriverInternationalLicensesHistory.TabIndex = 26;
            dgvShowDriverInternationalLicensesHistory.CellFormatting += dgvShowDriverInternationalLicensesHistory_CellFormatting;
            // 
            // InternationalLicenseID
            // 
            InternationalLicenseID.DataPropertyName = "InternationalLicenseID";
            InternationalLicenseID.HeaderText = "Int.License ID";
            InternationalLicenseID.Name = "InternationalLicenseID";
            InternationalLicenseID.ReadOnly = true;
            // 
            // ApplicationIDInternatonal
            // 
            ApplicationIDInternatonal.DataPropertyName = "ApplicationID";
            ApplicationIDInternatonal.HeaderText = "Application ID";
            ApplicationIDInternatonal.Name = "ApplicationIDInternatonal";
            ApplicationIDInternatonal.ReadOnly = true;
            // 
            // LocalLicenseID
            // 
            LocalLicenseID.DataPropertyName = "LocalLicenseID";
            LocalLicenseID.HeaderText = "L.License ID";
            LocalLicenseID.Name = "LocalLicenseID";
            LocalLicenseID.ReadOnly = true;
            // 
            // IssueDateInternational
            // 
            IssueDateInternational.DataPropertyName = "IssueDate";
            IssueDateInternational.HeaderText = "Issue Date";
            IssueDateInternational.Name = "IssueDateInternational";
            IssueDateInternational.ReadOnly = true;
            // 
            // ExpirationDateInternational
            // 
            ExpirationDateInternational.DataPropertyName = "ExpirationDate";
            ExpirationDateInternational.HeaderText = "Expiration Date";
            ExpirationDateInternational.Name = "ExpirationDateInternational";
            ExpirationDateInternational.ReadOnly = true;
            // 
            // IsActiveInternational
            // 
            IsActiveInternational.DataPropertyName = "IsActive";
            IsActiveInternational.HeaderText = "Is Active";
            IsActiveInternational.Name = "IsActiveInternational";
            IsActiveInternational.ReadOnly = true;
            // 
            // cxmManageInternationalDrivingLicenseApplications
            // 
            cxmManageInternationalDrivingLicenseApplications.Items.AddRange(new ToolStripItem[] { ShowPersonDetailsToolStripMenuItem, ShowLicenseDetailsToolStripMenuItem, ShowPersonLicenseHistoryToolStripMenuItem });
            cxmManageInternationalDrivingLicenseApplications.Name = "cxmManageInternationalDrivingLicenseApplications";
            cxmManageInternationalDrivingLicenseApplications.Size = new Size(226, 70);
            // 
            // ShowPersonDetailsToolStripMenuItem
            // 
            ShowPersonDetailsToolStripMenuItem.Name = "ShowPersonDetailsToolStripMenuItem";
            ShowPersonDetailsToolStripMenuItem.Size = new Size(225, 22);
            ShowPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            ShowPersonDetailsToolStripMenuItem.Click += ShowPersonDetailsToolStripMenuItem_Click;
            // 
            // ShowLicenseDetailsToolStripMenuItem
            // 
            ShowLicenseDetailsToolStripMenuItem.Name = "ShowLicenseDetailsToolStripMenuItem";
            ShowLicenseDetailsToolStripMenuItem.Size = new Size(225, 22);
            ShowLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            ShowLicenseDetailsToolStripMenuItem.Click += ShowLicenseDetailsToolStripMenuItem_Click;
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            ShowPersonLicenseHistoryToolStripMenuItem.Size = new Size(225, 22);
            ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            ShowPersonLicenseHistoryToolStripMenuItem.Click += ShowPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // frmManageInternationalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(639, 503);
            Controls.Add(dgvShowDriverInternationalLicensesHistory);
            Controls.Add(btnAddInternationalDrivingLicenseApplication);
            Controls.Add(pnlTextBorder);
            Controls.Add(cmbFilterBy);
            Controls.Add(lblFilterBy);
            Name = "frmManageInternationalDrivingLicenseApplications";
            Text = "frmManageInternationalDrivingLicenseApplications";
            Load += frmManageInternationalDrivingLicenseApplications_Load;
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowDriverInternationalLicensesHistory).EndInit();
            cxmManageInternationalDrivingLicenseApplications.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTextBorder;
        private TextBox txtSearchInternationalDrivingLicenseApplication;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private Button btnAddInternationalDrivingLicenseApplication;
        private DataGridView dgvShowDriverInternationalLicensesHistory;
        private DataGridViewTextBoxColumn InternationalLicenseID;
        private DataGridViewTextBoxColumn ApplicationIDInternatonal;
        private DataGridViewTextBoxColumn LocalLicenseID;
        private DataGridViewTextBoxColumn IssueDateInternational;
        private DataGridViewTextBoxColumn ExpirationDateInternational;
        private DataGridViewTextBoxColumn IsActiveInternational;
        private ContextMenuStrip cxmManageInternationalDrivingLicenseApplications;
        private ToolStripMenuItem ShowPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem ShowLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
    }
}