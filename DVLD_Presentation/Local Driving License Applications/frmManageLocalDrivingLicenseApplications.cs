using DVLD_Business;
using DVLD_Presentation.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Local_Driving_License_Applications
{
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {

        private DataTable _dtShowLocalDrivingLicenseApplications;

        private ToolStripMenuItem ScheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem ScheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem ScheduleStreetTestToolStripMenuItem;

        private void _SetupTestSubMenus()
        {
            ScheduleVisionTestToolStripMenuItem = new ToolStripMenuItem("Schedule Vision Test");
            ScheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem("Schedule Written Test");
            ScheduleStreetTestToolStripMenuItem = new ToolStripMenuItem("Schedule Street Test");

            ScheduleVisionTestToolStripMenuItem.Click += ScheduleVisionTestToolStripMenuItem_Click;
            ScheduleWrittenTestToolStripMenuItem.Click += ScheduleWrittenTestToolStripMenuItem_Click;
            ScheduleStreetTestToolStripMenuItem.Click += ScheduleStreetTestToolStripMenuItem_Click;

            ScheduleTestsToolStripMenuItem.DropDownItems.Clear();
            ScheduleTestsToolStripMenuItem.DropDownItems.Add(ScheduleVisionTestToolStripMenuItem);
            ScheduleTestsToolStripMenuItem.DropDownItems.Add(ScheduleWrittenTestToolStripMenuItem);
            ScheduleTestsToolStripMenuItem.DropDownItems.Add(ScheduleStreetTestToolStripMenuItem);
        }

        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {

            txtSearchLocalDrivingLicenseApplication.BorderStyle = BorderStyle.None;
            txtSearchLocalDrivingLicenseApplication.BackColor = ColorTranslator.FromHtml("#1f2937");
            txtSearchLocalDrivingLicenseApplication.ForeColor = Color.White;
            txtSearchLocalDrivingLicenseApplication.PlaceholderText = "Search ...";
            txtSearchLocalDrivingLicenseApplication.TextAlign = HorizontalAlignment.Left;
            txtSearchLocalDrivingLicenseApplication.Top = (pnlTextBorder.Height - txtSearchLocalDrivingLicenseApplication.Height) / 2;  // ✅
            txtSearchLocalDrivingLicenseApplication.Left = 12;
            txtSearchLocalDrivingLicenseApplication.Width = pnlTextBorder.Width - 24;

            clsFormatHelper.StyleButton(btnAddLocalDrivingLicenseApplication);

            cmbFilterBy.FlatStyle = FlatStyle.Flat;
            cmbFilterBy.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbFilterBy.ForeColor = Color.White;

            dgvShowLocalDrivingLicenseApplications.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowLocalDrivingLicenseApplications.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowLocalDrivingLicenseApplications.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowLocalDrivingLicenseApplications);

            if (cmbFilterBy.Items.Count > 0)
                cmbFilterBy.SelectedIndex = 0;

            dgvShowLocalDrivingLicenseApplications.AutoGenerateColumns = false;

            dgvShowLocalDrivingLicenseApplications.Columns["ApplicantPersonID"].Visible = false;

            dgvShowLocalDrivingLicenseApplications.Columns["LocalDrivingLicenseApplicationID"].FillWeight = 5;
            dgvShowLocalDrivingLicenseApplications.Columns["ClassName"].FillWeight = 25;
            dgvShowLocalDrivingLicenseApplications.Columns["NationalNo"].FillWeight = 10;
            dgvShowLocalDrivingLicenseApplications.Columns["FullName"].FillWeight = 30;
            dgvShowLocalDrivingLicenseApplications.Columns["ApplicationDate"].FillWeight = 15;
            dgvShowLocalDrivingLicenseApplications.Columns["PassedTests"].FillWeight = 5;
            dgvShowLocalDrivingLicenseApplications.Columns["ApplicationStatus"].FillWeight = 10;

            _RefreshLocalDrivingLicenseApplications();
            _SetupTestSubMenus();
        }

        private void _RefreshLocalDrivingLicenseApplications()
        {
            _dtShowLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplicationBusiness.GetAllLocalDrivingLicenseApplications();
            dgvShowLocalDrivingLicenseApplications.DataSource = _dtShowLocalDrivingLicenseApplications;
        }

        private void btnAddLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();

            _RefreshLocalDrivingLicenseApplications();
        }

        private void txtSearchLocalDrivingLicenseApplication_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.SelectedItem == null)
                return;

            string? SelectedFilter = cmbFilterBy.SelectedItem.ToString();
            string FilterColumn = "";

            switch (SelectedFilter)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Status":
                    FilterColumn = "ApplicationStatus";
                    break;
                default:
                    FilterColumn = "";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtSearchLocalDrivingLicenseApplication.Text) || FilterColumn == "")
            {
                _dtShowLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(txtSearchLocalDrivingLicenseApplication.Text.Trim(), out int Result))
                    _dtShowLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Result);
                else
                    _dtShowLocalDrivingLicenseApplications.DefaultView.RowFilter = "1=0";
            }
            else
            {
                _dtShowLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchLocalDrivingLicenseApplication.Text.Trim());
            }


        }

        private void dgvShowLocalDrivingLicenseApplications_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex < 0 || e.Value == null)
                return;

            if (dgvShowLocalDrivingLicenseApplications.Columns[e.ColumnIndex].Name == "ApplicationStatus")
            {
                switch (e.Value.ToString())
                {
                    case "1":
                        e.Value = "New";
                        break;
                    case "2":
                        e.Value = "Cancelled";
                        break;
                    case "3":
                        e.Value = "Completed";
                        break;
                }
            }

        }

        private void pnlTextBorder_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(ColorTranslator.FromHtml("#f97316"), 2))
            {
                Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                using (System.Drawing.Drawing2D.GraphicsPath path = clsFormatHelper.GetRoundedRectanglePath(rect, 15))
                {

                    using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#1f2937")))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void cxmManageLocalDrivingLicenseApplications_Opening(object sender, CancelEventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            int PassedTests = Convert.ToInt32(dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["PassedTests"].Value);
            string? Status = dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["ApplicationStatus"].Value.ToString();

            bool IsNew = (Status.ToLower() == "new" || Status == "1");
            bool IsCompleted = (Status.ToLower() == "completed" || Status == "3");

            ShowApplicationInfoToolStripMenuItem.Enabled = true;
            ShowPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            EditApplicationToolStripMenuItem.Enabled = IsNew && (PassedTests == 0);
            DeleteApplicationToolStripMenuItem.Enabled = IsNew;
            CancelApplicationToolStripMenuItem.Enabled = IsNew;

            bool HasNotPassedAllTests = (PassedTests < 3);
            ScheduleTestsToolStripMenuItem.Enabled = IsNew && HasNotPassedAllTests;

            if (ScheduleTestsToolStripMenuItem.Enabled)
            {
                ScheduleVisionTestToolStripMenuItem.Enabled = (PassedTests == 0);
                ScheduleWrittenTestToolStripMenuItem.Enabled = (PassedTests == 1);
                ScheduleStreetTestToolStripMenuItem.Enabled = (PassedTests == 2);
            }

            IssueDrivingLicenseToolStripMenuItem.Enabled = IsNew && (PassedTests == 3);

            ShowLicenseToolStripMenuItem.Enabled = IsCompleted;

        }

        private void ShowApplicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();

        }

        private void CancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplicationBusiness LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);

            if (LocalApp != null)
            {
                if (LocalApp.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshLocalDrivingLicenseApplications();
                }
                else
                    MessageBox.Show("Could not cancel application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete this application?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplicationBusiness? LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);

            if (LocalApp != null)
            {

                if (LocalApp.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshLocalDrivingLicenseApplications();
                }
                else
                    MessageBox.Show("Could not delete application, it may have related data (like tests).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void EditApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplicationBusiness? LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);

            if (LocalApp != null)
            {
                frmAddApplicationInfo frm = new frmAddApplicationInfo(LocalApp);
                frm.ShowDialog();

                _RefreshLocalDrivingLicenseApplications();
            }

        }

        private void ScheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            frmTestAppointments frm = new frmTestAppointments(LocalAppID, 1);
            frm.ShowDialog();

            _RefreshLocalDrivingLicenseApplications();
        }

        private void ScheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            frmTestAppointments frm = new frmTestAppointments(LocalAppID, 2);
            frm.ShowDialog();

            _RefreshLocalDrivingLicenseApplications();
        }

        private void ScheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            frmTestAppointments frm = new frmTestAppointments(LocalAppID, 3);
            frm.ShowDialog();

            _RefreshLocalDrivingLicenseApplications();


        }

        private void IssueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime(LocalAppID);
            frm.ShowDialog();

            _RefreshLocalDrivingLicenseApplications();

        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int LocalAppID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplicationBusiness? LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(LocalAppID);

            if (LocalApp == null)
            {
                MessageBox.Show("Application details could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseID = LocalApp.GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(LicenseID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("No active license found for this application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int PersonID = (int)dgvShowLocalDrivingLicenseApplications.CurrentRow.Cells["ApplicantPersonID"].Value;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();

        }
    }
}
