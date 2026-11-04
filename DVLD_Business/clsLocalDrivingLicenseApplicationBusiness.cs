using DVLD_DataAccess;
using DVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplicationBusiness {

        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsApplicationBusiness? ApplicationInfo {  get; set; }

        private LocalDrivingLicenseApplicationDTO _GetApplicationDTO() {
            return new LocalDrivingLicenseApplicationDTO(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public clsLocalDrivingLicenseApplicationBusiness() {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;

            this.ApplicationInfo = new clsApplicationBusiness();

            this._Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplicationBusiness(LocalDrivingLicenseApplicationDTO dto)
        {
            this.LocalDrivingLicenseApplicationID = dto.LocalDrivingLicenseApplicationID;
            this.ApplicationID = dto.ApplicationID;
            this.LicenseClassID = dto.LicenseClassID;

            this.ApplicationInfo = clsApplicationBusiness.GetApplicationInfoByID(dto.ApplicationID);

            this._Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication() {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationDataAccess.AddNewLocalDrivingLicenseApplication(this._GetApplicationDTO());
            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication() {
            return clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingLicenseApplication(_GetApplicationDTO());
        }

        public static clsLocalDrivingLicenseApplicationBusiness? GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID) {
            
            LocalDrivingLicenseApplicationDTO? dto = clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID);

            if (dto != null)
                return new clsLocalDrivingLicenseApplicationBusiness(dto);
            else
                return null;
        }

        public bool Save() {

            if (!this.ApplicationInfo.Save())
                return false;

            this.ApplicationID = this.ApplicationInfo.ApplicationID;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication()) {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }

            return false;
        }

        public static clsLocalDrivingLicenseApplicationBusiness? GetLocalDrivingLicenseApplicationInfoByPersonID(int PersonID) {
            LocalDrivingLicenseApplicationDTO? dto = clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplicationInfoByPersonID(PersonID);

            if (dto != null)
                return new clsLocalDrivingLicenseApplicationBusiness(dto);
            else
                return null;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications() {
            return clsLocalDrivingLicenseApplicationDataAccess.GetAllLocalDrivingLicenseApplications();
        }

        public static bool DoesActiveApplicationExist(int PersonID, int LicenseClassID) {
            return clsLocalDrivingLicenseApplicationDataAccess.DoesActiveApplicationExist(PersonID, LicenseClassID);
        }

        public bool Cancel() {
            return this.ApplicationInfo.Cancel();
        }

        public bool Completed() {
            return this.ApplicationInfo.Completed();
        }

        public bool Delete() {

            bool IsLocalDeleted = clsLocalDrivingLicenseApplicationDataAccess.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);

            if (!IsLocalDeleted)
                return false;

            return clsApplicationBusiness.DeleteApplication(this.ApplicationID);
        }

        public static int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetPassedTestsCount(LocalDrivingLicenseApplicationID);
        }

        public int GetPassedTestCount()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetPassedTestsCount(this.LocalDrivingLicenseApplicationID);
        }

        public int GetActiveLicenseID()
        {
            clsLicenseBusiness? License = clsLicenseBusiness.GetLicenseInfoByApplicationID(this.ApplicationID);
            return License != null ? License.LicenseID : -1;
        }
    }
}
