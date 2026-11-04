namespace DVLD_Presentation
{
    partial class frmMainMenu
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
            pnlCurrentUser = new Panel();
            lblCurrentUser = new Label();
            pnlSeparator = new Panel();
            iconLogOut = new FontAwesome.Sharp.IconPictureBox();
            lblTitle = new Label();
            iconMainMenu = new FontAwesome.Sharp.IconPictureBox();
            lblWelcome = new Label();
            lblWelcomeUser = new Label();
            pnlUsers = new Panel();
            lblUsers = new Label();
            iconPeople = new FontAwesome.Sharp.IconPictureBox();
            pnlDrivers = new Panel();
            lblDrivers = new Label();
            iconDrivers = new FontAwesome.Sharp.IconPictureBox();
            pnlApplications = new Panel();
            lblApplications = new Label();
            iconApplications = new FontAwesome.Sharp.IconPictureBox();
            pnlPeople = new Panel();
            lblPeople = new Label();
            iconUsers = new FontAwesome.Sharp.IconPictureBox();
            cxmUserMenu = new ContextMenuStrip(components);
            toolCurrentUserInfo = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            pnlCurrentUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMainMenu).BeginInit();
            pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPeople).BeginInit();
            pnlDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDrivers).BeginInit();
            pnlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconApplications).BeginInit();
            pnlPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsers).BeginInit();
            cxmUserMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCurrentUser
            // 
            pnlCurrentUser.BackColor = Color.FromArgb(12, 22, 50);
            pnlCurrentUser.Controls.Add(lblCurrentUser);
            pnlCurrentUser.Controls.Add(pnlSeparator);
            pnlCurrentUser.Controls.Add(iconLogOut);
            pnlCurrentUser.Controls.Add(lblTitle);
            pnlCurrentUser.Controls.Add(iconMainMenu);
            pnlCurrentUser.Location = new Point(0, 1);
            pnlCurrentUser.Name = "pnlCurrentUser";
            pnlCurrentUser.Size = new Size(625, 42);
            pnlCurrentUser.TabIndex = 0;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Cursor = Cursors.Hand;
            lblCurrentUser.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(492, 9);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(47, 23);
            lblCurrentUser.TabIndex = 4;
            lblCurrentUser.Text = "User";
            lblCurrentUser.MouseEnter += lblCurrentUser_MouseEnter;
            lblCurrentUser.MouseLeave += lblCurrentUser_MouseLeave;
            // 
            // pnlSeparator
            // 
            pnlSeparator.Location = new Point(545, 8);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(2, 30);
            pnlSeparator.TabIndex = 3;
            pnlSeparator.Paint += pnlSeparator_Paint;
            // 
            // iconLogOut
            // 
            iconLogOut.BackColor = Color.FromArgb(12, 22, 50);
            iconLogOut.Cursor = Cursors.Hand;
            iconLogOut.ForeColor = Color.FromArgb(249, 115, 22);
            iconLogOut.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconLogOut.IconColor = Color.FromArgb(249, 115, 22);
            iconLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLogOut.IconSize = 31;
            iconLogOut.Location = new Point(567, 8);
            iconLogOut.Name = "iconLogOut";
            iconLogOut.Size = new Size(47, 31);
            iconLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            iconLogOut.TabIndex = 2;
            iconLogOut.TabStop = false;
            iconLogOut.Click += iconLogOut_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(60, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "DVLD Management System";
            // 
            // iconMainMenu
            // 
            iconMainMenu.BackColor = Color.FromArgb(12, 22, 50);
            iconMainMenu.ForeColor = Color.FromArgb(249, 115, 22);
            iconMainMenu.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            iconMainMenu.IconColor = Color.FromArgb(249, 115, 22);
            iconMainMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMainMenu.IconSize = 31;
            iconMainMenu.Location = new Point(3, 8);
            iconMainMenu.Name = "iconMainMenu";
            iconMainMenu.Size = new Size(51, 31);
            iconMainMenu.SizeMode = PictureBoxSizeMode.Zoom;
            iconMainMenu.TabIndex = 0;
            iconMainMenu.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(26, 58);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(143, 23);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome Back, ";
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeUser.ForeColor = Color.White;
            lblWelcomeUser.Location = new Point(157, 58);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(47, 23);
            lblWelcomeUser.TabIndex = 5;
            lblWelcomeUser.Text = "User";
            lblWelcomeUser.Click += lblWelcomeUser_Click;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.FromArgb(12, 22, 50);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Controls.Add(iconPeople);
            pnlUsers.Cursor = Cursors.Hand;
            pnlUsers.Location = new Point(29, 213);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(246, 69);
            pnlUsers.TabIndex = 7;
            pnlUsers.Click += pnlUsers_Click;
            pnlUsers.MouseEnter += panel_MouseEnter;
            pnlUsers.MouseLeave += panel_MouseLeave;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsers.ForeColor = Color.White;
            lblUsers.Location = new Point(76, 22);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(71, 25);
            lblUsers.TabIndex = 6;
            lblUsers.Text = "Users";
            lblUsers.Click += pnlUsers_Click;
            lblUsers.MouseEnter += panel_MouseEnter;
            lblUsers.MouseLeave += panel_MouseLeave;
            // 
            // iconPeople
            // 
            iconPeople.BackColor = Color.FromArgb(12, 22, 50);
            iconPeople.Enabled = false;
            iconPeople.ForeColor = Color.FromArgb(249, 115, 22);
            iconPeople.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPeople.IconColor = Color.FromArgb(249, 115, 22);
            iconPeople.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPeople.IconSize = 53;
            iconPeople.Location = new Point(3, 3);
            iconPeople.Name = "iconPeople";
            iconPeople.Size = new Size(53, 63);
            iconPeople.SizeMode = PictureBoxSizeMode.Zoom;
            iconPeople.TabIndex = 1;
            iconPeople.TabStop = false;
            iconPeople.Click += pnlUsers_Click;
            iconPeople.MouseEnter += panel_MouseEnter;
            iconPeople.MouseLeave += panel_MouseLeave;
            // 
            // pnlDrivers
            // 
            pnlDrivers.BackColor = Color.FromArgb(12, 22, 50);
            pnlDrivers.Controls.Add(lblDrivers);
            pnlDrivers.Controls.Add(iconDrivers);
            pnlDrivers.Cursor = Cursors.Hand;
            pnlDrivers.Location = new Point(349, 113);
            pnlDrivers.Name = "pnlDrivers";
            pnlDrivers.Size = new Size(246, 69);
            pnlDrivers.TabIndex = 7;
            pnlDrivers.Click += pnlDrivers_Click;
            pnlDrivers.MouseEnter += panel_MouseEnter;
            pnlDrivers.MouseLeave += panel_MouseLeave;
            // 
            // lblDrivers
            // 
            lblDrivers.AutoSize = true;
            lblDrivers.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrivers.ForeColor = Color.White;
            lblDrivers.Location = new Point(71, 20);
            lblDrivers.Name = "lblDrivers";
            lblDrivers.Size = new Size(87, 25);
            lblDrivers.TabIndex = 7;
            lblDrivers.Text = "Drivers";
            lblDrivers.Click += pnlDrivers_Click;
            lblDrivers.MouseEnter += panel_MouseEnter;
            lblDrivers.MouseLeave += panel_MouseLeave;
            // 
            // iconDrivers
            // 
            iconDrivers.BackColor = Color.FromArgb(12, 22, 50);
            iconDrivers.Enabled = false;
            iconDrivers.ForeColor = Color.FromArgb(249, 115, 22);
            iconDrivers.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            iconDrivers.IconColor = Color.FromArgb(249, 115, 22);
            iconDrivers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDrivers.IconSize = 53;
            iconDrivers.Location = new Point(3, 3);
            iconDrivers.Name = "iconDrivers";
            iconDrivers.Size = new Size(53, 63);
            iconDrivers.SizeMode = PictureBoxSizeMode.Zoom;
            iconDrivers.TabIndex = 1;
            iconDrivers.TabStop = false;
            iconDrivers.Click += pnlDrivers_Click;
            iconDrivers.MouseEnter += panel_MouseEnter;
            iconDrivers.MouseLeave += panel_MouseLeave;
            // 
            // pnlApplications
            // 
            pnlApplications.BackColor = Color.FromArgb(12, 22, 50);
            pnlApplications.Controls.Add(lblApplications);
            pnlApplications.Controls.Add(iconApplications);
            pnlApplications.Cursor = Cursors.Hand;
            pnlApplications.Location = new Point(26, 113);
            pnlApplications.Name = "pnlApplications";
            pnlApplications.Size = new Size(246, 69);
            pnlApplications.TabIndex = 8;
            pnlApplications.Click += pnlApplications_Click;
            pnlApplications.MouseEnter += panel_MouseEnter;
            pnlApplications.MouseLeave += panel_MouseLeave;
            // 
            // lblApplications
            // 
            lblApplications.AutoSize = true;
            lblApplications.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplications.ForeColor = Color.White;
            lblApplications.Location = new Point(62, 24);
            lblApplications.Name = "lblApplications";
            lblApplications.Size = new Size(116, 21);
            lblApplications.TabIndex = 5;
            lblApplications.Text = "Applications";
            lblApplications.Click += pnlApplications_Click;
            lblApplications.MouseEnter += panel_MouseEnter;
            lblApplications.MouseLeave += panel_MouseLeave;
            // 
            // iconApplications
            // 
            iconApplications.BackColor = Color.FromArgb(12, 22, 50);
            iconApplications.Enabled = false;
            iconApplications.ForeColor = Color.FromArgb(249, 115, 22);
            iconApplications.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            iconApplications.IconColor = Color.FromArgb(249, 115, 22);
            iconApplications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconApplications.IconSize = 53;
            iconApplications.Location = new Point(3, 3);
            iconApplications.Name = "iconApplications";
            iconApplications.Size = new Size(53, 63);
            iconApplications.SizeMode = PictureBoxSizeMode.Zoom;
            iconApplications.TabIndex = 0;
            iconApplications.TabStop = false;
            iconApplications.Click += pnlApplications_Click;
            iconApplications.MouseEnter += panel_MouseEnter;
            iconApplications.MouseLeave += panel_MouseLeave;
            // 
            // pnlPeople
            // 
            pnlPeople.BackColor = Color.FromArgb(12, 22, 50);
            pnlPeople.Controls.Add(lblPeople);
            pnlPeople.Controls.Add(iconUsers);
            pnlPeople.Cursor = Cursors.Hand;
            pnlPeople.Location = new Point(352, 213);
            pnlPeople.Name = "pnlPeople";
            pnlPeople.Size = new Size(246, 69);
            pnlPeople.TabIndex = 8;
            pnlPeople.Click += pnlPeople_Click;
            pnlPeople.MouseEnter += panel_MouseEnter;
            pnlPeople.MouseLeave += panel_MouseLeave;
            // 
            // lblPeople
            // 
            lblPeople.AutoSize = true;
            lblPeople.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeople.ForeColor = Color.White;
            lblPeople.Location = new Point(71, 22);
            lblPeople.Name = "lblPeople";
            lblPeople.Size = new Size(82, 25);
            lblPeople.TabIndex = 7;
            lblPeople.Text = "People";
            lblPeople.Click += pnlPeople_Click;
            lblPeople.MouseEnter += panel_MouseEnter;
            lblPeople.MouseLeave += panel_MouseLeave;
            // 
            // iconUsers
            // 
            iconUsers.BackColor = Color.FromArgb(12, 22, 50);
            iconUsers.Enabled = false;
            iconUsers.ForeColor = Color.FromArgb(249, 115, 22);
            iconUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconUsers.IconColor = Color.FromArgb(249, 115, 22);
            iconUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsers.IconSize = 53;
            iconUsers.Location = new Point(3, 3);
            iconUsers.Name = "iconUsers";
            iconUsers.Size = new Size(53, 63);
            iconUsers.SizeMode = PictureBoxSizeMode.Zoom;
            iconUsers.TabIndex = 2;
            iconUsers.TabStop = false;
            iconUsers.Click += pnlPeople_Click;
            iconUsers.MouseEnter += panel_MouseEnter;
            iconUsers.MouseLeave += panel_MouseLeave;
            // 
            // cxmUserMenu
            // 
            cxmUserMenu.BackColor = Color.FromArgb(0, 15, 33);
            cxmUserMenu.Items.AddRange(new ToolStripItem[] { toolCurrentUserInfo, changePasswordToolStripMenuItem });
            cxmUserMenu.Name = "cxmUserMenu";
            cxmUserMenu.Size = new Size(184, 48);
            // 
            // toolCurrentUserInfo
            // 
            toolCurrentUserInfo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolCurrentUserInfo.ForeColor = Color.White;
            toolCurrentUserInfo.Name = "toolCurrentUserInfo";
            toolCurrentUserInfo.Size = new Size(183, 22);
            toolCurrentUserInfo.Text = "Current User Info";
            toolCurrentUserInfo.Click += toolCurrentUserInfo_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changePasswordToolStripMenuItem.ForeColor = Color.White;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(183, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(626, 326);
            Controls.Add(pnlPeople);
            Controls.Add(pnlApplications);
            Controls.Add(pnlDrivers);
            Controls.Add(pnlUsers);
            Controls.Add(lblWelcomeUser);
            Controls.Add(lblWelcome);
            Controls.Add(pnlCurrentUser);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMainMenu";
            Text = "frmMainMenu";
            pnlCurrentUser.ResumeLayout(false);
            pnlCurrentUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMainMenu).EndInit();
            pnlUsers.ResumeLayout(false);
            pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPeople).EndInit();
            pnlDrivers.ResumeLayout(false);
            pnlDrivers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconDrivers).EndInit();
            pnlApplications.ResumeLayout(false);
            pnlApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconApplications).EndInit();
            pnlPeople.ResumeLayout(false);
            pnlPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsers).EndInit();
            cxmUserMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCurrentUser;
        private FontAwesome.Sharp.IconPictureBox iconMainMenu;
        private Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox iconLogOut;
        private Label lblWelcome;
        private Label lblWelcomeUser;
        private Panel pnlUsers;
        private Panel pnlDrivers;
        private Panel pnlApplications;
        private Panel pnlPeople;
        private FontAwesome.Sharp.IconPictureBox iconPeople;
        private FontAwesome.Sharp.IconPictureBox iconDrivers;
        private FontAwesome.Sharp.IconPictureBox iconApplications;
        private FontAwesome.Sharp.IconPictureBox iconUsers;
        private Label lblUsers;
        private Label lblDrivers;
        private Label lblApplications;
        private Label lblPeople;
        private Label lblCurrentUser;
        private Panel pnlSeparator;
        private ContextMenuStrip cxmUserMenu;
        private ToolStripMenuItem toolCurrentUserInfo;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}