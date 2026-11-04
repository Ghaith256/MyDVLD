namespace DVLD_Presentation.Tests
{
    partial class frmTestAppointments
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
            lblTitleTestAppointments = new Sunny.UI.UILabel();
            ucLocalDrivingLicenseApplicationInfo = new DVLD_Presentation.User_Controls.ucLocalDrivingLicenseApplicationInfo();
            ucApplicationBasicInfo = new DVLD_Presentation.User_Controls.ucApplicationBasicInfo();
            btnAdd = new Button();
            dgvShowLocalDrivingLicenseApplications = new DataGridView();
            AppointmentID = new DataGridViewTextBoxColumn();
            AppointmentDate = new DataGridViewTextBoxColumn();
            PaidFees = new DataGridViewTextBoxColumn();
            IsLocked = new DataGridViewCheckBoxColumn();
            cxmManageTests = new ContextMenuStrip(components);
            itemEdit = new ToolStripMenuItem();
            itemTakeTest = new ToolStripMenuItem();
            lblRecord = new Sunny.UI.UILabel();
            lblAnswerRecord = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowLocalDrivingLicenseApplications).BeginInit();
            cxmManageTests.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleTestAppointments
            // 
            lblTitleTestAppointments.BackColor = Color.FromArgb(47, 59, 73);
            lblTitleTestAppointments.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleTestAppointments.ForeColor = Color.White;
            lblTitleTestAppointments.Location = new Point(0, -1);
            lblTitleTestAppointments.Name = "lblTitleTestAppointments";
            lblTitleTestAppointments.Size = new Size(291, 31);
            lblTitleTestAppointments.TabIndex = 23;
            lblTitleTestAppointments.Text = "Vision Test Appointments";
            // 
            // ucLocalDrivingLicenseApplicationInfo
            // 
            ucLocalDrivingLicenseApplicationInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucLocalDrivingLicenseApplicationInfo.EnableShowLicense = true;
            ucLocalDrivingLicenseApplicationInfo.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucLocalDrivingLicenseApplicationInfo.Location = new Point(12, 38);
            ucLocalDrivingLicenseApplicationInfo.Name = "ucLocalDrivingLicenseApplicationInfo";
            ucLocalDrivingLicenseApplicationInfo.Size = new Size(534, 159);
            ucLocalDrivingLicenseApplicationInfo.TabIndex = 24;
            // 
            // ucApplicationBasicInfo
            // 
            ucApplicationBasicInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucApplicationBasicInfo.Location = new Point(12, 203);
            ucApplicationBasicInfo.Name = "ucApplicationBasicInfo";
            ucApplicationBasicInfo.Size = new Size(534, 348);
            ucApplicationBasicInfo.TabIndex = 25;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(249, 115, 22);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(428, 557);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 30);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvShowLocalDrivingLicenseApplications
            // 
            dgvShowLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvShowLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvShowLocalDrivingLicenseApplications.BorderStyle = BorderStyle.None;
            dgvShowLocalDrivingLicenseApplications.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowLocalDrivingLicenseApplications.Columns.AddRange(new DataGridViewColumn[] { AppointmentID, AppointmentDate, PaidFees, IsLocked });
            dgvShowLocalDrivingLicenseApplications.ContextMenuStrip = cxmManageTests;
            dgvShowLocalDrivingLicenseApplications.EnableHeadersVisualStyles = false;
            dgvShowLocalDrivingLicenseApplications.Location = new Point(32, 609);
            dgvShowLocalDrivingLicenseApplications.Name = "dgvShowLocalDrivingLicenseApplications";
            dgvShowLocalDrivingLicenseApplications.ReadOnly = true;
            dgvShowLocalDrivingLicenseApplications.RowHeadersVisible = false;
            dgvShowLocalDrivingLicenseApplications.RowTemplate.ReadOnly = true;
            dgvShowLocalDrivingLicenseApplications.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowLocalDrivingLicenseApplications.ShowCellErrors = false;
            dgvShowLocalDrivingLicenseApplications.ShowCellToolTips = false;
            dgvShowLocalDrivingLicenseApplications.ShowEditingIcon = false;
            dgvShowLocalDrivingLicenseApplications.ShowRowErrors = false;
            dgvShowLocalDrivingLicenseApplications.Size = new Size(500, 119);
            dgvShowLocalDrivingLicenseApplications.TabIndex = 27;
            // 
            // AppointmentID
            // 
            AppointmentID.DataPropertyName = "TestAppointmentID";
            AppointmentID.HeaderText = "Appointment ID";
            AppointmentID.Name = "AppointmentID";
            AppointmentID.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            AppointmentDate.DataPropertyName = "AppointmentDate";
            AppointmentDate.HeaderText = "Appointment Date";
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.ReadOnly = true;
            // 
            // PaidFees
            // 
            PaidFees.DataPropertyName = "PaidFees";
            PaidFees.HeaderText = "Paid Fees";
            PaidFees.Name = "PaidFees";
            PaidFees.ReadOnly = true;
            // 
            // IsLocked
            // 
            IsLocked.DataPropertyName = "IsLocked";
            IsLocked.HeaderText = "Is Locked";
            IsLocked.Name = "IsLocked";
            IsLocked.ReadOnly = true;
            // 
            // cxmManageTests
            // 
            cxmManageTests.Items.AddRange(new ToolStripItem[] { itemEdit, itemTakeTest });
            cxmManageTests.Name = "cxmManageTests";
            cxmManageTests.Size = new Size(118, 48);
            // 
            // itemEdit
            // 
            itemEdit.Name = "itemEdit";
            itemEdit.Size = new Size(117, 22);
            itemEdit.Text = "Edit";
            itemEdit.Click += itemEdit_Click;
            // 
            // itemTakeTest
            // 
            itemTakeTest.Name = "itemTakeTest";
            itemTakeTest.Size = new Size(117, 22);
            itemTakeTest.Text = "TakeTest";
            itemTakeTest.Click += itemTakeTest_Click;
            // 
            // lblRecord
            // 
            lblRecord.BackColor = Color.FromArgb(47, 59, 73);
            lblRecord.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecord.ForeColor = Color.White;
            lblRecord.Location = new Point(32, 575);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(75, 23);
            lblRecord.TabIndex = 28;
            lblRecord.Text = "Records:";
            // 
            // lblAnswerRecord
            // 
            lblAnswerRecord.AutoSize = true;
            lblAnswerRecord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswerRecord.ForeColor = Color.White;
            lblAnswerRecord.Location = new Point(113, 575);
            lblAnswerRecord.Name = "lblAnswerRecord";
            lblAnswerRecord.Size = new Size(19, 20);
            lblAnswerRecord.TabIndex = 29;
            lblAnswerRecord.Text = "?";
            // 
            // frmTestAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(560, 735);
            Controls.Add(lblAnswerRecord);
            Controls.Add(lblRecord);
            Controls.Add(dgvShowLocalDrivingLicenseApplications);
            Controls.Add(btnAdd);
            Controls.Add(ucApplicationBasicInfo);
            Controls.Add(ucLocalDrivingLicenseApplicationInfo);
            Controls.Add(lblTitleTestAppointments);
            Name = "frmTestAppointments";
            Text = "frmVisionTestAppointments";
            Load += frmTestAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowLocalDrivingLicenseApplications).EndInit();
            cxmManageTests.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UILabel lblTitleTestAppointments;
        private User_Controls.ucLocalDrivingLicenseApplicationInfo ucLocalDrivingLicenseApplicationInfo;
        private User_Controls.ucApplicationBasicInfo ucApplicationBasicInfo;
        private Button btnAdd;
        private DataGridView dgvShowLocalDrivingLicenseApplications;
        private Sunny.UI.UILabel lblRecord;
        private Label lblAnswerRecord;
        private ContextMenuStrip cxmManageTests;
        private ToolStripMenuItem itemEdit;
        private ToolStripMenuItem itemTakeTest;
        private DataGridViewTextBoxColumn AppointmentID;
        private DataGridViewTextBoxColumn AppointmentDate;
        private DataGridViewTextBoxColumn PaidFees;
        private DataGridViewCheckBoxColumn IsLocked;
    }
}