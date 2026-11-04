namespace DVLD_Presentation
{
    partial class frmManageUsers
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
            dgvShowUser = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            PersonID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            cxmManageUsers = new ContextMenuStrip(components);
            itemShowDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            itemUpdateUser = new ToolStripMenuItem();
            itemDelete = new ToolStripMenuItem();
            itemChangePassword = new ToolStripMenuItem();
            pnlTextBorder = new Panel();
            txtSearchUser = new TextBox();
            btnAddUser = new Button();
            cmbFilterBy = new ComboBox();
            lblFilterBy = new Label();
            cmbIsActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvShowUser).BeginInit();
            cxmManageUsers.SuspendLayout();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // dgvShowUser
            // 
            dgvShowUser.AllowUserToAddRows = false;
            dgvShowUser.AllowUserToDeleteRows = false;
            dgvShowUser.BorderStyle = BorderStyle.None;
            dgvShowUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShowUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowUser.Columns.AddRange(new DataGridViewColumn[] { UserID, PersonID, FullName, Username, IsActive });
            dgvShowUser.ContextMenuStrip = cxmManageUsers;
            dgvShowUser.EnableHeadersVisualStyles = false;
            dgvShowUser.Location = new Point(12, 65);
            dgvShowUser.Name = "dgvShowUser";
            dgvShowUser.ReadOnly = true;
            dgvShowUser.RowHeadersVisible = false;
            dgvShowUser.RowTemplate.ReadOnly = true;
            dgvShowUser.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvShowUser.ShowCellErrors = false;
            dgvShowUser.ShowCellToolTips = false;
            dgvShowUser.ShowEditingIcon = false;
            dgvShowUser.ShowRowErrors = false;
            dgvShowUser.Size = new Size(800, 426);
            dgvShowUser.TabIndex = 16;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "User ID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "Person ID";
            PersonID.Name = "PersonID";
            PersonID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 400;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "IsActive";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            // 
            // cxmManageUsers
            // 
            cxmManageUsers.Items.AddRange(new ToolStripItem[] { itemShowDetails, toolStripSeparator1, itemUpdateUser, itemDelete, itemChangePassword });
            cxmManageUsers.Name = "contextMenuStrip1";
            cxmManageUsers.Size = new Size(177, 98);
            // 
            // itemShowDetails
            // 
            itemShowDetails.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemShowDetails.Name = "itemShowDetails";
            itemShowDetails.Size = new Size(176, 22);
            itemShowDetails.Text = "Show Details";
            itemShowDetails.Click += itemShowDetails_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(173, 6);
            // 
            // itemUpdateUser
            // 
            itemUpdateUser.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemUpdateUser.Name = "itemUpdateUser";
            itemUpdateUser.Size = new Size(176, 22);
            itemUpdateUser.Text = "Update";
            itemUpdateUser.Click += itemUpdateUser_Click;
            // 
            // itemDelete
            // 
            itemDelete.Name = "itemDelete";
            itemDelete.Size = new Size(176, 22);
            itemDelete.Text = "Delete";
            itemDelete.Click += itemDelete_Click;
            // 
            // itemChangePassword
            // 
            itemChangePassword.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemChangePassword.Name = "itemChangePassword";
            itemChangePassword.Size = new Size(176, 22);
            itemChangePassword.Text = "Change Password";
            itemChangePassword.Click += itemChangePassword_Click;
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchUser);
            pnlTextBorder.Location = new Point(264, 7);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(280, 35);
            pnlTextBorder.TabIndex = 13;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(3, 11);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(276, 23);
            txtSearchUser.TabIndex = 0;
            txtSearchUser.TextAlign = HorizontalAlignment.Center;
            txtSearchUser.TextChanged += txtSearchUser_TextChanged;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.White;
            btnAddUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(679, 10);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(126, 37);
            btnAddUser.TabIndex = 12;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cmbFilterBy.Location = new Point(96, 16);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(136, 26);
            cmbFilterBy.TabIndex = 15;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(12, 20);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(80, 20);
            lblFilterBy.TabIndex = 14;
            lblFilterBy.Text = "Filter By:";
            // 
            // cmbIsActive
            // 
            cmbIsActive.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbIsActive.FormattingEnabled = true;
            cmbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cmbIsActive.Location = new Point(595, 14);
            cmbIsActive.Name = "cmbIsActive";
            cmbIsActive.Size = new Size(61, 26);
            cmbIsActive.TabIndex = 17;
            cmbIsActive.SelectedIndexChanged += cmbIsActive_SelectedIndexChanged;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 503);
            Controls.Add(cmbIsActive);
            Controls.Add(dgvShowUser);
            Controls.Add(pnlTextBorder);
            Controls.Add(btnAddUser);
            Controls.Add(cmbFilterBy);
            Controls.Add(lblFilterBy);
            Name = "frmManageUsers";
            Text = "frmManageUsers";
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowUser).EndInit();
            cxmManageUsers.ResumeLayout(false);
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowUser;
        private Panel pnlTextBorder;
        private TextBox txtSearchUser;
        private Button btnAddUser;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private ContextMenuStrip cxmManageUsers;
        private ToolStripMenuItem itemShowDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem itemUpdateUser;
        private ToolStripMenuItem itemDelete;
        private ToolStripMenuItem itemChangePassword;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn IsActive;
        private ComboBox cmbIsActive;
    }
}