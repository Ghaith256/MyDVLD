namespace DVLD_Presentation.Local_Driving_License_Applications
{
    partial class frmAddUpdateLocalDrivingLicenseApplication
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
            txtSearchPerson = new TextBox();
            btnNext = new Button();
            ucShowPersonInfo = new ucShowInfo();
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
            pnlFilter.Location = new Point(-1, 12);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(526, 54);
            pnlFilter.TabIndex = 21;
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
            lblFilterBy.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.ForeColor = Color.White;
            lblFilterBy.Location = new Point(13, 22);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(83, 19);
            lblFilterBy.TabIndex = 17;
            lblFilterBy.Text = "Filter By:";
            // 
            // pnlTextBorder
            // 
            pnlTextBorder.Controls.Add(txtSearchPerson);
            pnlTextBorder.Location = new Point(261, 12);
            pnlTextBorder.Name = "pnlTextBorder";
            pnlTextBorder.Size = new Size(134, 29);
            pnlTextBorder.TabIndex = 16;
            pnlTextBorder.Paint += pnlTextBorder_Paint;
            // 
            // txtSearchPerson
            // 
            txtSearchPerson.BackColor = Color.FromArgb(0, 15, 33);
            txtSearchPerson.BorderStyle = BorderStyle.None;
            txtSearchPerson.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchPerson.ForeColor = Color.White;
            txtSearchPerson.Location = new Point(3, 3);
            txtSearchPerson.Multiline = true;
            txtSearchPerson.Name = "txtSearchPerson";
            txtSearchPerson.Size = new Size(128, 25);
            txtSearchPerson.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(249, 115, 22);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(412, 458);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 30);
            btnNext.TabIndex = 23;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ucShowPersonInfo
            // 
            ucShowPersonInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucShowPersonInfo.Location = new Point(-1, 62);
            ucShowPersonInfo.Name = "ucShowPersonInfo";
            ucShowPersonInfo.Size = new Size(526, 390);
            ucShowPersonInfo.TabIndex = 22;
            // 
            // frmAddUpdateLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(524, 500);
            Controls.Add(pnlFilter);
            Controls.Add(btnNext);
            Controls.Add(ucShowPersonInfo);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Location = new Point(540, 455);
            Name = "frmAddUpdateLocalDrivingLicenseApplication";
            Text = "frmManageLocalDrivingLicenseApplications";
            Load += frmManageLocalDrivingLicenseApplications_Load;
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlTextBorder.ResumeLayout(false);
            pnlTextBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFilter;
        private Button btnSearch;
        private ComboBox cmbFilterBy;
        private Label lblFilterBy;
        private Panel pnlTextBorder;
        private TextBox txtSearchPerson;
        private Button btnNext;
        private ucShowInfo ucShowPersonInfo;
    }
}