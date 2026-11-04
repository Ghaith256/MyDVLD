namespace DVLD_Presentation.Local_Driving_License_Applications
{
    partial class frmManageLocalDrivingLicenseApplications
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
            dgvShowLocalDrivingLicenseApplications = new DataGridView();
            ApplicantPersonID = new DataGridViewTextBoxColumn();
            LocalDrivingLicenseApplicationID = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            NationalNo = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            ApplicationDate = new DataGridViewTextBoxColumn();
            PassedTests = new DataGridViewTextBoxColumn();
            ApplicationStatus = new DataGridViewTextBoxColumn();
            cxmManageLocalDrivingLicenseApplications = new ContextMenuStrip(components);
            ShowApplicationInfoToolStripMenuItem = new ToolStripMenuItem();
            SeparatorOne = new ToolStripSeparator();
            EditApplicationToolStripMenuItem = new ToolStripMenuItem();
            DeleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            CancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            SeperatorTwo = new ToolStripSeparator();
            ScheduleTestsToolStripMenuItem = new ToolStripMenuItem();
            SeperatorThree = new ToolStripSeparator();
            IssueDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            SeperatorFour = new ToolStripSeparator();
            ShowLicenseToolStripMenuItem = new ToolStripMenuItem();
            SeperatorFive = new ToolStripSeparator();
            ShowPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            cmbFilterBy = new ComboBox();
            lblFilterBy = new Label();
            pnlTextBorder = new Panel();
            txtSearchLocalDrivingLicenseApplication = new TextBox();
            btnAddLocalDrivingLicenseApplication = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowLocalDrivingLicenseApplications).BeginInit();
            cxmManageLocalDrivingLicenseApplications.SuspendLayout();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // dgvShowLocalDrivingLicenseApplications
            // 
            dgvShowLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvShowLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvShowLocalDrivingLicenseApplications.BorderStyle = BorderStyle.None;
            dgvShowLocalDrivingLicenseApplications.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowLocalDrivingLicenseApplications.Columns.AddRange(new DataGridViewColumn[] { ApplicantPersonID, LocalDrivingLicenseApplicationID, ClassName, NationalNo, FullName, ApplicationDate, PassedTests, ApplicationStatus });
            dgvShowLocalDrivingLicenseApplications.ContextMenuStrip = cxmManageLocalDrivingLicenseApplications;
            dgvShowLocalDrivingLicenseApplications.EnableHeadersVisualStyles = false;
            dgvShowLocalDrivingLicenseApplications.Location = new Point(5, 65);
            dgvShowLocalDrivingLicenseApplications.Name = "dgvShowLocalDrivingLicenseApplications";
            dgvShowLocalDrivingLicenseApplications.ReadOnly = true;
            dgvShowLocalDrivingLicenseApplications.RowHeadersVisible = false;
            dgvShowLocalDrivingLicenseApplications.RowTemplate.ReadOnly = true;
            dgvShowLocalDrivingLicenseApplications.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowLocalDrivingLicenseApplications.ShowCellErrors = false;
            dgvShowLocalDrivingLicenseApplications.ShowCellToolTips = false;
            dgvShowLocalDrivingLicenseApplications.ShowEditingIcon = false;
            dgvShowLocalDrivingLicenseApplications.ShowRowErrors = false;
            dgvShowLocalDrivingLicenseApplications.Size = new Size(802, 426);
            dgvShowLocalDrivingLicenseApplications.TabIndex = 17;
            dgvShowLocalDrivingLicenseApplications.CellFormatting += dgvShowLocalDrivingLicenseApplications_CellFormatting;
            // 
            // ApplicantPersonID
            // 
            ApplicantPersonID.DataPropertyName = "ApplicantPersonID";
            ApplicantPersonID.HeaderText = "ApplicantPersonID";
            ApplicantPersonID.Name = "ApplicantPersonID";
            ApplicantPersonID.ReadOnly = true;
            // 
            // LocalDrivingLicenseApplicationID
            // 
            LocalDrivingLicenseApplicationID.DataPropertyName = "LocalDrivingLicenseApplicationID";
            LocalDrivingLicenseApplicationID.HeaderText = "L.D.L.AppID";
            LocalDrivingLicenseApplicationID.Name = "LocalDrivingLicenseApplicationID";
            LocalDrivingLicenseApplicationID.ReadOnly = true;
            // 
            // ClassName
            // 
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "Driver Class";
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
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
            // ApplicationDate
            // 
            ApplicationDate.DataPropertyName = "ApplicationDate";
            ApplicationDate.HeaderText = "Application Date";
            ApplicationDate.Name = "ApplicationDate";
            ApplicationDate.ReadOnly = true;
            // 
            // PassedTests
            // 
            PassedTests.DataPropertyName = "PassedTests";
            PassedTests.HeaderText = "Passed Tests";
            PassedTests.Name = "PassedTests";
            PassedTests.ReadOnly = true;
            // 
            // ApplicationStatus
            // 
            ApplicationStatus.DataPropertyName = "ApplicationStatus";
            ApplicationStatus.HeaderText = "Application Status";
            ApplicationStatus.Name = "ApplicationStatus";
            ApplicationStatus.ReadOnly = true;
            // 
            // cxmManageLocalDrivingLicenseApplications
            // 
            cxmManageLocalDrivingLicenseApplications.Items.AddRange(new ToolStripItem[] { ShowApplicationInfoToolStripMenuItem, SeparatorOne, EditApplicationToolStripMenuItem, DeleteApplicationToolStripMenuItem, CancelApplicationToolStripMenuItem, SeperatorTwo, ScheduleTestsToolStripMenuItem, SeperatorThree, IssueDrivingLicenseToolStripMenuItem, SeperatorFour, ShowLicenseToolStripMenuItem, SeperatorFive, ShowPersonLicenseHistoryToolStripMenuItem });
            cxmManageLocalDrivingLicenseApplications.Name = "cxmManageLocalDrivingLicenseApplications";
            cxmManageLocalDrivingLicenseApplications.Size = new Size(246, 210);
            cxmManageLocalDrivingLicenseApplications.Opening += cxmManageLocalDrivingLicenseApplications_Opening;
            // 
            // ShowApplicationInfoToolStripMenuItem
            // 
            ShowApplicationInfoToolStripMenuItem.Name = "ShowApplicationInfoToolStripMenuItem";
            ShowApplicationInfoToolStripMenuItem.Size = new Size(245, 22);
            ShowApplicationInfoToolStripMenuItem.Text = "Show Application Info";
            ShowApplicationInfoToolStripMenuItem.Click += ShowApplicationInfoToolStripMenuItem_Click;
            // 
            // SeparatorOne
            // 
            SeparatorOne.Name = "SeparatorOne";
            SeparatorOne.Size = new Size(242, 6);
            // 
            // EditApplicationToolStripMenuItem
            // 
            EditApplicationToolStripMenuItem.Name = "EditApplicationToolStripMenuItem";
            EditApplicationToolStripMenuItem.Size = new Size(245, 22);
            EditApplicationToolStripMenuItem.Text = "Edit Application Info";
            EditApplicationToolStripMenuItem.Click += EditApplicationToolStripMenuItem_Click;
            // 
            // DeleteApplicationToolStripMenuItem
            // 
            DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            DeleteApplicationToolStripMenuItem.Size = new Size(245, 22);
            DeleteApplicationToolStripMenuItem.Text = "Delete Application";
            DeleteApplicationToolStripMenuItem.Click += DeleteApplicationToolStripMenuItem_Click;
            // 
            // CancelApplicationToolStripMenuItem
            // 
            CancelApplicationToolStripMenuItem.Name = "CancelApplicationToolStripMenuItem";
            CancelApplicationToolStripMenuItem.Size = new Size(245, 22);
            CancelApplicationToolStripMenuItem.Text = "Cancel Application";
            CancelApplicationToolStripMenuItem.Click += CancelApplicationToolStripMenuItem_Click;
            // 
            // SeperatorTwo
            // 
            SeperatorTwo.Name = "SeperatorTwo";
            SeperatorTwo.Size = new Size(242, 6);
            // 
            // ScheduleTestsToolStripMenuItem
            // 
            ScheduleTestsToolStripMenuItem.Name = "ScheduleTestsToolStripMenuItem";
            ScheduleTestsToolStripMenuItem.Size = new Size(245, 22);
            ScheduleTestsToolStripMenuItem.Text = "ScheduleTest";
            // 
            // SeperatorThree
            // 
            SeperatorThree.Name = "SeperatorThree";
            SeperatorThree.Size = new Size(242, 6);
            // 
            // IssueDrivingLicenseToolStripMenuItem
            // 
            IssueDrivingLicenseToolStripMenuItem.Name = "IssueDrivingLicenseToolStripMenuItem";
            IssueDrivingLicenseToolStripMenuItem.Size = new Size(245, 22);
            IssueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            IssueDrivingLicenseToolStripMenuItem.Click += IssueDrivingLicenseToolStripMenuItem_Click;
            // 
            // SeperatorFour
            // 
            SeperatorFour.Name = "SeperatorFour";
            SeperatorFour.Size = new Size(242, 6);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            ShowLicenseToolStripMenuItem.Size = new Size(245, 22);
            ShowLicenseToolStripMenuItem.Text = "Show License";
            ShowLicenseToolStripMenuItem.Click += ShowLicenseToolStripMenuItem_Click;
            // 
            // SeperatorFive
            // 
            SeperatorFive.Name = "SeperatorFive";
            SeperatorFive.Size = new Size(242, 6);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            ShowPersonLicenseHistoryToolStripMenuItem.Size = new Size(245, 22);
            ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            ShowPersonLicenseHistoryToolStripMenuItem.Click += ShowPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "L.D.L.AppID", "National No.", "Full Name", "Status" });
            cmbFilterBy.Location = new Point(97, 12);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(136, 26);
            cmbFilterBy.TabIndex = 19;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(13, 16);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(80, 20);
            lblFilterBy.TabIndex = 18;
            lblFilterBy.Text = "Filter By:";
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchLocalDrivingLicenseApplication);
            pnlTextBorder.Location = new Point(251, 13);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(280, 26);
            pnlTextBorder.TabIndex = 21;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchLocalDrivingLicenseApplication
            // 
            txtSearchLocalDrivingLicenseApplication.Location = new Point(3, 11);
            txtSearchLocalDrivingLicenseApplication.Name = "txtSearchLocalDrivingLicenseApplication";
            txtSearchLocalDrivingLicenseApplication.Size = new Size(276, 22);
            txtSearchLocalDrivingLicenseApplication.TabIndex = 0;
            txtSearchLocalDrivingLicenseApplication.TextAlign = HorizontalAlignment.Center;
            txtSearchLocalDrivingLicenseApplication.TextChanged += txtSearchLocalDrivingLicenseApplication_TextChanged;
            // 
            // btnAddLocalDrivingLicenseApplication
            // 
            btnAddLocalDrivingLicenseApplication.BackColor = Color.White;
            btnAddLocalDrivingLicenseApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLocalDrivingLicenseApplication.ForeColor = Color.White;
            btnAddLocalDrivingLicenseApplication.Location = new Point(671, 12);
            btnAddLocalDrivingLicenseApplication.Name = "btnAddLocalDrivingLicenseApplication";
            btnAddLocalDrivingLicenseApplication.Size = new Size(126, 28);
            btnAddLocalDrivingLicenseApplication.TabIndex = 20;
            btnAddLocalDrivingLicenseApplication.Text = "Add";
            btnAddLocalDrivingLicenseApplication.UseVisualStyleBackColor = false;
            btnAddLocalDrivingLicenseApplication.Click += btnAddLocalDrivingLicenseApplication_Click;
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(819, 503);
            Controls.Add(pnlTextBorder);
            Controls.Add(btnAddLocalDrivingLicenseApplication);
            Controls.Add(cmbFilterBy);
            Controls.Add(lblFilterBy);
            Controls.Add(dgvShowLocalDrivingLicenseApplications);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmManageLocalDrivingLicenseApplications";
            Text = "frmManageLocalDrivingLicenseApplications";
            Load += frmManageLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowLocalDrivingLicenseApplications).EndInit();
            cxmManageLocalDrivingLicenseApplications.ResumeLayout(false);
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowLocalDrivingLicenseApplications;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private Panel pnlTextBorder;
        private TextBox txtSearchLocalDrivingLicenseApplication;
        private Button btnAddLocalDrivingLicenseApplication;
        private DataGridViewTextBoxColumn ApplicantPersonID;
        private DataGridViewTextBoxColumn LocalDrivingLicenseApplicationID;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ApplicationDate;
        private DataGridViewTextBoxColumn PassedTests;
        private DataGridViewTextBoxColumn ApplicationStatus;
        private ContextMenuStrip cxmManageLocalDrivingLicenseApplications;
        private ToolStripMenuItem ShowApplicationInfoToolStripMenuItem;
        private ToolStripSeparator SeparatorOne;
        private ToolStripMenuItem EditApplicationToolStripMenuItem;
        private ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private ToolStripMenuItem CancelApplicationToolStripMenuItem;
        private ToolStripSeparator SeperatorTwo;
        private ToolStripMenuItem ScheduleTestsToolStripMenuItem;
        private ToolStripSeparator SeperatorThree;
        private ToolStripMenuItem IssueDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator SeperatorFour;
        private ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private ToolStripSeparator SeperatorFive;
        private ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
    }
}