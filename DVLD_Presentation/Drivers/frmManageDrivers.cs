using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Drivers
{
    public partial class frmManageDrivers : Form
    {

        private static DataTable? _dtAllDrivers;

        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            dgvShowDrivers.AutoGenerateColumns = false;
            _RefreshDriversList();

            txtSearchDriver.BorderStyle = BorderStyle.None;
            txtSearchDriver.BackColor = ColorTranslator.FromHtml("#1f2937");
            txtSearchDriver.ForeColor = Color.White;
            txtSearchDriver.PlaceholderText = "Search...";
            txtSearchDriver.TextAlign = HorizontalAlignment.Left;
            txtSearchDriver.Top = (pnlTextBorder.Height - txtSearchDriver.Height) / 2;
            txtSearchDriver.Left = 12;
            txtSearchDriver.Width = pnlTextBorder.Width - 24;

            cmbFilterBy.FlatStyle = FlatStyle.Flat;
            cmbFilterBy.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbFilterBy.ForeColor = Color.White;

            dgvShowDrivers.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowDrivers.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowDrivers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowDrivers.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowDrivers.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowDrivers);

            dgvShowDrivers.Columns["DriverID"].FillWeight = 12;
            dgvShowDrivers.Columns["PersonID"].FillWeight = 12;
            dgvShowDrivers.Columns["NationalNo"].FillWeight = 14;
            dgvShowDrivers.Columns["FullName"].FillWeight = 34;
            dgvShowDrivers.Columns["Date"].FillWeight = 14;
            dgvShowDrivers.Columns["ActiveLicenses"].FillWeight = 14;

            if (cmbFilterBy.Items.Count > 0)
                cmbFilterBy.SelectedIndex = 0;

        }

        private void _RefreshDriversList()
        {
            _dtAllDrivers = clsDriverBusiness.GetAllDrivers();
            dgvShowDrivers.DataSource = _dtAllDrivers;
        }


        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e) {
            
            bool IsNone = (cmbFilterBy.Text == "None" || string.IsNullOrWhiteSpace(cmbFilterBy.Text));

            txtSearchDriver.Visible = !IsNone;
            pnlTextBorder.Visible = !IsNone;

            if (txtSearchDriver.Visible)
            {
                txtSearchDriver.Text = "";
                txtSearchDriver.Focus();
            }
            else
                if (_dtAllDrivers != null)
                    _dtAllDrivers.DefaultView.RowFilter = "";

        }

        private void txtSearchDriver_TextChanged(object sender, EventArgs e) {

            if (cmbFilterBy.SelectedItem == null)
                return;

            string SelectedFilter = cmbFilterBy.SelectedItem.ToString();
            string FilterColumn = "";

            switch (SelectedFilter)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "";
                    break;

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

    }
}
