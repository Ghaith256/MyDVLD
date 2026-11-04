namespace DVLD_Presentation.Test_Types
{
    partial class frmManageTestTypes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvShowTestTypes = new DataGridView();
            TestTypeID = new DataGridViewTextBoxColumn();
            TestTypeTitle = new DataGridViewTextBoxColumn();
            TestTypeDescription = new DataGridViewTextBoxColumn();
            TestTypeFees = new DataGridViewTextBoxColumn();
            lblManageTestTypes = new Sunny.UI.UILabel();
            lblRecordsNumber = new Label();
            lblRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowTestTypes).BeginInit();
            SuspendLayout();
            // 
            // dgvShowTestTypes
            // 
            dgvShowTestTypes.AllowUserToAddRows = false;
            dgvShowTestTypes.AllowUserToDeleteRows = false;
            dgvShowTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvShowTestTypes.BorderStyle = BorderStyle.None;
            dgvShowTestTypes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowTestTypes.Columns.AddRange(new DataGridViewColumn[] { TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvShowTestTypes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvShowTestTypes.EnableHeadersVisualStyles = false;
            dgvShowTestTypes.Location = new Point(12, 65);
            dgvShowTestTypes.Name = "dgvShowTestTypes";
            dgvShowTestTypes.ReadOnly = true;
            dgvShowTestTypes.RowHeadersVisible = false;
            dgvShowTestTypes.RowTemplate.ReadOnly = true;
            dgvShowTestTypes.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowTestTypes.ShowCellErrors = false;
            dgvShowTestTypes.ShowCellToolTips = false;
            dgvShowTestTypes.ShowEditingIcon = false;
            dgvShowTestTypes.ShowRowErrors = false;
            dgvShowTestTypes.Size = new Size(798, 275);
            dgvShowTestTypes.TabIndex = 21;
            dgvShowTestTypes.CellDoubleClick += dgvShowTestTypes_CellDoubleClick;
            // 
            // TestTypeID
            // 
            TestTypeID.DataPropertyName = "TestTypeID";
            TestTypeID.HeaderText = "ID";
            TestTypeID.Name = "TestTypeID";
            TestTypeID.ReadOnly = true;
            TestTypeID.Width = 49;
            // 
            // TestTypeTitle
            // 
            TestTypeTitle.DataPropertyName = "TestTypeTitle";
            TestTypeTitle.HeaderText = "Title";
            TestTypeTitle.Name = "TestTypeTitle";
            TestTypeTitle.ReadOnly = true;
            TestTypeTitle.Width = 60;
            // 
            // TestTypeDescription
            // 
            TestTypeDescription.DataPropertyName = "TestTypeDescription";
            TestTypeDescription.HeaderText = "Description";
            TestTypeDescription.Name = "TestTypeDescription";
            TestTypeDescription.ReadOnly = true;
            TestTypeDescription.Width = 103;
            // 
            // TestTypeFees
            // 
            TestTypeFees.DataPropertyName = "TestTypeFees";
            TestTypeFees.HeaderText = "Fees";
            TestTypeFees.Name = "TestTypeFees";
            TestTypeFees.ReadOnly = true;
            TestTypeFees.Width = 64;
            // 
            // lblManageTestTypes
            // 
            lblManageTestTypes.BackColor = Color.FromArgb(47, 59, 73);
            lblManageTestTypes.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageTestTypes.ForeColor = Color.White;
            lblManageTestTypes.Location = new Point(5, 4);
            lblManageTestTypes.Name = "lblManageTestTypes";
            lblManageTestTypes.Size = new Size(224, 28);
            lblManageTestTypes.TabIndex = 20;
            lblManageTestTypes.Text = "Manage Test Types";
            // 
            // lblRecordsNumber
            // 
            lblRecordsNumber.AutoSize = true;
            lblRecordsNumber.Cursor = Cursors.Hand;
            lblRecordsNumber.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsNumber.ForeColor = Color.White;
            lblRecordsNumber.Location = new Point(96, 346);
            lblRecordsNumber.Name = "lblRecordsNumber";
            lblRecordsNumber.Size = new Size(28, 23);
            lblRecordsNumber.TabIndex = 23;
            lblRecordsNumber.Text = "??";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Cursor = Cursors.Hand;
            lblRecords.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.ForeColor = Color.White;
            lblRecords.Location = new Point(9, 346);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(90, 23);
            lblRecords.TabIndex = 22;
            lblRecords.Text = "Recrods: ";
            // 
            // frmManageTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(822, 378);
            Controls.Add(dgvShowTestTypes);
            Controls.Add(lblManageTestTypes);
            Controls.Add(lblRecordsNumber);
            Controls.Add(lblRecords);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmManageTestTypes";
            Text = "frmManageTestTypes";
            Load += frmManageTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowTestTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowTestTypes;
        private Sunny.UI.UILabel lblManageTestTypes;
        private Label lblRecordsNumber;
        private Label lblRecords;
        private DataGridViewTextBoxColumn TestTypeID;
        private DataGridViewTextBoxColumn TestTypeTitle;
        private DataGridViewTextBoxColumn TestTypeDescription;
        private DataGridViewTextBoxColumn TestTypeFees;
    }
}