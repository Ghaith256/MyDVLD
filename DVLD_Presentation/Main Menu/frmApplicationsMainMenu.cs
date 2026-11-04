using DVLD_Presentation.Detain_License;
using DVLD_Presentation.International_Driving_License;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.Local_Driving_License_Applications;
using DVLD_Presentation.Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Main_Menu
{
    public partial class frmApplicationsMainMenu : Form
    {
        public frmApplicationsMainMenu()
        {
            InitializeComponent();
        }

        private void frmApplicationsMainMenu_Load(object sender, EventArgs e)
        {
            _SetupPanelHoverEvents(this);

            clsFormatHelper.StyleContextMenu(cxmManageApplications);
            clsFormatHelper.StyleContextMenu(cxmDetainLicenses);
        }

        private void _SetupPanelHoverEvents(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Panel pnl)
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

                if (pnl.Name == "pnlManageApplications" && !cxmManageApplications.Visible)
                {
                    cxmManageApplications.Show(pnl, new Point(pnl.Width, 0));
                }
                else if (pnl.Name == "pnlDetainLicenses" && !cxmDetainLicenses.Visible)
                {
                    cxmDetainLicenses.Show(pnl, new Point(pnl.Width, 0));
                }
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

        private void pnlDetainLicenses_MouseEnter(object sender, EventArgs e)
        {
            panel_MouseEnter(sender, e);

            Panel? pnl = sender as Panel ?? (sender as Control)?.Parent as Panel;

            if (pnl == null)
                return;

            if (!cxmDetainLicenses.Visible)
                cxmDetainLicenses.Show(pnl, new Point(pnl.Width, 0));
        }

        private void pnlManageApplications_MouseEnter(object sender, EventArgs e)
        {
            panel_MouseEnter(sender, e);

            Panel? pnl = sender as Panel ?? (sender as Control)?.Parent as Panel;

            if (pnl == null)
                return;

            if (!cxmManageApplications.Visible)
                cxmManageApplications.Show(pnl, new Point(pnl.Width, 0));
        }

        private void pnlDrivingLicenseServices_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseServicesMainMenu frm = new frmDrivingLicenseServicesMainMenu();
            frm.ShowDialog();
        }

        private void toolStripMenuItemLocalLicense_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void toolStripMenuItemInternationalLicense_Click(object sender, EventArgs e)
        {
            frmManageInternationalDrivingLicenseApplications frm = new frmManageInternationalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void toolStripMenuItemManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses frm = new frmManageDetainedLicenses();
            frm.ShowDialog();
        }

        private void pnlManageApplications_Click(object sender, EventArgs e)
        {
            cxmManageApplications.Show(pnlManageApplications, new Point(pnlManageApplications.Width, 0));
        }

        private void pnlManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void pnlManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void pnlDetainLicenses_Click(object sender, EventArgs e)
        {
            cxmDetainLicenses.Show(pnlDetainLicenses, new Point(pnlDetainLicenses.Width, 0));
        }

        private void toolStripMenuItemDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void toolStripMenuItemReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }
    }
}