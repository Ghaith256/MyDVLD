using DVLD_Business;
using DVLD_Presentation.People;
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
    public partial class ucApplicationBasicInfo : UserControl
    {
        private clsApplicationBusiness? _Application;

        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationData(int ApplicationID)
        {
            _Application = clsApplicationBusiness.GetApplicationInfoByID(ApplicationID);

            if (_Application == null)
            {
                MessageBox.Show("No Application with ID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAnswerApplicationID.Text = _Application.ApplicationID.ToString();
            lblAnswerStatus.Text = _Application.ApplicationStatus.ToString();
            lblAnswerFees.Text = _Application.PaidFees.ToString();
            lblAnswerType.Text = _Application.ApplicationTypeID.ToString();

            lblAnswerDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblAnswerStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            lblAnswerCreatedBy.Text = _Application.CreatedByUserID.ToString();

            clsPersonBusiness? Person = clsPersonBusiness.Find(_Application.ApplicantPersonID);

            lblAnswerApplicant.Text = _Application.PersonInfo?.FullName ?? "Unknown Person";

        }

        private void lnkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            frmShowPersonInfo frm = new frmShowPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();
            
        }
    }
}
