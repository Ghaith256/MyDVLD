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
    public partial class ucDriverLicenseInfo : UserControl {

        private int _LicenseID = -1;
        private clsLicenseBusiness? _License;

        public int LicenseID {
            get { return _LicenseID; }
        }

        public clsLicenseBusiness? SelectedLicenseInfo
        {
            get { return _License; }
        }

        public ucDriverLicenseInfo() {
            InitializeComponent();
        }


        public void LoadInfo(int LicenseID) {

            _LicenseID = LicenseID;
            _License = clsLicenseBusiness.GetLicenseInfoByID(_LicenseID);

            if (_License == null) {
                MessageBox.Show($"Could not find License with ID = {_LicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAnswerLicenseID.Text = _License.LicenseID.ToString();
            lblAnswerDriverID.Text = _License.DriverID.ToString();
            lblAnswerIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblAnswerExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblAnswerIssueReason.Text = _License.IssueReasonText;
            lblAnswerIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblAnswerIsDetained.Text = "No"; // will be changed later

            if (string.IsNullOrWhiteSpace(_License.Notes))
                lblAnswerNotes.Text = "No Notes";
            else
                lblAnswerNotes.Text = _License.Notes;

            if (_License.LicenseClassInfo != null)
                lblAnswerClassName.Text = _License.LicenseClassInfo.ClassName;
            else
                lblAnswerClassName.Text = "N/A";

            if (_License.DriverInfo != null && _License.DriverInfo.PersonInfo != null)
            {
                lblAnswerName.Text = _License.DriverInfo.PersonInfo.FullName;
                lblAnswerNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
                lblAnswerDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();

                lblAnswerGendor.Text = (_License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female");

            }
            else
            {
                lblAnswerName.Text = "N/A";
                lblAnswerNationalNo.Text = "N/A";
                lblAnswerDateOfBirth.Text = "N/A";
                lblAnswerGendor.Text = "N/A";
            }

            _LoadPersonImage();

        }


        private void _LoadPersonImage()
        {
            if (_License == null || _License.DriverInfo == null || _License.DriverInfo.PersonInfo == null)
                return;


            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (string.IsNullOrEmpty(ImagePath))
            {

                 if (_License.DriverInfo.PersonInfo.Gendor == 0)
                    pbProfilePicture.Image = Properties.Resources.male;
                 else
                    pbProfilePicture.Image = Properties.Resources.female;
            }
            else if (File.Exists(ImagePath))
            {
                pbProfilePicture.ImageLocation = ImagePath;
            }
            else
            {
                MessageBox.Show("Could not find the person's image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
