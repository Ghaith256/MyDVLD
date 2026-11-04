namespace DVLD_Presentation
{
    partial class frmManageApplicationTypes
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
            lblManageApplicationTypes = new Sunny.UI.UILabel();
            dgvShowApplicationTypes = new DataGridView();
            ApplicationTypeID = new DataGridViewTextBoxColumn();
            ApplicationTypeTitle = new DataGridViewTextBoxColumn();
            ApplicationFees = new DataGridViewTextBoxColumn();
            lblRecords = new Label();
            lblRecordsNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowApplicationTypes).BeginInit();
            SuspendLayout();
            // 
            // lblManageApplicationTypes
            // 
            lblManageApplicationTypes.BackColor = Color.FromArgb(47, 59, 73);
            lblManageApplicationTypes.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageApplicationTypes.ForeColor = Color.White;
            lblManageApplicationTypes.Location = new Point(-1, -2);
            lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            lblManageApplicationTypes.Size = new Size(295, 28);
            lblManageApplicationTypes.TabIndex = 14;
            lblManageApplicationTypes.Text = "Manage Application Types";
            // 
            // dgvShowApplicationTypes
            // 
            dgvShowApplicationTypes.AllowUserToAddRows = false;
            dgvShowApplicationTypes.AllowUserToDeleteRows = false;
            dgvShowApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvShowApplicationTypes.BorderStyle = BorderStyle.None;
            dgvShowApplicationTypes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowApplicationTypes.Columns.AddRange(new DataGridViewColumn[] { ApplicationTypeID, ApplicationTypeTitle, ApplicationFees });
            dgvShowApplicationTypes.EnableHeadersVisualStyles = false;
            dgvShowApplicationTypes.Location = new Point(12, 65);
            dgvShowApplicationTypes.Name = "dgvShowApplicationTypes";
            dgvShowApplicationTypes.ReadOnly = true;
            dgvShowApplicationTypes.RowHeadersVisible = false;
            dgvShowApplicationTypes.RowTemplate.ReadOnly = true;
            dgvShowApplicationTypes.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowApplicationTypes.ShowCellErrors = false;
            dgvShowApplicationTypes.ShowCellToolTips = false;
            dgvShowApplicationTypes.ShowEditingIcon = false;
            dgvShowApplicationTypes.ShowRowErrors = false;
            dgvShowApplicationTypes.Size = new Size(593, 275);
            dgvShowApplicationTypes.TabIndex = 17;
            dgvShowApplicationTypes.CellDoubleClick += dgvShowApplicationTypes_CellDoubleClick;
            // 
            // ApplicationTypeID
            // 
            ApplicationTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ApplicationTypeID.DataPropertyName = "ApplicationTypeID";
            ApplicationTypeID.HeaderText = "ID";
            ApplicationTypeID.Name = "ApplicationTypeID";
            ApplicationTypeID.ReadOnly = true;
            ApplicationTypeID.Width = 44;
            // 
            // ApplicationTypeTitle
            // 
            ApplicationTypeTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApplicationTypeTitle.DataPropertyName = "ApplicationTypeTitle";
            ApplicationTypeTitle.HeaderText = "Title";
            ApplicationTypeTitle.Name = "ApplicationTypeTitle";
            ApplicationTypeTitle.ReadOnly = true;
            // 
            // ApplicationFees
            // 
            ApplicationFees.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ApplicationFees.DataPropertyName = "ApplicationFees";
            ApplicationFees.HeaderText = "Fees";
            ApplicationFees.Name = "ApplicationFees";
            ApplicationFees.ReadOnly = true;
            ApplicationFees.Width = 59;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Cursor = Cursors.Hand;
            lblRecords.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.ForeColor = Color.White;
            lblRecords.Location = new Point(12, 346);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(90, 23);
            lblRecords.TabIndex = 18;
            lblRecords.Text = "Recrods: ";
            // 
            // lblRecordsNumber
            // 
            lblRecordsNumber.AutoSize = true;
            lblRecordsNumber.Cursor = Cursors.Hand;
            lblRecordsNumber.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsNumber.ForeColor = Color.White;
            lblRecordsNumber.Location = new Point(99, 346);
            lblRecordsNumber.Name = "lblRecordsNumber";
            lblRecordsNumber.Size = new Size(28, 23);
            lblRecordsNumber.TabIndex = 19;
            lblRecordsNumber.Text = "??";
            // 
            // frmManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(617, 378);
            Controls.Add(lblRecordsNumber);
            Controls.Add(lblRecords);
            Controls.Add(dgvShowApplicationTypes);
            Controls.Add(lblManageApplicationTypes);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmManageApplicationTypes";
            Text = "frmManageApplicationTypes";
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowApplicationTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UILabel lblManageApplicationTypes;
        private DataGridView dgvShowApplicationTypes;
        private Label lblRecords;
        private Label lblRecordsNumber;
        private DataGridViewTextBoxColumn ApplicationTypeID;
        private DataGridViewTextBoxColumn ApplicationTypeTitle;
        private DataGridViewTextBoxColumn ApplicationFees;
    }
}