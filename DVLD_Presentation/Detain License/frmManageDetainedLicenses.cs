using DVLD_Business;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.People;
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

namespace DVLD_Presentation.Detain_License
{
    public partial class frmManageDetainedLicenses : Form
    {

        private static DataTable? _dtAllDetainedLicenses;

        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {

            dgvShowDetainedLicenses.AutoGenerateColumns = false;
            _RefreshDetainedLicensesList();

            this.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);

            txtSearchLicense.BorderStyle = BorderStyle.None;
            txtSearchLicense.BackColor = ColorTranslator.FromHtml("#1f2937");
            txtSearchLicense.ForeColor = Color.White;
            txtSearchLicense.PlaceholderText = "Search...";

            txtSearchLicense.TextAlign = HorizontalAlignment.Left;
            txtSearchLicense.Top = (pnlTextBorder.Height - txtSearchLicense.Height) / 2;
            txtSearchLicense.Left = 12;
            txtSearchLicense.Width = pnlTextBorder.Width - 24;

            clsFormatHelper.StyleButton(btnDetain);
            clsFormatHelper.StyleButton(btnRelease);

            cmbFilterBy.FlatStyle = FlatStyle.Flat;
            cmbFilterBy.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbFilterBy.ForeColor = Color.White;

            dgvShowDetainedLicenses.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowDetainedLicenses.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowDetainedLicenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowDetainedLicenses.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowDetainedLicenses.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowDetainedLicenses);

            if (cmbFilterBy.Items.Count > 0)
                cmbFilterBy.SelectedIndex = 0;

            dgvShowDetainedLicenses.Columns["DetainID"].FillWeight = 7;
            dgvShowDetainedLicenses.Columns["LicenseID"].FillWeight = 7;
            dgvShowDetainedLicenses.Columns["DetainDate"].FillWeight = 14;
            dgvShowDetainedLicenses.Columns["IsReleased"].FillWeight = 5;
            dgvShowDetainedLicenses.Columns["FineFees"].FillWeight = 9;
            dgvShowDetainedLicenses.Columns["ReleaseDate"].FillWeight = 9;
            dgvShowDetainedLicenses.Columns["NationalNo"].FillWeight = 10;
            dgvShowDetainedLicenses.Columns["FullName"].FillWeight = 30;
            dgvShowDetainedLicenses.Columns["ReleaseApplicationID"].FillWeight = 9;



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

        private void txtSearchLicense_TextChanged(object sender, EventArgs e)
        {
            string SelectedFilter = cmbFilterBy.SelectedItem.ToString();
            string FilterColumn = "";

            switch (SelectedFilter)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "Is Released":
                    FilterColumn = "IsReleased";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;
                default:
                    FilterColumn = "";
                    break;
            }

            if (txtSearchLicense.Text.Trim() == "")
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "")
            {
                MessageBox.Show("Invalid filter selected", "Error");
                return;
            }

            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
            {
                if (int.TryParse(txtSearchLicense.Text.Trim(), out int Result))
                    _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Result);
                else
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "1=0";
            }
            else if (FilterColumn == "IsReleased")
            {
                string Input = txtSearchLicense.Text.Trim().ToUpper();

                if (Input == "Y" || Input == "YES" || Input == "TRUE" || Input == "1")
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "IsReleased = 1";
                else if (Input == "N" || Input == "NO" || Input == "FALSE" || Input == "0")
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "IsReleased = 0";
                else
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "1=0";
            }
            else
                _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchLicense.Text.Trim());
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (dgvShowDetainedLicenses.CurrentRow == null)
            {
                MessageBox.Show("Please select a license from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int LicenseID = (int)dgvShowDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;

            frmDetainLicense frm = new frmDetainLicense(LicenseID);
            frm.ShowDialog();

            _RefreshDetainedLicensesList();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (dgvShowDetainedLicenses.SelectedRows.Count > 0)
            {
                int LicenseID = Convert.ToInt32(dgvShowDetainedLicenses.SelectedRows[0].Cells["LicenseID"].Value);

                frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(LicenseID);
                frm.ShowDialog();
                _RefreshDetainedLicensesList();
            }
            else
                MessageBox.Show("Please select a record from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void _RefreshDetainedLicensesList()
        {
            _dtAllDetainedLicenses = clsDetainedLicenseBusiness.GetAllDetainedLicenses();
            dgvShowDetainedLicenses.DataSource = _dtAllDetainedLicenses;
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchLicense.Visible = (cmbFilterBy.SelectedIndex != 0);
            pnlTextBorder.Visible = (cmbFilterBy.SelectedIndex != 0);

            if (txtSearchLicense.Visible)
            {
                txtSearchLicense.Text = "";
                txtSearchLicense.Focus();
            }
        }

        private void dgvShowDetainedLicenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            if (dgvShowDetainedLicenses.Columns[e.ColumnIndex].Name == "IsReleased")
                e.Value = (e.Value.ToString() == "True") ? "Yes" : "No";

        }

        private void toolStripMenuItemShowPersonDetails_Click(object sender, EventArgs e)
        {

            if (dgvShowDetainedLicenses.CurrentRow == null)
                return;

            string NationalNo = (string)dgvShowDetainedLicenses.CurrentRow.Cells["NationalNo"].Value;
            clsPersonBusiness? PersonInfo = clsPersonBusiness.Find(NationalNo);

            if (PersonInfo != null)
            {
                frmShowPersonInfo frm = new frmShowPersonInfo(PersonInfo.PersonID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Could not retrieve Person Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void toolStripMenuItemShowLicenseDetails_Click(object sender, EventArgs e)
        {

            if (dgvShowDetainedLicenses.CurrentRow == null)
                return;

            int LicenseID = (int)dgvShowDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;

            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(LicenseID);
            frm.ShowDialog();

        }

        private void toolStripMenuItemShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {

            if (dgvShowDetainedLicenses.CurrentRow == null)
                return;

            string NationalNo = (string)dgvShowDetainedLicenses.CurrentRow.Cells["NationalNo"].Value;
            clsPersonBusiness? PersonInfo = clsPersonBusiness.Find(NationalNo);

            if (PersonInfo != null)
            {
                frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonInfo.PersonID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Could not retrieve Person Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void toolStripMenuItemReleaseDetainedLicense_Click(object sender, EventArgs e)
        {

            if (dgvShowDetainedLicenses.CurrentRow == null)
                return;

            int LicenseID = (int)dgvShowDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;

            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(LicenseID);
            frm.ShowDialog();

            _RefreshDetainedLicensesList();

        }

        private void cxmManageDetainedLicenses_Opening(object sender, CancelEventArgs e) {

            if (dgvShowDetainedLicenses.CurrentRow == null)
                return;

            bool IsReleased = (bool)dgvShowDetainedLicenses.CurrentRow.Cells["IsReleased"].Value;

            toolStripMenuItemReleaseDetainedLicense.Enabled = !IsReleased;

        }
    }
}
