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

namespace DVLD_Presentation.User_Controls
{
    public partial class ucShowDriverLicensesHistory : UserControl
    {
        private int _DriverID = -1;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory; // Added DataTable for International

        public ucShowDriverLicensesHistory()
        {
            InitializeComponent();
        }

        private void ucShowDriverLicensesHistory_Load(object sender, EventArgs e)
        {
            dgvShowDriverLocalLicensesHistory.AutoGenerateColumns = false;
            dgvShowDriverInternationalLicensesHistory.AutoGenerateColumns = false; // Disabled for International
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            clsDriverBusiness? Driver = clsDriverBusiness.GetDriverInfoByPersonID(PersonID);

            if (Driver != null)
            {
                _DriverID = Driver.DriverID;

                // Load both grids
                _LoadLocalLicensesInfo();
                _LoadInternationalLicensesInfo();
            }
            else
            {
                // Clear both grids if driver not found
                _dtDriverLocalLicensesHistory = null;
                dgvShowDriverLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;

                _dtDriverInternationalLicensesHistory = null;
                dgvShowDriverInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            }
        }

        private void _LoadLocalLicensesInfo()
        {
            _dtDriverLocalLicensesHistory = clsDriverBusiness.GetLocalLicenses(_DriverID);
            dgvShowDriverLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;

            if (_dtDriverLocalLicensesHistory != null && _dtDriverLocalLicensesHistory.Rows.Count > 0)
            {
                dgvShowDriverLocalLicensesHistory.Columns["LicenseID"].FillWeight = 10;
                dgvShowDriverLocalLicensesHistory.Columns["ApplicationID"].FillWeight = 10;
                dgvShowDriverLocalLicensesHistory.Columns["ClassName"].FillWeight = 34;
                dgvShowDriverLocalLicensesHistory.Columns["IssueDate"].FillWeight = 18;
                dgvShowDriverLocalLicensesHistory.Columns["ExpirationDate"].FillWeight = 18;
                dgvShowDriverLocalLicensesHistory.Columns["IsActive"].FillWeight = 10;
            }

            dgvShowDriverLocalLicensesHistory.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowDriverLocalLicensesHistory.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowDriverLocalLicensesHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowDriverLocalLicensesHistory.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowDriverLocalLicensesHistory.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowDriverLocalLicensesHistory);
        }

        // Added method to load and style the International Licenses DataGridView
        private void _LoadInternationalLicensesInfo()
        {
            _dtDriverInternationalLicensesHistory = clsDriverBusiness.GetInternationalLicenses(_DriverID);
            dgvShowDriverInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;

            if (_dtDriverInternationalLicensesHistory != null && _dtDriverInternationalLicensesHistory.Rows.Count > 0)
            {
                // Note: These names exactly match the Name properties in your designer code
                dgvShowDriverInternationalLicensesHistory.Columns["InternationalLicenseID"].FillWeight = 16;
                dgvShowDriverInternationalLicensesHistory.Columns["ApplicationIDInternatonal"].FillWeight = 16;
                dgvShowDriverInternationalLicensesHistory.Columns["LocalLicenseID"].FillWeight = 16;
                dgvShowDriverInternationalLicensesHistory.Columns["IssueDateInternational"].FillWeight = 18;
                dgvShowDriverInternationalLicensesHistory.Columns["ExpirationDateInternational"].FillWeight = 18;
                dgvShowDriverInternationalLicensesHistory.Columns["IsActiveInternational"].FillWeight = 16;
            }

            dgvShowDriverInternationalLicensesHistory.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowDriverInternationalLicensesHistory.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowDriverInternationalLicensesHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowDriverInternationalLicensesHistory.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowDriverInternationalLicensesHistory.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowDriverInternationalLicensesHistory);
        }
    }
}