namespace DVLD_Presentation.People {
    partial class frmManagePeople {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            btnDeletePerson = new Button();
            dgvShowPeople = new DataGridView();
            PersonID = new DataGridViewTextBoxColumn();
            NationalNo = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            SecondName = new DataGridViewTextBoxColumn();
            ThirdName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gendor = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            txtSearchPerson = new TextBox();
            cmbFilterBy = new ComboBox();
            lblFilterBy = new Label();
            pnlTextBorder = new Panel();
            btnUpdatePerson = new Button();
            btnAddPerson = new Button();
            cxmManagePeople = new ContextMenuStrip(components);
            ShowDetailsToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvShowPeople).BeginInit();
            pnlTextBorder.SuspendLayout();
            cxmManagePeople.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.BackColor = Color.White;
            btnDeletePerson.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePerson.ForeColor = Color.White;
            btnDeletePerson.Location = new Point(824, 12);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(126, 37);
            btnDeletePerson.TabIndex = 16;
            btnDeletePerson.Text = "Delete";
            btnDeletePerson.UseVisualStyleBackColor = false;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // dgvShowPeople
            // 
            dgvShowPeople.AllowUserToAddRows = false;
            dgvShowPeople.AllowUserToDeleteRows = false;
            dgvShowPeople.BorderStyle = BorderStyle.None;
            dgvShowPeople.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowPeople.Columns.AddRange(new DataGridViewColumn[] { PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, Nationality, Phone, Email });
            dgvShowPeople.EnableHeadersVisualStyles = false;
            dgvShowPeople.Location = new Point(17, 65);
            dgvShowPeople.Name = "dgvShowPeople";
            dgvShowPeople.ReadOnly = true;
            dgvShowPeople.RowHeadersVisible = false;
            dgvShowPeople.RowTemplate.ReadOnly = true;
            dgvShowPeople.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowPeople.ShowCellErrors = false;
            dgvShowPeople.ShowCellToolTips = false;
            dgvShowPeople.ShowEditingIcon = false;
            dgvShowPeople.ShowRowErrors = false;
            dgvShowPeople.Size = new Size(1077, 426);
            dgvShowPeople.TabIndex = 20;
            dgvShowPeople.CellFormatting += dgvShowPeople_CellFormatting;
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "PersonID";
            PersonID.Name = "PersonID";
            PersonID.ReadOnly = true;
            PersonID.Resizable = DataGridViewTriState.False;
            // 
            // NationalNo
            // 
            NationalNo.DataPropertyName = "NationalNo";
            NationalNo.HeaderText = "National No.";
            NationalNo.Name = "NationalNo";
            NationalNo.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            SecondName.DataPropertyName = "SecondName";
            SecondName.HeaderText = "Second Name";
            SecondName.Name = "SecondName";
            SecondName.ReadOnly = true;
            // 
            // ThirdName
            // 
            ThirdName.DataPropertyName = "ThirdName";
            ThirdName.HeaderText = "Third Name";
            ThirdName.Name = "ThirdName";
            ThirdName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Gendor
            // 
            Gendor.DataPropertyName = "Gendor";
            Gendor.HeaderText = "Gendor";
            Gendor.Name = "Gendor";
            Gendor.ReadOnly = true;
            Gendor.Resizable = DataGridViewTriState.False;
            // 
            // DateOfBirth
            // 
            DateOfBirth.DataPropertyName = "DateOfBirth";
            DateOfBirth.HeaderText = "Date Of Birth";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            // 
            // Nationality
            // 
            Nationality.DataPropertyName = "NationalityCountryID";
            Nationality.HeaderText = "Nationality";
            Nationality.Name = "Nationality";
            Nationality.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // txtSearchPerson
            // 
            txtSearchPerson.Location = new Point(3, 11);
            txtSearchPerson.Name = "txtSearchPerson";
            txtSearchPerson.Size = new Size(361, 24);
            txtSearchPerson.TabIndex = 0;
            txtSearchPerson.TextAlign = HorizontalAlignment.Center;
            txtSearchPerson.TextChanged += txtSearchPerson_TextChanged;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cmbFilterBy.Location = new Point(101, 16);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(136, 26);
            cmbFilterBy.TabIndex = 19;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(17, 20);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(80, 20);
            lblFilterBy.TabIndex = 18;
            lblFilterBy.Text = "Filter By:";
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchPerson);
            pnlTextBorder.Location = new Point(290, 12);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(367, 35);
            pnlTextBorder.TabIndex = 17;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.BackColor = Color.White;
            btnUpdatePerson.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePerson.ForeColor = Color.White;
            btnUpdatePerson.Location = new Point(968, 12);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(126, 37);
            btnUpdatePerson.TabIndex = 21;
            btnUpdatePerson.Text = "Update";
            btnUpdatePerson.UseVisualStyleBackColor = false;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.White;
            btnAddPerson.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPerson.ForeColor = Color.White;
            btnAddPerson.Location = new Point(680, 12);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(126, 37);
            btnAddPerson.TabIndex = 15;
            btnAddPerson.Text = "Add";
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // cxmManagePeople
            // 
            cxmManagePeople.Items.AddRange(new ToolStripItem[] { ShowDetailsToolStripMenuItem, EditToolStripMenuItem, DeleteToolStripMenuItem });
            cxmManagePeople.Name = "cxmManagePeople";
            cxmManagePeople.Size = new Size(181, 92);
            // 
            // ShowDetailsToolStripMenuItem
            // 
            ShowDetailsToolStripMenuItem.Name = "ShowDetailsToolStripMenuItem";
            ShowDetailsToolStripMenuItem.Size = new Size(180, 22);
            ShowDetailsToolStripMenuItem.Text = "Show Details";
            ShowDetailsToolStripMenuItem.Click += ShowDetailsToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(180, 22);
            EditToolStripMenuItem.Text = "Edit";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(180, 22);
            DeleteToolStripMenuItem.Text = "Delete";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // frmManagePeople
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1110, 503);
            Controls.Add(btnDeletePerson);
            Controls.Add(dgvShowPeople);
            Controls.Add(cmbFilterBy);
            Controls.Add(lblFilterBy);
            Controls.Add(pnlTextBorder);
            Controls.Add(btnUpdatePerson);
            Controls.Add(btnAddPerson);
            Font = new Font("Segoe UI", 9.5F);
            Name = "frmManagePeople";
            Text = "frmManagePeople";
            Load += frmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowPeople).EndInit();
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            cxmManagePeople.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeletePerson;
        private DataGridView dgvShowPeople;
        private TextBox txtSearchPerson;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private Panel pnlTextBorder;
        private Button btnUpdatePerson;
        private Button btnAddPerson;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn ThirdName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gendor;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private ContextMenuStrip cxmManagePeople;
        private ToolStripMenuItem ShowDetailsToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
    }
}