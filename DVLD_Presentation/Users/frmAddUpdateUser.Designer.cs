namespace DVLD_Presentation.Users
{
    partial class frmAddUpdateUser
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
            pnlFilter = new Panel();
            btnSearch = new Button();
            cmbFilterBy = new ComboBox();
            lblFilterBy = new Label();
            pnlTextBorder = new Panel();
            txtSearchUser = new TextBox();
            ucShowPersonInfo = new ucShowInfo();
            btnNext = new Button();
            pnlFilter.SuspendLayout();
            pnlTextBorder.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(0, 15, 33);
            pnlFilter.Controls.Add(btnSearch);
            pnlFilter.Controls.Add(cmbFilterBy);
            pnlFilter.Controls.Add(lblFilterBy);
            pnlFilter.Controls.Add(pnlTextBorder);
            pnlFilter.Location = new Point(-1, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(530, 54);
            pnlFilter.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(418, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "Person ID", "National No." });
            cmbFilterBy.Location = new Point(97, 18);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(136, 26);
            cmbFilterBy.TabIndex = 18;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(13, 22);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(80, 20);
            lblFilterBy.TabIndex = 17;
            lblFilterBy.Text = "Filter By:";
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchUser);
            pnlTextBorder.Location = new Point(261, 12);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(134, 32);
            pnlTextBorder.TabIndex = 16;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchUser
            // 
            txtSearchUser.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchUser.BorderStyle = BorderStyle.None;
            txtSearchUser.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchUser.ForeColor = Color.White;
            txtSearchUser.Location = new Point(3, 3);
            txtSearchUser.Multiline = true;
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(128, 25);
            txtSearchUser.TabIndex = 1;
            // 
            // ucShowPersonInfo
            // 
            ucShowPersonInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucShowPersonInfo.Location = new Point(-4, 50);
            ucShowPersonInfo.Name = "ucShowPersonInfo";
            ucShowPersonInfo.Size = new Size(530, 411);
            ucShowPersonInfo.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(249, 115, 22);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(408, 463);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(104, 30);
            btnNext.TabIndex = 20;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(524, 505);
            Controls.Add(btnNext);
            Controls.Add(ucShowPersonInfo);
            Controls.Add(pnlFilter);
            Name = "frmAddUpdateUser";
            Text = "frmAddUpdateUser";
            Load += frmAddUpdateUser_Load_1;
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlFilter;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private Panel pnlTextBorder;
        private Button btnSearch;
        private ucShowInfo ucShowPersonInfo;
        private Button btnNext;
        private TextBox txtSearchUser;
    }
}