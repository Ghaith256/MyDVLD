namespace DVLD_Presentation {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openPeople = new Button();
            btnUsersManagement = new Button();
            btnOpenUserUpdate = new Button();
            btnLogin = new Button();
            btnMainMenu = new Button();
            btnManageApplicationTypes = new Button();
            btnTestTypes = new Button();
            btnManageLocal = new Button();
            btnManageLocalApplications = new Button();
            btnAddInternationalLicense = new Button();
            btnRenewLicense = new Button();
            btnLicenseReplacement = new Button();
            SuspendLayout();
            // 
            // openPeople
            // 
            openPeople.Location = new Point(308, 254);
            openPeople.Name = "openPeople";
            openPeople.Size = new Size(127, 49);
            openPeople.TabIndex = 0;
            openPeople.Text = "Open People Management";
            openPeople.UseVisualStyleBackColor = true;
            openPeople.Click += openPeople_Click;
            // 
            // btnUsersManagement
            // 
            btnUsersManagement.Location = new Point(308, 97);
            btnUsersManagement.Name = "btnUsersManagement";
            btnUsersManagement.Size = new Size(127, 49);
            btnUsersManagement.TabIndex = 1;
            btnUsersManagement.Text = "Open Users Management";
            btnUsersManagement.UseVisualStyleBackColor = true;
            btnUsersManagement.Click += btnUsersManagement_Click;
            // 
            // btnOpenUserUpdate
            // 
            btnOpenUserUpdate.Location = new Point(589, 97);
            btnOpenUserUpdate.Name = "btnOpenUserUpdate";
            btnOpenUserUpdate.Size = new Size(98, 51);
            btnOpenUserUpdate.TabIndex = 2;
            btnOpenUserUpdate.Text = "User Update";
            btnOpenUserUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(589, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 51);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(99, 253);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(127, 49);
            btnMainMenu.TabIndex = 4;
            btnMainMenu.Text = "Open Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnManageApplicationTypes
            // 
            btnManageApplicationTypes.Location = new Point(99, 99);
            btnManageApplicationTypes.Name = "btnManageApplicationTypes";
            btnManageApplicationTypes.Size = new Size(127, 49);
            btnManageApplicationTypes.TabIndex = 5;
            btnManageApplicationTypes.Text = "Application Types";
            btnManageApplicationTypes.UseVisualStyleBackColor = true;
            btnManageApplicationTypes.Click += btnManageApplicationTypes_Click;
            // 
            // btnTestTypes
            // 
            btnTestTypes.Location = new Point(99, 12);
            btnTestTypes.Name = "btnTestTypes";
            btnTestTypes.Size = new Size(127, 49);
            btnTestTypes.TabIndex = 6;
            btnTestTypes.Text = "Test Types";
            btnTestTypes.UseVisualStyleBackColor = true;
            btnTestTypes.Click += btnTestTypes_Click;
            // 
            // btnManageLocal
            // 
            btnManageLocal.Location = new Point(308, 12);
            btnManageLocal.Name = "btnManageLocal";
            btnManageLocal.Size = new Size(127, 49);
            btnManageLocal.TabIndex = 7;
            btnManageLocal.Text = "Local Application";
            btnManageLocal.UseVisualStyleBackColor = true;
            btnManageLocal.Click += btnManageLocal_Click;
            // 
            // btnManageLocalApplications
            // 
            btnManageLocalApplications.Location = new Point(560, 12);
            btnManageLocalApplications.Name = "btnManageLocalApplications";
            btnManageLocalApplications.Size = new Size(127, 49);
            btnManageLocalApplications.TabIndex = 8;
            btnManageLocalApplications.Text = "Manage Local Applications";
            btnManageLocalApplications.UseVisualStyleBackColor = true;
            btnManageLocalApplications.Click += btnManageLocalApplications_Click;
            // 
            // btnAddInternationalLicense
            // 
            btnAddInternationalLicense.Location = new Point(99, 334);
            btnAddInternationalLicense.Name = "btnAddInternationalLicense";
            btnAddInternationalLicense.Size = new Size(127, 49);
            btnAddInternationalLicense.TabIndex = 9;
            btnAddInternationalLicense.Text = "Add International";
            btnAddInternationalLicense.UseVisualStyleBackColor = true;
            btnAddInternationalLicense.Click += btnAddInternationalLicense_Click;
            // 
            // btnRenewLicense
            // 
            btnRenewLicense.Location = new Point(308, 334);
            btnRenewLicense.Name = "btnRenewLicense";
            btnRenewLicense.Size = new Size(127, 49);
            btnRenewLicense.TabIndex = 10;
            btnRenewLicense.Text = "Renew License";
            btnRenewLicense.UseVisualStyleBackColor = true;
            btnRenewLicense.Click += btnRenewLicense_Click;
            // 
            // btnLicenseReplacement
            // 
            btnLicenseReplacement.Location = new Point(560, 334);
            btnLicenseReplacement.Name = "btnLicenseReplacement";
            btnLicenseReplacement.Size = new Size(127, 49);
            btnLicenseReplacement.TabIndex = 11;
            btnLicenseReplacement.Text = "License Replacement";
            btnLicenseReplacement.UseVisualStyleBackColor = true;
            btnLicenseReplacement.Click += btnLicenseReplacement_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLicenseReplacement);
            Controls.Add(btnRenewLicense);
            Controls.Add(btnAddInternationalLicense);
            Controls.Add(btnManageLocalApplications);
            Controls.Add(btnManageLocal);
            Controls.Add(btnTestTypes);
            Controls.Add(btnManageApplicationTypes);
            Controls.Add(btnMainMenu);
            Controls.Add(btnLogin);
            Controls.Add(btnOpenUserUpdate);
            Controls.Add(btnUsersManagement);
            Controls.Add(openPeople);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button openPeople;
        private Button btnUsersManagement;
        private Button btnOpenUserUpdate;
        private Button btnLogin;
        private Button btnMainMenu;
        private Button btnManageApplicationTypes;
        private Button btnTestTypes;
        private Button btnManageLocal;
        private Button btnManageLocalApplications;
        private Button btnAddInternationalLicense;
        private Button btnRenewLicense;
        private Button btnLicenseReplacement;
    }
}
