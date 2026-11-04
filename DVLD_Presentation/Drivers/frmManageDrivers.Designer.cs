namespace DVLD_Presentation.Drivers
{
    partial class frmManageDrivers
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
            pnlTextBorder = new Panel();
            txtSearchDriver = new TextBox();
            cmbFilterBy = new ComboBox();
            lblFilterBy = new Label();
            dgvShowDrivers = new DataGridView();
            DriverID = new DataGridViewTextBoxColumn();
            PersonID = new DataGridViewTextBoxColumn();
            NationalNo = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ActiveLicenses = new DataGridViewTextBoxColumn();
            pnlTextBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowDrivers).BeginInit();
            SuspendLayout();
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchDriver);
            pnlTextBorder.Location = new Point(288, 16);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(247, 26);
            pnlTextBorder.TabIndex = 25;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchDriver
            // 
            txtSearchDriver.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchDriver.BorderStyle = BorderStyle.None;
            txtSearchDriver.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchDriver.ForeColor = Color.White;
            txtSearchDriver.Location = new Point(3, 0);
            txtSearchDriver.Multiline = true;
            txtSearchDriver.Name = "txtSearchDriver";
            txtSearchDriver.Size = new Size(241, 24);
            txtSearchDriver.TabIndex = 4;
            txtSearchDriver.TextChanged += txtSearchDriver_TextChanged;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            cmbFilterBy.Location = new Point(96, 18);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(136, 26);
            cmbFilterBy.TabIndex = 24;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(12, 22);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(80, 20);
            lblFilterBy.TabIndex = 23;
            lblFilterBy.Text = "Filter By:";
            // 
            // dgvShowDrivers
            // 
            dgvShowDrivers.AllowUserToAddRows = false;
            dgvShowDrivers.AllowUserToDeleteRows = false;
            dgvShowDrivers.BorderStyle = BorderStyle.None;
            dgvShowDrivers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowDrivers.Columns.AddRange(new DataGridViewColumn[] { DriverID, PersonID, NationalNo, FullName, Date, ActiveLicenses });
            dgvShowDrivers.EnableHeadersVisualStyles = false;
            dgvShowDrivers.Location = new Point(4, 60);
            dgvShowDrivers.Name = "dgvShowDrivers";
            dgvShowDrivers.ReadOnly = true;
            dgvShowDrivers.RowHeadersVisible = false;
            dgvShowDrivers.RowTemplate.ReadOnly = true;
            dgvShowDrivers.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowDrivers.ShowCellErrors = false;
            dgvShowDrivers.ShowCellToolTips = false;
            dgvShowDrivers.ShowEditingIcon = false;
            dgvShowDrivers.ShowRowErrors = false;
            dgvShowDrivers.Size = new Size(598, 426);
            dgvShowDrivers.TabIndex = 22;
            // 
            // DriverID
            // 
            DriverID.DataPropertyName = "DriverID";
            DriverID.HeaderText = "Driver ID";
            DriverID.Name = "DriverID";
            DriverID.ReadOnly = true;
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "Person ID";
            PersonID.Name = "PersonID";
            PersonID.ReadOnly = true;
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
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // ActiveLicenses
            // 
            ActiveLicenses.DataPropertyName = "ActiveLicenses";
            ActiveLicenses.HeaderText = "Active Licenses";
            ActiveLicenses.Name = "ActiveLicenses";
            ActiveLicenses.ReadOnly = true;
            // 
            // frmManageDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(613, 490);
            Controls.Add(pnlTextBorder);
            Controls.Add(cmbFilterBy);
            Controls.Add(lblFilterBy);
            Controls.Add(dgvShowDrivers);
            Name = "frmManageDrivers";
            Text = "frmManageDrivers";
            Load += frmManageDrivers_Load;
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTextBorder;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private DataGridView dgvShowDrivers;
        private DataGridViewTextBoxColumn DriverID;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ActiveLicenses;
        private TextBox txtSearchDriver;
    }
}