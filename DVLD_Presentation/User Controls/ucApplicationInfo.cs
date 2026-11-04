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
    public partial class ucApplicationInfo : UserControl
    {

        private int _InternationalLicenseID = -1;
        private clsInternationalLicenseBusiness _InternationalLicense;

        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        public ucApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(clsInternationalLicenseBusiness InternationalLicense)
        {

            if (InternationalLicense == null)
            {
                MessageBox.Show("No International License information to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _InternationalLicense = InternationalLicense;
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;

            lblAnswerInternationalLicenseApplicationID.Text = (InternationalLicense.ApplicationID == -1) ? "???" : InternationalLicense.ApplicationID.ToString();
            lblAnswerInternationalLicenseID.Text = (InternationalLicense.InternationalLicenseID == -1) ? "???" : InternationalLicense.InternationalLicenseID.ToString();
            lblAnswerLocalLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblAnswerIssueDate.Text = InternationalLicense.IssueDate.ToShortDateString();
            lblAnswerExpirationDate.Text = InternationalLicense.ExpirationDate.ToShortDateString();
            lblAnswerCreatedBy.Text = InternationalLicense.CreatedByUserID.ToString();


            if (InternationalLicense.ApplicationInfo != null)
            {
                lblAnswerApplicationDate.Text = InternationalLicense.ApplicationInfo.ApplicationDate.ToShortDateString();
                lblAnswerFees.Text = InternationalLicense.ApplicationInfo.PaidFees.ToString();
            }

        }



    }
}