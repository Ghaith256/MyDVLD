using DVLD_Business;
using DVLD_Presentation.Application_Types;
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
    public partial class frmManageApplicationTypes : Form
    {
        private DataTable _dtShowApplicationTypes;
      
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {

            dgvShowApplicationTypes.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowApplicationTypes.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowApplicationTypes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowApplicationTypes.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowApplicationTypes.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowApplicationTypes);
            dgvShowApplicationTypes.AutoGenerateColumns = false;

            _RefreshApplicationTypes();
            
        }

        private void dgvShowApplicationTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            int ApplicationTypeID = (int)dgvShowApplicationTypes.CurrentRow.Cells["ApplicationTypeID"].Value;

            frmUpdateApplicationType frm = new frmUpdateApplicationType(ApplicationTypeID);
            frm.ShowDialog();

            _RefreshApplicationTypes();
        }

        private void _RefreshApplicationTypes() {
            _dtShowApplicationTypes = clsApplicationTypeBusiness.GetAllApplicationTypes();
            dgvShowApplicationTypes.DataSource = _dtShowApplicationTypes;
            lblRecordsNumber.Text = _dtShowApplicationTypes.Rows.Count.ToString();
        }

    }
}
