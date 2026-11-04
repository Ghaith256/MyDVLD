using DVLD_Business;
using DVLD_Presentation.People;
using DVLD_Presentation.Tests;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Presentation.International_Driving_License
{
    public partial class frmManageInternationalDrivingLicenseApplications : Form
    {
        private DataTable _dtInternationalLicenseApplications;

        public frmManageInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmManageInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            txtSearchInternationalDrivingLicenseApplication.BorderStyle = BorderStyle.None;
            txtSearchInternationalDrivingLicenseApplication.BackColor = ColorTranslator.FromHtml("#1f2937");
            txtSearchInternationalDrivingLicenseApplication.ForeColor = Color.White;
            txtSearchInternationalDrivingLicenseApplication.PlaceholderText = "Search Applications...";
            txtSearchInternationalDrivingLicenseApplication.TextAlign = HorizontalAlignment.Left;

            txtSearchInternationalDrivingLicenseApplication.Top = (pnlTextBorder.Height - txtSearchInternationalDrivingLicenseApplication.Height) / 2;
            txtSearchInternationalDrivingLicenseApplication.Left = 12;
            txtSearchInternationalDrivingLicenseApplication.Width = pnlTextBorder.Width - 24;

            txtSearchInternationalDrivingLicenseApplication.TextChanged += txtSearchInternationalDrivingLicenseApplication_TextChanged;
            btnAddInternationalDrivingLicenseApplication.Click += btnAddInternationalDrivingLicenseApplication_Click;
            dgvShowDriverInternationalLicensesHistory.CellFormatting += dgvShowDriverInternationalLicensesHistory_CellFormatting;

            clsFormatHelper.StyleButton(btnAddInternationalDrivingLicenseApplication);

            cmbFilterBy.FlatStyle = FlatStyle.Flat;
            cmbFilterBy.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbFilterBy.ForeColor = Color.White;

            dgvShowDriverInternationalLicensesHistory.BackColor = ColorTranslator.FromHtml("#1f2937");
            dgvShowDriverInternationalLicensesHistory.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowDriverInternationalLicensesHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowDriverInternationalLicensesHistory.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316"); // Flat orange accent
            dgvShowDriverInternationalLicensesHistory.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowDriverInternationalLicensesHistory);

            if (cmbFilterBy.Items.Count > 0)
                cmbFilterBy.SelectedIndex = 0;

            dgvShowDriverInternationalLicensesHistory.AutoGenerateColumns = false;

            dgvShowDriverInternationalLicensesHistory.Columns["InternationalLicenseID"].FillWeight = 15;
            dgvShowDriverInternationalLicensesHistory.Columns["ApplicationIDInternatonal"].FillWeight = 15;
            dgvShowDriverInternationalLicensesHistory.Columns["LocalLicenseID"].FillWeight = 15;
            dgvShowDriverInternationalLicensesHistory.Columns["IssueDateInternational"].FillWeight = 20;
            dgvShowDriverInternationalLicensesHistory.Columns["ExpirationDateInternational"].FillWeight = 20;
            dgvShowDriverInternationalLicensesHistory.Columns["IsActiveInternational"].FillWeight = 15;

            _RefreshInternationalLicenseApplications();
        }

        private void _RefreshInternationalLicenseApplications()
        {
            _dtInternationalLicenseApplications = clsInternationalLicenseBusiness.GetAllInternationalLicenses();
            dgvShowDriverInternationalLicensesHistory.DataSource = _dtInternationalLicenseApplications;
        }

        private void btnAddInternationalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenseApplication frm = new frmAddInternationalLicenseApplication();
            frm.ShowDialog();

            _RefreshInternationalLicenseApplications();
        }

        private void txtSearchInternationalDrivingLicenseApplication_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.SelectedItem == null)
                return;

            string SelectedFilter = cmbFilterBy.SelectedItem.ToString();
            string FilterColumn = "";

            switch (SelectedFilter)
            {
                case "Int.License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                case "L.D.L.AppID": // Kept fallback just in case you haven't renamed the combobox items yet
                    FilterColumn = "ApplicationID";
                    break;
                case "Local License ID":
                    FilterColumn = "LocalLicenseID";
                    break;
                case "Status":
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
                default:
                    FilterColumn = "";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtSearchInternationalDrivingLicenseApplication.Text) || FilterColumn == "")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "InternationalLicenseID" || FilterColumn == "ApplicationID" || FilterColumn == "LocalLicenseID")
            {
                if (int.TryParse(txtSearchInternationalDrivingLicenseApplication.Text.Trim(), out int Result))
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Result);
                else
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = "1=0"; // Prevent crash on invalid string entry
            }
            else if (FilterColumn == "IsActive")
            {
                string searchVal = txtSearchInternationalDrivingLicenseApplication.Text.Trim().ToLower();
                if (searchVal.StartsWith("y") || searchVal.StartsWith("1") || searchVal.StartsWith("t"))
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = true", FilterColumn);
                else if (searchVal.StartsWith("n") || searchVal.StartsWith("0") || searchVal.StartsWith("f"))
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = false", FilterColumn);
            }
            else
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchInternationalDrivingLicenseApplication.Text.Trim());
            }
        }

        private void dgvShowDriverInternationalLicensesHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            if (dgvShowDriverInternationalLicensesHistory.Columns[e.ColumnIndex].Name == "IsActiveInternational")
            {
                if (bool.TryParse(e.Value.ToString(), out bool isActive))
                {
                    e.Value = isActive ? "Yes" : "No";
                    e.FormattingApplied = true;
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

        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dgvShowDriverInternationalLicensesHistory.CurrentRow == null)
                return;

            int ApplicationID = (int)dgvShowDriverInternationalLicensesHistory.CurrentRow.Cells["ApplicationIDInternatonal"].Value;

            clsApplicationBusiness? ApplicationInfo = clsApplicationBusiness.GetApplicationInfoByID(ApplicationID);

            if (ApplicationInfo != null)
            {
                frmShowPersonInfo frm = new frmShowPersonInfo(ApplicationInfo.ApplicantPersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Could not retrieve Person Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e) {

            if (dgvShowDriverInternationalLicensesHistory.CurrentRow == null)
                return;

            int InternationalLicenseID = (int)dgvShowDriverInternationalLicensesHistory.CurrentRow.Cells["InternationalLicenseID"].Value;

            frmShowDriverInternationalLicenseInfo frm = new frmShowDriverInternationalLicenseInfo(InternationalLicenseID);
            frm.ShowDialog();

        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {

            if (dgvShowDriverInternationalLicensesHistory.CurrentRow == null)
                return;

            int ApplicationID = (int)dgvShowDriverInternationalLicensesHistory.CurrentRow.Cells["ApplicationIDInternatonal"].Value;

            clsApplicationBusiness? ApplicationInfo = clsApplicationBusiness.GetApplicationInfoByID(ApplicationID);

            if (ApplicationInfo != null) {
                frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ApplicationInfo.ApplicantPersonID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Could not retrieve Person Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}