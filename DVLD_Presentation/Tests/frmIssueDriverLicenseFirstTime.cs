using DVLD_Business;
using DVLD_Presentation.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests
{
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplicationBusiness? _LocalDrivingLicenseApplication;
        private int _CreatedLicenseID = -1;

        public frmIssueDriverLicenseFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_LocalDrivingLicenseApplication.GetPassedTestCount() < 3)
            {
                MessageBox.Show("Person should pass all tests first.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucLocalDrivingLicenseApplicationInfo.LoadLocalApplicationData(_LocalDrivingLicenseApplicationID);
            ucApplicationBasicInfo.LoadApplicationData(_LocalDrivingLicenseApplication.ApplicationID);
            ucLocalDrivingLicenseApplicationInfo.EnableShowLicense = false;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license for this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (_LocalDrivingLicenseApplication == null || _LocalDrivingLicenseApplication.ApplicationInfo == null)
            {
                MessageBox.Show("Application details are missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. الوصول لرقم الشخص من خلال الكائن الفرعي ApplicationInfo
            int ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonID;

            // 2. البحث عن السائق أو إنشاء سجل جديد
            clsDriverBusiness? Driver = clsDriverBusiness.GetDriverInfoByPersonID(ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDriverBusiness();
                Driver.PersonID = ApplicantPersonID;
                Driver.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                Driver.CreatedDate = DateTime.Now;

                if (!Driver.Save())
                {
                    MessageBox.Show("Failed to create a new driver record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 3. جلب بيانات صنف الرخصة بشكل مستقل لمعرفة مدة الصلاحية والرسوم
            clsLicenseClassBusiness? LicenseClass = clsLicenseClassBusiness.GetLicenseClassInfoByID(_LocalDrivingLicenseApplication.LicenseClassID);

            if (LicenseClass == null)
            {
                MessageBox.Show("License class details could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. تجهيز بيانات الرخصة الجديدة
            clsLicenseBusiness License = new clsLicenseBusiness();
            License.ApplicationID = _LocalDrivingLicenseApplication.ApplicationID;
            License.DriverID = Driver.DriverID;
            License.LicenseClassID = _LocalDrivingLicenseApplication.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            License.PaidFees = LicenseClass.ClassFees;
            License.Notes = txtNotes.Text.Trim();
            License.IsActive = true;
            License.IssueReason = 1; // 1 = First Time Issue
            License.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            // 5. حفظ الرخصة وتحديث حالة الطلب
            if (License.Save())
            {
                _CreatedLicenseID = License.LicenseID;

                // استدعاء دالة Completed() المباشرة من الكلاس الخاص بك
                if (_LocalDrivingLicenseApplication.Completed())
                {
                    MessageBox.Show("License Issued Successfully with ID = " + _CreatedLicenseID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnIssue.Enabled = false;
                    txtNotes.Enabled = false;
                    ucLocalDrivingLicenseApplicationInfo.EnableShowLicense = true;
                }
                else
                {
                    MessageBox.Show("License was created, but failed to update application status to Completed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("License Was Not Issued Successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}