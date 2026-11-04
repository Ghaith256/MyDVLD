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

namespace DVLD_Presentation.Test_Types {
    public partial class frmManageTestTypes : Form
    {

        private DataTable _dtShowTestTypes;


        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {

            dgvShowTestTypes.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowTestTypes.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowTestTypes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowTestTypes.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowTestTypes.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowTestTypes);
            dgvShowTestTypes.AutoGenerateColumns = false;

            dgvShowTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvShowTestTypes.Columns[0].FillWeight = 5;
            dgvShowTestTypes.Columns[1].FillWeight = 15;
            dgvShowTestTypes.Columns[2].FillWeight = 71;
            dgvShowTestTypes.Columns[3].FillWeight = 9;

            _RefreshTestTypes();
        }



        private void _RefreshTestTypes()
        {
            _dtShowTestTypes = clsTestTypeBusiness.GetAllTestTypes();
            dgvShowTestTypes.DataSource = _dtShowTestTypes;
            lblRecordsNumber.Text = _dtShowTestTypes.Rows.Count.ToString();
        }

        private void dgvShowTestTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            
            if (e.RowIndex < 0)
                return;

            int TestTypeID = (int)dgvShowTestTypes.CurrentRow.Cells["TestTypeID"].Value;

            frmUpdateTestType frm = new frmUpdateTestType(TestTypeID);
            frm.ShowDialog();

            _RefreshTestTypes();
        }
    }
}
