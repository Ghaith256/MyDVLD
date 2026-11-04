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

namespace DVLD_Presentation.Local_Driving_License_Applications
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            clsFormatHelper.StyleButton(btnNext);
            clsFormatHelper.StyleButton(btnSearch);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (cmbFilterBy.SelectedItem == null) {
                MessageBox.Show("Please select a filter category first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSearchPerson.Text)){
                MessageBox.Show("Please enter a value to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? SelectedItem = cmbFilterBy.SelectedItem.ToString();
            string SearchValue = txtSearchPerson.Text.Trim();

            if (SelectedItem == "Person ID")
            {
                if (int.TryParse(SearchValue, out int PersonID))
                    ucShowPersonInfo.LoadPersonInfo(PersonID);
                else
                    MessageBox.Show("Please enter a valid numeric Person ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SelectedItem == "National No.")
                ucShowPersonInfo.LoadPersonInfo(SearchValue);

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

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ucShowPersonInfo.PersonID == -1)
            {
                MessageBox.Show("Please select a person first by searching before moving to the next step.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsLocalDrivingLicenseApplicationBusiness NewApp = new clsLocalDrivingLicenseApplicationBusiness();
            NewApp.ApplicationInfo.ApplicantPersonID = ucShowPersonInfo.PersonID;

            frmAddApplicationInfo frm = new frmAddApplicationInfo(NewApp);
            frm.ShowDialog();

        }


    }
}
