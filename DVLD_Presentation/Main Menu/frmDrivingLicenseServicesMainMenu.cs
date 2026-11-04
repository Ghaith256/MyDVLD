using DVLD_Presentation.Detain_License;
using DVLD_Presentation.International_Driving_License;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.Local_Driving_License_Applications;
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
    public partial class frmDrivingLicenseServicesMainMenu : Form
    {
        public frmDrivingLicenseServicesMainMenu()
        {
            InitializeComponent();
            clsFormatHelper.StyleContextMenu(cxmNewDrivingLicense);
        }

        private void frmDrivingLicenseServicesMainMenu_Load(object sender, EventArgs e)
        {
            _SetupPanelHoverEvents(this);
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

                if (pnl.Name == "pnlNewDrivingLicense" && !cxmNewDrivingLicense.Visible)
                    cxmNewDrivingLicense.Show(pnl, new Point(pnl.Width, 0));
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

        private void pnlNewDrivingLicense_MouseEnter(object sender, EventArgs e)
        {
            panel_MouseEnter(sender, e);

            Panel? pnl = sender as Panel ?? (sender as Control)?.Parent as Panel;

            if (pnl == null)
                return;

            if (!cxmNewDrivingLicense.Visible)
                cxmNewDrivingLicense.Show(pnl, new Point(pnl.Width, 0));
        }

        private void cxmNewDrivingLicense_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItemLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void pnlRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLicenseApplication frm = new frmRenewLicenseApplication();
            frm.ShowDialog();
        }

        private void pnlReplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            frmLicenseReplacement frm = new frmLicenseReplacement();
            frm.ShowDialog();
        }

        private void pnlReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void pnlRetakeTest_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void pnlNewDrivingLicense_Click(object sender, EventArgs e)
        {
            cxmNewDrivingLicense.Show(pnlNewDrivingLicense, new Point(pnlNewDrivingLicense.Width, 0));
        }

        private void toolStripMenuItemInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenseApplication frm = new frmAddInternationalLicenseApplication();
            frm.ShowDialog();
        }
    }
}