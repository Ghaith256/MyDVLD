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
    public partial class frmAddApplicationInfo : Form
    {
        private clsLocalDrivingLicenseApplicationBusiness _LocalApp;

        public frmAddApplicationInfo(clsLocalDrivingLicenseApplicationBusiness LocalApp) {
            InitializeComponent();
            _LocalApp = LocalApp;
        }

        private void frmAddApplicationInfo_Load(object sender, EventArgs e)
        {

            cmbFilterBy.FlatStyle = FlatStyle.Flat;
            cmbFilterBy.BackColor = ColorTranslator.FromHtml("#1f2937");
            cmbFilterBy.ForeColor = Color.White;

            clsFormatHelper.StyleButton(btnSave);

            _LoadComboBoxContent();
            _LoadData();

        }

        private void _LoadComboBoxContent()
        {
            DataTable dtClasses = clsLicenseClassBusiness.GetAllLicenseClasses();

            try
            {

                if (dtClasses.Rows.Count > 0)
                {
                    cmbFilterBy.DataSource = dtClasses;
                    cmbFilterBy.DisplayMember = "ClassName";
                    cmbFilterBy.ValueMember = "LicenseClassID";
                }
                else
                    MessageBox.Show("DataTable is null or empty. Check your database or business layer query.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Details: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _LoadData() {

            if (_LocalApp.LocalDrivingLicenseApplicationID != -1) {
                lblAnswerApplicationID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();
                lblAnswerApplicationDate.Text = _LocalApp.ApplicationInfo.ApplicationDate.ToShortDateString();
                cmbFilterBy.SelectedValue = _LocalApp.LicenseClassID;
                lblAnswerApplicationFees.Text = _LocalApp.ApplicationInfo.PaidFees.ToString();
                lblAnswerCreatedBy.Text = _LocalApp.ApplicationInfo.CreatedByUserID.ToString();
            }
            else
            {
                lblApplicationID.Text = "[???]";
                lblAnswerApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblAnswerApplicationFees.Text = "15";
                lblAnswerCreatedBy.Text = clsGlobal.CurrentUser.UserID.ToString();
            }



        }

        private void btnSave_Click(object sender, EventArgs e) {
            int SelectedClassID = (int)cmbFilterBy.SelectedValue;

            if (_LocalApp.LocalDrivingLicenseApplicationID == -1) {

                if (clsLocalDrivingLicenseApplicationBusiness.DoesActiveApplicationExist(_LocalApp.ApplicationInfo.ApplicantPersonID, SelectedClassID))
                {
                    MessageBox.Show("This person already has an active (New or Completed) application for this license class.", "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _LocalApp.ApplicationInfo.ApplicationDate = DateTime.Now;
                _LocalApp.ApplicationInfo.ApplicationTypeID = 1;
                _LocalApp.ApplicationInfo.ApplicationStatus = 1;
                _LocalApp.ApplicationInfo.LastStatusDate = DateTime.Now;
                _LocalApp.ApplicationInfo.PaidFees = Convert.ToDecimal(lblAnswerApplicationFees.Text);
                _LocalApp.ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }

            _LocalApp.LicenseClassID = SelectedClassID;

            if (_LocalApp.Save())
            {
                MessageBox.Show($"Application Saved! ID = {_LocalApp.LocalDrivingLicenseApplicationID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApplicationID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }


    }

}


