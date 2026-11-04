namespace DVLD_Presentation.People
{
    partial class frmAddUpdatePerson
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
            pnlName = new Sunny.UI.UIPanel();
            txtThirdName = new Sunny.UI.UITextBox();
            txtLastName = new Sunny.UI.UITextBox();
            txtSecondName = new Sunny.UI.UITextBox();
            txtFirstName = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            lblFirstName = new Sunny.UI.UILabel();
            lblName = new Sunny.UI.UILabel();
            pnlPersonalInfo = new Sunny.UI.UIPanel();
            grpGender = new GroupBox();
            rbFemale = new Sunny.UI.UIRadioButton();
            rbMale = new Sunny.UI.UIRadioButton();
            timeDateOfBirth = new DateTimePicker();
            cmbCountry = new Sunny.UI.UIComboBox();
            lblCountry = new Sunny.UI.UILabel();
            lblDateOfBirth = new Sunny.UI.UILabel();
            txtEmail = new Sunny.UI.UITextBox();
            lblEmail = new Sunny.UI.UILabel();
            txtPhone = new Sunny.UI.UITextBox();
            lblPhone = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            txtNationalNo = new Sunny.UI.UITextBox();
            lblPersonalInfo = new Sunny.UI.UILabel();
            pnlAddress = new Sunny.UI.UIPanel();
            txtAddress = new Sunny.UI.UITextBox();
            lblAddress = new Sunny.UI.UILabel();
            btnSave = new Button();
            pbProfilePicture = new PictureBox();
            cxmProfilePicture = new ContextMenuStrip(components);
            tsmRemovePicture = new ToolStripMenuItem();
            tsmAddPicture = new ToolStripMenuItem();
            errUniqueNationalNo = new ErrorProvider(components);
            pnlName.SuspendLayout();
            pnlPersonalInfo.SuspendLayout();
            grpGender.SuspendLayout();
            pnlAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).BeginInit();
            cxmProfilePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errUniqueNationalNo).BeginInit();
            SuspendLayout();
            // 
            // pnlName
            // 
            pnlName.BackColor = Color.FromArgb(31, 41, 55);
            pnlName.Controls.Add(txtThirdName);
            pnlName.Controls.Add(txtLastName);
            pnlName.Controls.Add(txtSecondName);
            pnlName.Controls.Add(txtFirstName);
            pnlName.Controls.Add(uiLabel3);
            pnlName.Controls.Add(uiLabel2);
            pnlName.Controls.Add(uiLabel1);
            pnlName.Controls.Add(lblFirstName);
            pnlName.Controls.Add(lblName);
            pnlName.FillColor = Color.FromArgb(47, 59, 73);
            pnlName.Font = new Font("Microsoft Sans Serif", 12F);
            pnlName.Location = new Point(13, 14);
            pnlName.Margin = new Padding(4, 5, 4, 5);
            pnlName.MinimumSize = new Size(1, 1);
            pnlName.Name = "pnlName";
            pnlName.RectColor = Color.FromArgb(31, 41, 55);
            pnlName.Size = new Size(503, 88);
            pnlName.TabIndex = 0;
            pnlName.Text = null;
            pnlName.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtThirdName
            // 
            txtThirdName.FillColor = Color.FromArgb(55, 65, 81);
            txtThirdName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThirdName.ForeColor = Color.White;
            txtThirdName.Location = new Point(241, 51);
            txtThirdName.Margin = new Padding(4, 5, 4, 5);
            txtThirdName.MinimumSize = new Size(1, 16);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Padding = new Padding(5);
            txtThirdName.RectColor = Color.FromArgb(47, 59, 73);
            txtThirdName.ShowText = false;
            txtThirdName.Size = new Size(91, 24);
            txtThirdName.TabIndex = 2;
            txtThirdName.TextAlignment = ContentAlignment.MiddleLeft;
            txtThirdName.Watermark = "";
            // 
            // txtLastName
            // 
            txtLastName.FillColor = Color.FromArgb(55, 65, 81);
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F);
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(393, 51);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.MinimumSize = new Size(1, 16);
            txtLastName.Name = "txtLastName";
            txtLastName.Padding = new Padding(5);
            txtLastName.RectColor = Color.FromArgb(47, 59, 73);
            txtLastName.ShowText = false;
            txtLastName.Size = new Size(91, 24);
            txtLastName.TabIndex = 3;
            txtLastName.TextAlignment = ContentAlignment.MiddleLeft;
            txtLastName.Watermark = "";
            txtLastName.Validating += RequiredField_Validating;
            // 
            // txtSecondName
            // 
            txtSecondName.FillColor = Color.FromArgb(55, 65, 81);
            txtSecondName.Font = new Font("Microsoft Sans Serif", 12F);
            txtSecondName.ForeColor = Color.White;
            txtSecondName.Location = new Point(126, 51);
            txtSecondName.Margin = new Padding(4, 5, 4, 5);
            txtSecondName.MinimumSize = new Size(1, 16);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Padding = new Padding(5);
            txtSecondName.RectColor = Color.FromArgb(47, 59, 73);
            txtSecondName.ShowText = false;
            txtSecondName.Size = new Size(80, 24);
            txtSecondName.TabIndex = 1;
            txtSecondName.TextAlignment = ContentAlignment.MiddleLeft;
            txtSecondName.Watermark = "";
            txtSecondName.Validating += RequiredField_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.FillColor = Color.FromArgb(55, 65, 81);
            txtFirstName.Font = new Font("Microsoft Sans Serif", 12F);
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(18, 51);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.MinimumSize = new Size(1, 16);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Padding = new Padding(5);
            txtFirstName.RectColor = Color.FromArgb(47, 59, 73);
            txtFirstName.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtFirstName.ScrollBarStyleInherited = false;
            txtFirstName.ShowText = false;
            txtFirstName.Size = new Size(91, 24);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextAlignment = ContentAlignment.MiddleLeft;
            txtFirstName.Watermark = "";
            txtFirstName.Validating += RequiredField_Validating;
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.FromArgb(47, 59, 73);
            uiLabel3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.White;
            uiLabel3.Location = new Point(393, 23);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(91, 23);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "Last";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.FromArgb(47, 59, 73);
            uiLabel2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.White;
            uiLabel2.Location = new Point(241, 23);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(48, 23);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "Third";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.FromArgb(47, 59, 73);
            uiLabel1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(126, 23);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(60, 23);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "Second";
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.FromArgb(47, 59, 73);
            lblFirstName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(18, 23);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(42, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First";
            // 
            // lblName
            // 
            lblName.BackColor = Color.FromArgb(47, 59, 73);
            lblName.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(169, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name Information";
            // 
            // pnlPersonalInfo
            // 
            pnlPersonalInfo.BackColor = Color.FromArgb(47, 59, 73);
            pnlPersonalInfo.Controls.Add(grpGender);
            pnlPersonalInfo.Controls.Add(timeDateOfBirth);
            pnlPersonalInfo.Controls.Add(cmbCountry);
            pnlPersonalInfo.Controls.Add(lblCountry);
            pnlPersonalInfo.Controls.Add(lblDateOfBirth);
            pnlPersonalInfo.Controls.Add(txtEmail);
            pnlPersonalInfo.Controls.Add(lblEmail);
            pnlPersonalInfo.Controls.Add(txtPhone);
            pnlPersonalInfo.Controls.Add(lblPhone);
            pnlPersonalInfo.Controls.Add(uiLabel4);
            pnlPersonalInfo.Controls.Add(txtNationalNo);
            pnlPersonalInfo.Controls.Add(lblPersonalInfo);
            pnlPersonalInfo.FillColor = Color.FromArgb(47, 59, 73);
            pnlPersonalInfo.Font = new Font("Microsoft Sans Serif", 12F);
            pnlPersonalInfo.Location = new Point(13, 112);
            pnlPersonalInfo.Margin = new Padding(4, 5, 4, 5);
            pnlPersonalInfo.MinimumSize = new Size(1, 1);
            pnlPersonalInfo.Name = "pnlPersonalInfo";
            pnlPersonalInfo.RectColor = Color.FromArgb(31, 41, 55);
            pnlPersonalInfo.Size = new Size(503, 150);
            pnlPersonalInfo.TabIndex = 1;
            pnlPersonalInfo.Text = null;
            pnlPersonalInfo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbFemale);
            grpGender.Controls.Add(rbMale);
            grpGender.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpGender.ForeColor = Color.White;
            grpGender.Location = new Point(334, 32);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(166, 53);
            grpGender.TabIndex = 18;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            grpGender.Paint += grpGender_Paint;
            // 
            // rbFemale
            // 
            rbFemale.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.ForeColor = Color.White;
            rbFemale.Location = new Point(82, 22);
            rbFemale.MinimumSize = new Size(1, 1);
            rbFemale.Name = "rbFemale";
            rbFemale.RadioButtonColor = Color.FromArgb(249, 115, 22);
            rbFemale.Size = new Size(104, 29);
            rbFemale.TabIndex = 11;
            rbFemale.Text = "Female";
            rbFemale.CheckedChanged += rbGender_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.Checked = true;
            rbMale.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.ForeColor = Color.White;
            rbMale.Location = new Point(0, 22);
            rbMale.MinimumSize = new Size(1, 1);
            rbMale.Name = "rbMale";
            rbMale.RadioButtonColor = Color.FromArgb(249, 115, 22);
            rbMale.Size = new Size(104, 29);
            rbMale.TabIndex = 10;
            rbMale.Text = "Male";
            rbMale.CheckedChanged += rbGender_CheckedChanged;
            // 
            // timeDateOfBirth
            // 
            timeDateOfBirth.CalendarForeColor = Color.White;
            timeDateOfBirth.CalendarMonthBackground = SystemColors.MenuHighlight;
            timeDateOfBirth.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            timeDateOfBirth.CalendarTrailingForeColor = Color.GreenYellow;
            timeDateOfBirth.Location = new Point(198, 59);
            timeDateOfBirth.Name = "timeDateOfBirth";
            timeDateOfBirth.Size = new Size(120, 26);
            timeDateOfBirth.TabIndex = 8;
            // 
            // cmbCountry
            // 
            cmbCountry.DataSource = null;
            cmbCountry.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbCountry.FillColor = Color.FromArgb(47, 59, 73);
            cmbCountry.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCountry.ForeColor = Color.White;
            cmbCountry.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbCountry.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbCountry.Location = new Point(334, 116);
            cmbCountry.Margin = new Padding(4, 5, 4, 5);
            cmbCountry.MinimumSize = new Size(63, 0);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Padding = new Padding(0, 0, 30, 2);
            cmbCountry.RectColor = Color.White;
            cmbCountry.Size = new Size(150, 24);
            cmbCountry.SymbolSize = 24;
            cmbCountry.TabIndex = 9;
            cmbCountry.TextAlignment = ContentAlignment.MiddleLeft;
            cmbCountry.Watermark = "";
            // 
            // lblCountry
            // 
            lblCountry.BackColor = Color.FromArgb(47, 59, 73);
            lblCountry.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountry.ForeColor = Color.White;
            lblCountry.Location = new Point(330, 88);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(104, 23);
            lblCountry.TabIndex = 15;
            lblCountry.Text = "Country";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.BackColor = Color.FromArgb(47, 59, 73);
            lblDateOfBirth.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(198, 32);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(104, 23);
            lblDateOfBirth.TabIndex = 10;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // txtEmail
            // 
            txtEmail.FillColor = Color.FromArgb(55, 65, 81);
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(198, 116);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.RectColor = Color.FromArgb(47, 59, 73);
            txtEmail.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtEmail.ScrollBarStyleInherited = false;
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(120, 24);
            txtEmail.TabIndex = 6;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            txtEmail.Validating += txtEmail_Validating;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.FromArgb(47, 59, 73);
            lblEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(198, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(104, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.FillColor = Color.FromArgb(55, 65, 81);
            txtPhone.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(18, 116);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.MinimumSize = new Size(1, 16);
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(5);
            txtPhone.RectColor = Color.FromArgb(47, 59, 73);
            txtPhone.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtPhone.ScrollBarStyleInherited = false;
            txtPhone.ShowText = false;
            txtPhone.Size = new Size(139, 24);
            txtPhone.TabIndex = 5;
            txtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            txtPhone.Watermark = "";
            txtPhone.Validating += RequiredField_Validating;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.FromArgb(47, 59, 73);
            lblPhone.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(18, 88);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(104, 23);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.FromArgb(47, 59, 73);
            uiLabel4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.White;
            uiLabel4.Location = new Point(18, 32);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(104, 23);
            uiLabel4.TabIndex = 7;
            uiLabel4.Text = "National No.";
            // 
            // txtNationalNo
            // 
            txtNationalNo.FillColor = Color.FromArgb(55, 65, 81);
            txtNationalNo.Font = new Font("Microsoft Sans Serif", 12F);
            txtNationalNo.ForeColor = Color.White;
            txtNationalNo.Location = new Point(18, 59);
            txtNationalNo.Margin = new Padding(4, 5, 4, 5);
            txtNationalNo.MinimumSize = new Size(1, 16);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Padding = new Padding(5);
            txtNationalNo.RectColor = Color.FromArgb(47, 59, 73);
            txtNationalNo.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtNationalNo.ScrollBarStyleInherited = false;
            txtNationalNo.ShowText = false;
            txtNationalNo.Size = new Size(139, 24);
            txtNationalNo.TabIndex = 4;
            txtNationalNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtNationalNo.Watermark = "";
            txtNationalNo.Validating += txtNationalNo_Validating;
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonalInfo.ForeColor = Color.White;
            lblPersonalInfo.Location = new Point(-1, 0);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(187, 23);
            lblPersonalInfo.TabIndex = 1;
            lblPersonalInfo.Text = "Personal Information";
            // 
            // pnlAddress
            // 
            pnlAddress.BackColor = Color.FromArgb(31, 41, 55);
            pnlAddress.Controls.Add(txtAddress);
            pnlAddress.Controls.Add(lblAddress);
            pnlAddress.FillColor = Color.FromArgb(47, 59, 73);
            pnlAddress.Font = new Font("Microsoft Sans Serif", 12F);
            pnlAddress.Location = new Point(12, 272);
            pnlAddress.Margin = new Padding(4, 5, 4, 5);
            pnlAddress.MinimumSize = new Size(1, 1);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.RectColor = Color.FromArgb(31, 41, 55);
            pnlAddress.Size = new Size(503, 66);
            pnlAddress.TabIndex = 1;
            pnlAddress.Text = null;
            pnlAddress.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(47, 59, 73);
            txtAddress.FillColor = Color.FromArgb(47, 59, 73);
            txtAddress.FillDisableColor = Color.White;
            txtAddress.Font = new Font("Microsoft Sans Serif", 12F);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(19, 28);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.MinimumSize = new Size(1, 16);
            txtAddress.Name = "txtAddress";
            txtAddress.Padding = new Padding(5);
            txtAddress.RectColor = Color.White;
            txtAddress.ShowText = false;
            txtAddress.Size = new Size(466, 29);
            txtAddress.TabIndex = 7;
            txtAddress.TextAlignment = ContentAlignment.MiddleLeft;
            txtAddress.Watermark = "";
            txtAddress.Validating += RequiredField_Validating;
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.FromArgb(47, 59, 73);
            lblAddress.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(3, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(187, 23);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(571, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 37);
            btnSave.TabIndex = 12;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pbProfilePicture
            // 
            pbProfilePicture.ContextMenuStrip = cxmProfilePicture;
            pbProfilePicture.Image = Properties.Resources.male;
            pbProfilePicture.Location = new Point(553, 12);
            pbProfilePicture.Name = "pbProfilePicture";
            pbProfilePicture.Size = new Size(181, 203);
            pbProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfilePicture.TabIndex = 6;
            pbProfilePicture.TabStop = false;
            pbProfilePicture.Click += pbProfilePicture_Click;
            // 
            // cxmProfilePicture
            // 
            cxmProfilePicture.Items.AddRange(new ToolStripItem[] { tsmRemovePicture, tsmAddPicture });
            cxmProfilePicture.Name = "contextMenuStrip1";
            cxmProfilePicture.Size = new Size(161, 48);
            // 
            // tsmRemovePicture
            // 
            tsmRemovePicture.BackColor = Color.FromArgb(31, 41, 55);
            tsmRemovePicture.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsmRemovePicture.ForeColor = Color.White;
            tsmRemovePicture.Name = "tsmRemovePicture";
            tsmRemovePicture.Size = new Size(160, 22);
            tsmRemovePicture.Text = "Remove Picture";
            tsmRemovePicture.Click += tsmRemovePicture_Click;
            // 
            // tsmAddPicture
            // 
            tsmAddPicture.BackColor = Color.FromArgb(31, 41, 55);
            tsmAddPicture.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsmAddPicture.ForeColor = Color.White;
            tsmAddPicture.Name = "tsmAddPicture";
            tsmAddPicture.Size = new Size(160, 22);
            tsmAddPicture.Text = "Add Picture";
            tsmAddPicture.Click += pbProfilePicture_Click;
            // 
            // errUniqueNationalNo
            // 
            errUniqueNationalNo.ContainerControl = this;
            // 
            // frmAddUpdatePerson
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 56);
            ClientSize = new Size(757, 352);
            Controls.Add(pbProfilePicture);
            Controls.Add(btnSave);
            Controls.Add(pnlAddress);
            Controls.Add(pnlPersonalInfo);
            Controls.Add(pnlName);
            Name = "frmAddUpdatePerson";
            Text = "frmAddUpdatePerson";
            Load += frmAddUpdatePerson_Load;
            Validating += RequiredField_Validating;
            pnlName.ResumeLayout(false);
            pnlPersonalInfo.ResumeLayout(false);
            grpGender.ResumeLayout(false);
            pnlAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).EndInit();
            cxmProfilePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errUniqueNationalNo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pnlName;
        private Sunny.UI.UIPanel pnlPersonalInfo;
        private Sunny.UI.UIPanel pnlAddress;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UILabel lblPersonalInfo;
        private Sunny.UI.UILabel lblAddress;
        private Sunny.UI.UITextBox txtFirstName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lblFirstName;
        private Sunny.UI.UITextBox txtThirdName;
        private Sunny.UI.UITextBox txtLastName;
        private Sunny.UI.UITextBox txtSecondName;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UITextBox txtPhone;
        private Sunny.UI.UILabel lblPhone;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtNationalNo;
        private Sunny.UI.UIRadioButton rbMale;
        private Sunny.UI.UILabel lblDateOfBirth;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UIComboBox cmbCountry;
        private Sunny.UI.UILabel lblCountry;
        private Sunny.UI.UIRadioButton rbFemale;
        private Button btnSave;
        private PictureBox pbProfilePicture;
        private DateTimePicker timeDateOfBirth;
        private Sunny.UI.UITextBox txtAddress;
        private ContextMenuStrip cxmProfilePicture;
        private ToolStripMenuItem tsmRemovePicture;
        private ToolStripMenuItem tsmAddPicture;
        private GroupBox grpGender;
        private ErrorProvider errUniqueNationalNo;
    }
}