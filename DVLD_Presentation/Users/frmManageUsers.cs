using DVLD_Business;
using DVLD_Presentation.People;
using DVLD_Presentation.Users;
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
    public partial class frmManageUsers : Form
    {
        private DataTable _dtShowUsers;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);

            txtSearchUser.BorderStyle = BorderStyle.None;
            txtSearchUser.BackColor = ColorTranslator.FromHtml("#1f2937");
            txtSearchUser.ForeColor = Color.White;
            txtSearchUser.PlaceholderText = "Search Employees...";

            txtSearchUser.TextAlign = HorizontalAlignment.Left;
            txtSearchUser.Top = (pnlTextBorder.Height - txtSearchUser.Height) / 2;
            txtSearchUser.Left = 12;
            txtSearchUser.Width = pnlTextBorder.Width - 24;

            clsFormatHelper.StyleButton(btnAddUser);

            cmbFilterBy.FlatStyle = FlatStyle.Flat;
            cmbFilterBy.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbFilterBy.ForeColor = Color.White;

            cmbIsActive.FlatStyle = FlatStyle.Flat;
            cmbIsActive.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbIsActive.ForeColor = Color.White;

            dgvShowUser.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f2937");
            dgvShowUser.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#374151");
            dgvShowUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowUser.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgvShowUser.DefaultCellStyle.SelectionForeColor = Color.White;

            clsFormatHelper.StyleDataGridView(dgvShowUser);

            if (cmbFilterBy.Items.Count > 0)
                cmbFilterBy.SelectedIndex = 0;

            dgvShowUser.AutoGenerateColumns = false;

            _dtShowUsers = clsUserBusiness.GetAllUsers();
            dgvShowUser.DataSource = _dtShowUsers;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();

            frm.ShowDialog();

            _dtShowUsers = clsUserBusiness.GetAllUsers();
            dgvShowUser.DataSource = _dtShowUsers;
        }

        private void itemShowDetails_Click(object sender, EventArgs e)
        {
            if (dgvShowUser.CurrentRow == null)
                return;

            int UserID = (int)dgvShowUser.CurrentRow.Cells[0].Value;
            frmShowUserInfo frm = new frmShowUserInfo(UserID);

            frm.ShowDialog();
        }

        private void itemUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvShowUser.CurrentRow == null)
                return;

            int PersonID = (int)dgvShowUser.CurrentRow.Cells[1].Value;        

            frmAddUserInfo frm = new frmAddUserInfo(PersonID);
            frm.ShowDialog();

            _dtShowUsers = clsUserBusiness.GetAllUsers();
            dgvShowUser.DataSource = _dtShowUsers;
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {

            if (dgvShowUser.CurrentRow == null)
                return;

            int UserID = (int)dgvShowUser.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            bool isDeleted = clsUserBusiness.DeleteUser(UserID);

            if (isDeleted)
            {
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _dtShowUsers = clsUserBusiness.GetAllUsers();
                dgvShowUser.DataSource = _dtShowUsers;
            }
            else
                MessageBox.Show("Failed to delete user. It may be linked to other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void itemChangePassword_Click(object sender, EventArgs e)
        {

            if (dgvShowUser.CurrentRow == null)
                return;

            int UserID = (int)dgvShowUser.CurrentRow.Cells[0].Value;


            frmChangePassword frm = new frmChangePassword(UserID);
            frm.ShowDialog();

            _dtShowUsers = clsUserBusiness.GetAllUsers();
            dgvShowUser.DataSource = _dtShowUsers;
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

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? SelectedFilter = cmbFilterBy.SelectedItem.ToString();

            if (SelectedFilter == "Is Active")
            {
                txtSearchUser.Visible = false;
                pnlTextBorder.Visible = false;

                cmbIsActive.Visible = true;
                cmbIsActive.SelectedIndex = 0;
                cmbIsActive.Focus();
            }
            else if (SelectedFilter == "None")
            {
                txtSearchUser.Visible = false;
                pnlTextBorder.Visible = false;
                cmbIsActive.Visible = false;

                if (_dtShowUsers != null)
                    _dtShowUsers.DefaultView.RowFilter = "";
            }
            else
            {
                cmbIsActive.Visible = false;

                txtSearchUser.Visible = true;
                pnlTextBorder.Visible = true;

                txtSearchUser.Text = "";
                txtSearchUser.Focus();
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e) {
            
            if (cmbFilterBy.SelectedItem == null)
                return;

            string? SelectedFilter = cmbFilterBy.SelectedItem.ToString();
            string FilterColumn = "";

            switch (SelectedFilter) {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Username":
                    FilterColumn = "UserName";
                    break;
                default:
                    FilterColumn = "";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtSearchUser.Text) || FilterColumn == "")
            {
                _dtShowUsers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "UserID" || FilterColumn == "PersonID")
            {
                if (int.TryParse(txtSearchUser.Text.Trim(), out int Result))
                    _dtShowUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Result);
                else
                    _dtShowUsers.DefaultView.RowFilter = "1=0"; 
            }
            else
            {
                _dtShowUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchUser.Text.Trim());
            }

        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtShowUsers == null)
                return;

            string? selectedValue = cmbIsActive.SelectedItem.ToString();

            switch (selectedValue) {
                case "Yes":
                    _dtShowUsers.DefaultView.RowFilter = "[IsActive] = true";
                    break;

                case "No":
                    _dtShowUsers.DefaultView.RowFilter = "[IsActive] = false";
                    break;

                case "All":
                default:
                    _dtShowUsers.DefaultView.RowFilter = "";
                    break;
            }
        }
    }
}
