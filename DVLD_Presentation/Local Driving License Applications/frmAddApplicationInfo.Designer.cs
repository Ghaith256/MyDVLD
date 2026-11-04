namespace DVLD_Presentation.Local_Driving_License_Applications
{
    partial class frmAddApplicationInfo
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
            lblApplicationDate = new Sunny.UI.UILabel();
            lblApplicationID = new Sunny.UI.UILabel();
            lblApplicationInfo = new Sunny.UI.UILabel();
            lblCreatedBy = new Sunny.UI.UILabel();
            lblApplicationFees = new Sunny.UI.UILabel();
            lblLicenseClass = new Sunny.UI.UILabel();
            btnSave = new Button();
            lblAnswerApplicationID = new Sunny.UI.UILabel();
            lblAnswerApplicationDate = new Sunny.UI.UILabel();
            lblAnswerApplicationFees = new Sunny.UI.UILabel();
            lblAnswerCreatedBy = new Sunny.UI.UILabel();
            cmbFilterBy = new ComboBox();
            SuspendLayout();
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.BackColor = Color.FromArgb(47, 59, 73);
            lblApplicationDate.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationDate.ForeColor = Color.White;
            lblApplicationDate.Location = new Point(44, 111);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(141, 23);
            lblApplicationDate.TabIndex = 12;
            lblApplicationDate.Text = "Application Date";
            // 
            // lblApplicationID
            // 
            lblApplicationID.BackColor = Color.FromArgb(47, 59, 73);
            lblApplicationID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationID.ForeColor = Color.White;
            lblApplicationID.Location = new Point(43, 59);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(142, 23);
            lblApplicationID.TabIndex = 11;
            lblApplicationID.Text = "D.L.Application ID";
            // 
            // lblApplicationInfo
            // 
            lblApplicationInfo.BackColor = Color.FromArgb(47, 59, 73);
            lblApplicationInfo.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationInfo.ForeColor = Color.White;
            lblApplicationInfo.Location = new Point(-6, -1);
            lblApplicationInfo.Name = "lblApplicationInfo";
            lblApplicationInfo.Size = new Size(191, 31);
            lblApplicationInfo.TabIndex = 23;
            lblApplicationInfo.Text = " Application Info";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.BackColor = Color.FromArgb(47, 59, 73);
            lblCreatedBy.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.White;
            lblCreatedBy.Location = new Point(44, 279);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(141, 23);
            lblCreatedBy.TabIndex = 24;
            lblCreatedBy.Text = "Created By";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.BackColor = Color.FromArgb(47, 59, 73);
            lblApplicationFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationFees.ForeColor = Color.White;
            lblApplicationFees.Location = new Point(44, 225);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(141, 23);
            lblApplicationFees.TabIndex = 25;
            lblApplicationFees.Text = "Application Fees";
            // 
            // lblLicenseClass
            // 
            lblLicenseClass.BackColor = Color.FromArgb(47, 59, 73);
            lblLicenseClass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseClass.ForeColor = Color.White;
            lblLicenseClass.Location = new Point(43, 167);
            lblLicenseClass.Name = "lblLicenseClass";
            lblLicenseClass.Size = new Size(142, 26);
            lblLicenseClass.TabIndex = 26;
            lblLicenseClass.Text = "License Class";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(111, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 37);
            btnSave.TabIndex = 27;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblAnswerApplicationID
            // 
            lblAnswerApplicationID.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerApplicationID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerApplicationID.ForeColor = Color.White;
            lblAnswerApplicationID.Location = new Point(201, 59);
            lblAnswerApplicationID.Name = "lblAnswerApplicationID";
            lblAnswerApplicationID.Size = new Size(145, 23);
            lblAnswerApplicationID.TabIndex = 28;
            lblAnswerApplicationID.Text = "??";
            // 
            // lblAnswerApplicationDate
            // 
            lblAnswerApplicationDate.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerApplicationDate.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerApplicationDate.ForeColor = Color.White;
            lblAnswerApplicationDate.Location = new Point(201, 111);
            lblAnswerApplicationDate.Name = "lblAnswerApplicationDate";
            lblAnswerApplicationDate.Size = new Size(145, 23);
            lblAnswerApplicationDate.TabIndex = 29;
            lblAnswerApplicationDate.Text = "??";
            // 
            // lblAnswerApplicationFees
            // 
            lblAnswerApplicationFees.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerApplicationFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerApplicationFees.ForeColor = Color.White;
            lblAnswerApplicationFees.Location = new Point(204, 225);
            lblAnswerApplicationFees.Name = "lblAnswerApplicationFees";
            lblAnswerApplicationFees.Size = new Size(145, 23);
            lblAnswerApplicationFees.TabIndex = 31;
            lblAnswerApplicationFees.Text = "??";
            // 
            // lblAnswerCreatedBy
            // 
            lblAnswerCreatedBy.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerCreatedBy.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerCreatedBy.ForeColor = Color.White;
            lblAnswerCreatedBy.Location = new Point(204, 279);
            lblAnswerCreatedBy.Name = "lblAnswerCreatedBy";
            lblAnswerCreatedBy.Size = new Size(145, 23);
            lblAnswerCreatedBy.TabIndex = 32;
            lblAnswerCreatedBy.Text = "??";
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cmbFilterBy.Location = new Point(204, 167);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(142, 26);
            cmbFilterBy.TabIndex = 33;
            // 
            // frmAddApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(361, 395);
            Controls.Add(cmbFilterBy);
            Controls.Add(lblAnswerCreatedBy);
            Controls.Add(lblAnswerApplicationFees);
            Controls.Add(lblAnswerApplicationDate);
            Controls.Add(lblAnswerApplicationID);
            Controls.Add(btnSave);
            Controls.Add(lblLicenseClass);
            Controls.Add(lblApplicationFees);
            Controls.Add(lblCreatedBy);
            Controls.Add(lblApplicationInfo);
            Controls.Add(lblApplicationDate);
            Controls.Add(lblApplicationID);
            Name = "frmAddApplicationInfo";
            Text = "frmAddApplicationInfo";
            Load += frmAddApplicationInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lblApplicationDate;
        private Sunny.UI.UILabel lblApplicationID;
        private Sunny.UI.UILabel lblApplicationInfo;
        private Sunny.UI.UILabel lblCreatedBy;
        private Sunny.UI.UILabel lblApplicationFees;
        private Sunny.UI.UILabel lblLicenseClass;
        private Button btnSave;
        private Sunny.UI.UILabel lblAnswerApplicationID;
        private Sunny.UI.UILabel lblAnswerApplicationDate;
        private Sunny.UI.UILabel lblAnswerApplicationFees;
        private Sunny.UI.UILabel lblAnswerCreatedBy;
        private ComboBox cmbFilterBy;
    }
}