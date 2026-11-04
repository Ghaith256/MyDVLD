namespace DVLD_Presentation.User_Controls
{
    partial class ucShowDriverLicensesHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvShowDriverLocalLicensesHistory = new DataGridView();
            LicenseID = new DataGridViewTextBoxColumn();
            ApplicationID = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            IssueDate = new DataGridViewTextBoxColumn();
            ExpirationDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            tabLocalLicense = new TabControl();
            tabPageLocalLicense = new TabPage();
            tabPageInternationalLicense = new TabPage();
            dgvShowDriverInternationalLicensesHistory = new DataGridView();
            InternationalLicenseID = new DataGridViewTextBoxColumn();
            ApplicationIDInternatonal = new DataGridViewTextBoxColumn();
            LocalLicenseID = new DataGridViewTextBoxColumn();
            IssueDateInternational = new DataGridViewTextBoxColumn();
            ExpirationDateInternational = new DataGridViewTextBoxColumn();
            IsActiveInternational = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvShowDriverLocalLicensesHistory).BeginInit();
            tabLocalLicense.SuspendLayout();
            tabPageLocalLicense.SuspendLayout();
            tabPageInternationalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowDriverInternationalLicensesHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvShowDriverLocalLicensesHistory
            // 
            dgvShowDriverLocalLicensesHistory.AllowUserToAddRows = false;
            dgvShowDriverLocalLicensesHistory.AllowUserToDeleteRows = false;
            dgvShowDriverLocalLicensesHistory.BorderStyle = BorderStyle.None;
            dgvShowDriverLocalLicensesHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowDriverLocalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowDriverLocalLicensesHistory.Columns.AddRange(new DataGridViewColumn[] { LicenseID, ApplicationID, ClassName, IssueDate, ExpirationDate, IsActive });
            dgvShowDriverLocalLicensesHistory.EnableHeadersVisualStyles = false;
            dgvShowDriverLocalLicensesHistory.Location = new Point(6, 9);
            dgvShowDriverLocalLicensesHistory.Name = "dgvShowDriverLocalLicensesHistory";
            dgvShowDriverLocalLicensesHistory.ReadOnly = true;
            dgvShowDriverLocalLicensesHistory.RowHeadersVisible = false;
            dgvShowDriverLocalLicensesHistory.RowTemplate.ReadOnly = true;
            dgvShowDriverLocalLicensesHistory.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowDriverLocalLicensesHistory.ShowCellErrors = false;
            dgvShowDriverLocalLicensesHistory.ShowCellToolTips = false;
            dgvShowDriverLocalLicensesHistory.ShowEditingIcon = false;
            dgvShowDriverLocalLicensesHistory.ShowRowErrors = false;
            dgvShowDriverLocalLicensesHistory.Size = new Size(599, 426);
            dgvShowDriverLocalLicensesHistory.TabIndex = 21;
            // 
            // LicenseID
            // 
            LicenseID.DataPropertyName = "LicenseID";
            LicenseID.HeaderText = "License ID";
            LicenseID.Name = "LicenseID";
            LicenseID.ReadOnly = true;
            // 
            // ApplicationID
            // 
            ApplicationID.DataPropertyName = "ApplicationID";
            ApplicationID.HeaderText = "Application ID";
            ApplicationID.Name = "ApplicationID";
            ApplicationID.ReadOnly = true;
            // 
            // ClassName
            // 
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "Class Name";
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            // 
            // IssueDate
            // 
            IssueDate.DataPropertyName = "IssueDate";
            IssueDate.HeaderText = "Issue Date";
            IssueDate.Name = "IssueDate";
            IssueDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            ExpirationDate.DataPropertyName = "ExpirationDate";
            ExpirationDate.HeaderText = "Expiration Date";
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "Is Active";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            // 
            // tabLocalLicense
            // 
            tabLocalLicense.Controls.Add(tabPageLocalLicense);
            tabLocalLicense.Controls.Add(tabPageInternationalLicense);
            tabLocalLicense.Location = new Point(3, 3);
            tabLocalLicense.Name = "tabLocalLicense";
            tabLocalLicense.SelectedIndex = 0;
            tabLocalLicense.Size = new Size(621, 469);
            tabLocalLicense.TabIndex = 22;
            // 
            // tabPageLocalLicense
            // 
            tabPageLocalLicense.Controls.Add(dgvShowDriverLocalLicensesHistory);
            tabPageLocalLicense.Location = new Point(4, 24);
            tabPageLocalLicense.Name = "tabPageLocalLicense";
            tabPageLocalLicense.Padding = new Padding(3);
            tabPageLocalLicense.Size = new Size(613, 441);
            tabPageLocalLicense.TabIndex = 0;
            tabPageLocalLicense.Text = "Local";
            tabPageLocalLicense.UseVisualStyleBackColor = true;
            // 
            // tabPageInternationalLicense
            // 
            tabPageInternationalLicense.Controls.Add(dgvShowDriverInternationalLicensesHistory);
            tabPageInternationalLicense.Location = new Point(4, 24);
            tabPageInternationalLicense.Name = "tabPageInternationalLicense";
            tabPageInternationalLicense.Padding = new Padding(3);
            tabPageInternationalLicense.Size = new Size(613, 441);
            tabPageInternationalLicense.TabIndex = 1;
            tabPageInternationalLicense.Text = "International";
            tabPageInternationalLicense.UseVisualStyleBackColor = true;
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
            dgvShowDriverInternationalLicensesHistory.Location = new Point(7, 7);
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
            dgvShowDriverInternationalLicensesHistory.TabIndex = 22;
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
            // ucShowDriverLicensesHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            Controls.Add(tabLocalLicense);
            Name = "ucShowDriverLicensesHistory";
            Size = new Size(631, 482);
            Load += ucShowDriverLicensesHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowDriverLocalLicensesHistory).EndInit();
            tabLocalLicense.ResumeLayout(false);
            tabPageLocalLicense.ResumeLayout(false);
            tabPageInternationalLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowDriverInternationalLicensesHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShowDriverLocalLicensesHistory;
        private DataGridViewTextBoxColumn LicenseID;
        private DataGridViewTextBoxColumn ApplicationID;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn IssueDate;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewTextBoxColumn IsActive;
        private TabControl tabLocalLicense;
        private TabPage tabPageLocalLicense;
        private TabPage tabPageInternationalLicense;
        private DataGridView dgvShowDriverInternationalLicensesHistory;
        private DataGridViewTextBoxColumn InternationalLicenseID;
        private DataGridViewTextBoxColumn ApplicationIDInternatonal;
        private DataGridViewTextBoxColumn LocalLicenseID;
        private DataGridViewTextBoxColumn IssueDateInternational;
        private DataGridViewTextBoxColumn ExpirationDateInternational;
        private DataGridViewTextBoxColumn IsActiveInternational;
    }
}
