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
    public partial class ucDriverInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID = -1;
        private clsInternationalLicenseBusiness _InternationalLicense;

        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        public ucDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicenseBusiness.GetInternationalLicenseInfoByID(_InternationalLicenseID);

            if (_InternationalLicense == null)
            {
                MessageBox.Show($"Could not find International License with ID = {_InternationalLicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAnswerInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblAnswerApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblAnswerLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblAnswerIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblAnswerDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblAnswerIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblAnswerExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();

            if (_InternationalLicense.DriverInfo != null && _InternationalLicense.DriverInfo.PersonInfo != null)
            {
                lblAnswerName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
                lblAnswerNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
                lblAnswerDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
                lblAnswerGendor.Text = (_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female");
            }
            else
            {
                lblAnswerName.Text = "N/A";
                lblAnswerNationalNo.Text = "N/A";
                lblAnswerDateOfBirth.Text = "N/A";
                lblAnswerGendor.Text = "N/A";
            }
        }
    }
}