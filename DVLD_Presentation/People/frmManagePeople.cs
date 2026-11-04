using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.People {
    public partial class frmManagePeople : Form
    {

        private static DataTable _dtAllPeople;

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dgvShowPeople.AutoGenerateColumns = false;
            _RefreshPeopleList();



            this.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);

            txtSearchPerson.BorderStyle = BorderStyle.None;
            txtSearchPerson.BackColor = ColorTranslator.FromHtml("#1f2937");
            txtSearchPerson.ForeColor = Color.White;
            txtSearchPerson.PlaceholderText = "Search Employees...";

            txtSearchPerson.TextAlign = HorizontalAlignment.Left;
            txtSearchPerson.Top = (pnlTextBorder.Height - txtSearchPerson.Height) / 2;
            txtSearchPerson.Left = 12;
            txtSearchPerson.Width = pnlTextBorder.Width - 24;

            clsFormatHelper.StyleButton(btnAddPerson);
            clsFormatHelper.StyleButton(btnUpdatePerson);
            clsFormatHelper.StyleButton(btnDeletePerson);


            cmbFilterBy.FlatStyle = FlatStyle.Flat;
            cmbFilterBy.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbFilterBy.ForeColor = Color.White;


            dgvShowPeople.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowPeople.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowPeople.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowPeople.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowPeople.DefaultCellStyle.SelectionForeColor = Color.White;


            clsFormatHelper.StyleDataGridView(dgvShowPeople);

            if (cmbFilterBy.Items.Count > 0)
                cmbFilterBy.SelectedIndex = 0;

        }



        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (dgvShowPeople.SelectedRows.Count > 0)
            {
                int PersonID = Convert.ToInt32(dgvShowPeople.SelectedRows[0].Cells["PersonID"].Value);

                if (MessageBox.Show("Are you sure you want to proceed with the deletion process?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsPersonBusiness.Delete(PersonID))
                    {
                        MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshPeopleList();
                    }
                    else
                    {
                        MessageBox.Show("Person was not deleted due to data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            string SelectedFilter = cmbFilterBy.SelectedItem.ToString();
            string FilterColumn = "";

            switch (SelectedFilter)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Second Name":
                    FilterColumn = "SecondName";
                    break;
                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Nationality":
                    FilterColumn = "Nationality";
                    break;
                case "Gender":
                    FilterColumn = "Gendor";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                default:
                    FilterColumn = "";
                    break;
            }

            if (txtSearchPerson.Text.Trim() == "")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "")
            {
                MessageBox.Show("Invalid filter selected", "Error");
                return;
            }

            if (FilterColumn == "PersonID")
            {
                if (int.TryParse(txtSearchPerson.Text.Trim(), out int Result))
                    _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Result);
                else
                    _dtAllPeople.DefaultView.RowFilter = "1=0";
            }
            else if (FilterColumn == "Gendor")
            {
                string Input = txtSearchPerson.Text.Trim().ToUpper();

                if (Input == "M" || Input == "MALE")
                    _dtAllPeople.DefaultView.RowFilter = "Gendor = 0";
                else if (Input == "F" || Input == "FEMALE")
                    _dtAllPeople.DefaultView.RowFilter = "Gendor = 1";
                else
                    _dtAllPeople.DefaultView.RowFilter = "1=0";
            }
            else if (FilterColumn == "Nationality")
            {
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchPerson.Text.Trim());
            }
            else
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchPerson.Text.Trim());

        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();

        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            if (dgvShowPeople.SelectedRows.Count > 0)
            {
                int PersonID = Convert.ToInt32(dgvShowPeople.SelectedRows[0].Cells["PersonID"].Value);

                frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
                frm.ShowDialog();
                _RefreshPeopleList();
            }
            else
                MessageBox.Show("Please select a person from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPersonBusiness.GetAllPeople();
            dgvShowPeople.DataSource = _dtAllPeople;
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchPerson.Visible = (cmbFilterBy.SelectedIndex != 0);
            pnlTextBorder.Visible = (cmbFilterBy.SelectedIndex != 0);

            if (txtSearchPerson.Visible)
            {
                txtSearchPerson.Text = "";
                txtSearchPerson.Focus();
            }

        }

        private void dgvShowPeople_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex < 0 || e.Value == null)
                return;

            if (dgvShowPeople.Columns[e.ColumnIndex].Name == "Gendor")
            {
                e.Value = (e.Value.ToString() == "0") ? "M" : "F";
            }

            if (dgvShowPeople.Columns[e.ColumnIndex].Name == "Nationality")
            {
                if (int.TryParse(e.Value.ToString(), out int id))
                    e.Value = clsPersonBusiness.GetCountryNameByID(id);

            }
        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e) {

            if (dgvShowPeople.SelectedRows.Count > 0) {
                int PersonID = Convert.ToInt32(dgvShowPeople.SelectedRows[0].Cells["PersonID"].Value);

                frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Please select a person from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
            btnUpdatePerson_Click(sender, e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            btnDeletePerson_Click(sender, e);
        }
    }
}
