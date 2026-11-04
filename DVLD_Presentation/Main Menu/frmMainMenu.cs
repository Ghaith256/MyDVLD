using DVLD_Presentation.Drivers;
using DVLD_Presentation.Main_Menu;
using DVLD_Presentation.People;
using DVLD_Presentation.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            _SetupPanelHoverEvents(this);

            if (clsGlobal.CurrentUser != null)
            {
                string? currentUsername = clsGlobal.CurrentUser.Username; 
                lblWelcomeUser.Text = currentUsername;
                lblCurrentUser.Text = currentUsername;
            }
        }

        private void _SetupPanelHoverEvents(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Panel pnl && pnl != pnlSeparator && pnl != pnlCurrentUser)
                {
                    pnl.BackColor = Color.FromArgb(12, 22, 50);
                    clsFormatHelper.SetControlsColor(pnl, textColor: Color.White, iconColor: Color.FromArgb(249, 115, 22));

                    pnl.MouseEnter += panel_MouseEnter;
                    pnl.MouseLeave += panel_MouseLeave;

                    foreach (Control child in pnl.Controls)
                    {
                        child.BackColor = Color.Transparent;
                        child.MouseEnter += panel_MouseEnter;
                        child.MouseLeave += panel_MouseLeave;
                    }
                }
                else if (ctrl.HasChildren)
                {
                    _SetupPanelHoverEvents(ctrl);
                }
            }
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            Panel? pnl = sender as Panel ?? (sender as Control)?.Parent as Panel;

            if (pnl != null)
            {
                pnl.BackColor = Color.FromArgb(249, 115, 22);
                clsFormatHelper.SetControlsColor(pnl, textColor: Color.White, iconColor: Color.White);
            }
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            Panel? pnl = sender as Panel ?? (sender as Control)?.Parent as Panel;

            if (pnl != null)
            {
                if (pnl.ClientRectangle.Contains(pnl.PointToClient(Cursor.Position)))
                    return;

                pnl.BackColor = Color.FromArgb(12, 22, 50);
                clsFormatHelper.SetControlsColor(pnl, textColor: Color.White, iconColor: Color.FromArgb(249, 115, 22));
            }
        }

        private void pnlSeparator_Paint(object sender, PaintEventArgs e)
        {
            _DrawVerticalSeparator((Panel)sender, e);
        }

        private void pnlCurrentUser_Paint(object sender, PaintEventArgs e)
        {
            _DrawVerticalSeparator((Panel)sender, e);
        }

        private void _DrawVerticalSeparator(Panel pnl, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Color transparent = Color.Transparent;
            Color lineColor = ColorTranslator.FromHtml("#4B5563");

            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    pnl.ClientRectangle,
                    transparent,
                    transparent,
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                System.Drawing.Drawing2D.ColorBlend colorBlend = new System.Drawing.Drawing2D.ColorBlend(3);
                colorBlend.Colors = new Color[] { transparent, lineColor, transparent };
                colorBlend.Positions = new float[] { 0.0f, 0.5f, 1.0f };

                brush.InterpolationColors = colorBlend;

                int centerX = pnl.Width / 2;
                using (Pen pen = new Pen(brush, 1.5f))
                {
                    e.Graphics.DrawLine(pen, centerX, 0, centerX, pnl.Height);
                }
            }
        }

        private void lblCurrentUser_MouseEnter(object sender, EventArgs e)
        {
            lblCurrentUser.ForeColor = Color.FromArgb(249, 115, 22);
            lblCurrentUser.Cursor = Cursors.Hand;

            if (!cxmUserMenu.Visible)
                cxmUserMenu.Show(lblCurrentUser, new Point(0, lblCurrentUser.Height));
        }

        private void lblCurrentUser_MouseLeave(object sender, EventArgs e)
        {
            lblCurrentUser.ForeColor = Color.White;
        }

        private void pnlUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void pnlPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void toolCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void pnlApplications_Click(object sender, EventArgs e)
        {
            frmApplicationsMainMenu frm = new frmApplicationsMainMenu();
            frm.ShowDialog();
        }

        private void pnlDrivers_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            frm.ShowDialog();
        }

        private void iconLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblWelcomeUser_Click(object sender, EventArgs e)
        {

        }
    }
}