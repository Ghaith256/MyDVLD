namespace DVLD_Presentation
{
    partial class ucShowInfo
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
            lblName = new Label();
            pbProfilePicture = new PictureBox();
            pnlPersonInfo = new Panel();
            pnlPersonalInfo = new Panel();
            lblAnswerAddress = new Label();
            lblAnswerEmail = new Label();
            lblAnswerPhone = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAnswerGender = new Label();
            lblAnswerCountry = new Label();
            lblAnswerDateOfBirth = new Label();
            lblAnswerNationalNo = new Label();
            lblCountry = new Label();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            lblNationalNo = new Label();
            iconPersonalInfo = new FontAwesome.Sharp.IconPictureBox();
            lblPersonInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).BeginInit();
            pnlPersonInfo.SuspendLayout();
            pnlPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPersonalInfo).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(-22, 212);
            lblName.Name = "lblName";
            lblName.Size = new Size(264, 30);
            lblName.TabIndex = 1;
            lblName.Text = "First Last";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbProfilePicture
            // 
            pbProfilePicture.Location = new Point(16, 44);
            pbProfilePicture.Name = "pbProfilePicture";
            pbProfilePicture.Size = new Size(185, 147);
            pbProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfilePicture.TabIndex = 0;
            pbProfilePicture.TabStop = false;
            // 
            // pnlPersonInfo
            // 
            pnlPersonInfo.Controls.Add(pnlPersonalInfo);
            pnlPersonInfo.Location = new Point(13, 14);
            pnlPersonInfo.Name = "pnlPersonInfo";
            pnlPersonInfo.Size = new Size(502, 388);
            pnlPersonInfo.TabIndex = 1;
            pnlPersonInfo.Paint += pnlTextBorder_Paint;
            // 
            // pnlPersonalInfo
            // 
            pnlPersonalInfo.Controls.Add(lblName);
            pnlPersonalInfo.Controls.Add(lblAnswerAddress);
            pnlPersonalInfo.Controls.Add(lblAnswerEmail);
            pnlPersonalInfo.Controls.Add(lblAnswerPhone);
            pnlPersonalInfo.Controls.Add(lblAddress);
            pnlPersonalInfo.Controls.Add(lblEmail);
            pnlPersonalInfo.Controls.Add(lblPhone);
            pnlPersonalInfo.Controls.Add(lblAnswerGender);
            pnlPersonalInfo.Controls.Add(lblAnswerCountry);
            pnlPersonalInfo.Controls.Add(lblAnswerDateOfBirth);
            pnlPersonalInfo.Controls.Add(pbProfilePicture);
            pnlPersonalInfo.Controls.Add(lblAnswerNationalNo);
            pnlPersonalInfo.Controls.Add(lblCountry);
            pnlPersonalInfo.Controls.Add(lblDateOfBirth);
            pnlPersonalInfo.Controls.Add(lblGender);
            pnlPersonalInfo.Controls.Add(lblNationalNo);
            pnlPersonalInfo.Controls.Add(iconPersonalInfo);
            pnlPersonalInfo.Controls.Add(lblPersonInfo);
            pnlPersonalInfo.Location = new Point(22, 13);
            pnlPersonalInfo.Name = "pnlPersonalInfo";
            pnlPersonalInfo.Size = new Size(455, 349);
            pnlPersonalInfo.TabIndex = 0;
            // 
            // lblAnswerAddress
            // 
            lblAnswerAddress.AutoSize = true;
            lblAnswerAddress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerAddress.ForeColor = Color.White;
            lblAnswerAddress.Location = new Point(357, 313);
            lblAnswerAddress.Name = "lblAnswerAddress";
            lblAnswerAddress.Size = new Size(59, 19);
            lblAnswerAddress.TabIndex = 24;
            lblAnswerAddress.Text = "answer";
            // 
            // lblAnswerEmail
            // 
            lblAnswerEmail.AutoSize = true;
            lblAnswerEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerEmail.ForeColor = Color.White;
            lblAnswerEmail.Location = new Point(357, 268);
            lblAnswerEmail.Name = "lblAnswerEmail";
            lblAnswerEmail.Size = new Size(59, 19);
            lblAnswerEmail.TabIndex = 25;
            lblAnswerEmail.Text = "answer";
            // 
            // lblAnswerPhone
            // 
            lblAnswerPhone.AutoSize = true;
            lblAnswerPhone.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerPhone.ForeColor = Color.White;
            lblAnswerPhone.Location = new Point(359, 162);
            lblAnswerPhone.Name = "lblAnswerPhone";
            lblAnswerPhone.Size = new Size(59, 19);
            lblAnswerPhone.TabIndex = 26;
            lblAnswerPhone.Text = "answer";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(238, 313);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(97, 19);
            lblAddress.TabIndex = 21;
            lblAddress.Text = "Address     :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(238, 268);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(99, 19);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email         :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(240, 162);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(99, 19);
            lblPhone.TabIndex = 23;
            lblPhone.Text = "Phone        :";
            // 
            // lblAnswerGender
            // 
            lblAnswerGender.AutoSize = true;
            lblAnswerGender.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerGender.ForeColor = Color.White;
            lblAnswerGender.Location = new Point(359, 44);
            lblAnswerGender.Name = "lblAnswerGender";
            lblAnswerGender.Size = new Size(59, 19);
            lblAnswerGender.TabIndex = 17;
            lblAnswerGender.Text = "answer";
            // 
            // lblAnswerCountry
            // 
            lblAnswerCountry.AutoSize = true;
            lblAnswerCountry.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerCountry.ForeColor = Color.White;
            lblAnswerCountry.Location = new Point(359, 101);
            lblAnswerCountry.Name = "lblAnswerCountry";
            lblAnswerCountry.Size = new Size(59, 19);
            lblAnswerCountry.TabIndex = 16;
            lblAnswerCountry.Text = "answer";
            // 
            // lblAnswerDateOfBirth
            // 
            lblAnswerDateOfBirth.AutoSize = true;
            lblAnswerDateOfBirth.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerDateOfBirth.ForeColor = Color.White;
            lblAnswerDateOfBirth.Location = new Point(142, 313);
            lblAnswerDateOfBirth.Name = "lblAnswerDateOfBirth";
            lblAnswerDateOfBirth.Size = new Size(59, 19);
            lblAnswerDateOfBirth.TabIndex = 15;
            lblAnswerDateOfBirth.Text = "answer";
            // 
            // lblAnswerNationalNo
            // 
            lblAnswerNationalNo.AutoSize = true;
            lblAnswerNationalNo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerNationalNo.ForeColor = Color.White;
            lblAnswerNationalNo.Location = new Point(142, 268);
            lblAnswerNationalNo.Name = "lblAnswerNationalNo";
            lblAnswerNationalNo.Size = new Size(59, 19);
            lblAnswerNationalNo.TabIndex = 14;
            lblAnswerNationalNo.Text = "answer";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountry.ForeColor = Color.White;
            lblCountry.Location = new Point(240, 101);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(101, 19);
            lblCountry.TabIndex = 13;
            lblCountry.Text = "Country      :";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(23, 313);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(114, 19);
            lblDateOfBirth.TabIndex = 12;
            lblDateOfBirth.Text = "Date of Birth  :";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(240, 44);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(101, 19);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender       :";
            // 
            // lblNationalNo
            // 
            lblNationalNo.AutoSize = true;
            lblNationalNo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNationalNo.ForeColor = Color.White;
            lblNationalNo.Location = new Point(23, 268);
            lblNationalNo.Name = "lblNationalNo";
            lblNationalNo.Size = new Size(113, 19);
            lblNationalNo.TabIndex = 10;
            lblNationalNo.Text = "NationalNo    :";
            // 
            // iconPersonalInfo
            // 
            iconPersonalInfo.BackColor = Color.FromArgb(0, 15, 33);
            iconPersonalInfo.ForeColor = Color.FromArgb(249, 115, 22);
            iconPersonalInfo.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPersonalInfo.IconColor = Color.FromArgb(249, 115, 22);
            iconPersonalInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPersonalInfo.IconSize = 34;
            iconPersonalInfo.Location = new Point(3, 3);
            iconPersonalInfo.Name = "iconPersonalInfo";
            iconPersonalInfo.Size = new Size(41, 34);
            iconPersonalInfo.TabIndex = 1;
            iconPersonalInfo.TabStop = false;
            // 
            // lblPersonInfo
            // 
            lblPersonInfo.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonInfo.ForeColor = Color.White;
            lblPersonInfo.Location = new Point(50, 0);
            lblPersonInfo.Name = "lblPersonInfo";
            lblPersonInfo.Size = new Size(405, 34);
            lblPersonInfo.TabIndex = 0;
            lblPersonInfo.Text = "Personal Info";
            lblPersonInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ucShowInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            Controls.Add(pnlPersonInfo);
            Name = "ucShowInfo";
            Size = new Size(530, 420);
            Load += ucShowInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).EndInit();
            pnlPersonInfo.ResumeLayout(false);
            pnlPersonalInfo.ResumeLayout(false);
            pnlPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPersonalInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPersonInfo;
        private PictureBox pbProfilePicture;
        private Label lblName;
        private Panel pnlPersonalInfo;
        private Label lblPersonInfo;
        private FontAwesome.Sharp.IconPictureBox iconPersonalInfo;
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblNationalNo;
        private Label lblCountry;
        private Label lblAnswerGender;
        private Label lblAnswerCountry;
        private Label lblAnswerDateOfBirth;
        private Label lblAnswerNationalNo;
        private Label lblAnswerAddress;
        private Label lblAnswerEmail;
        private Label lblAnswerPhone;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblPhone;
    }
}
