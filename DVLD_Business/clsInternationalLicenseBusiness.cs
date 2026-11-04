using DVLD_DataAccess;
using DVLD_DTOs;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsInternationalLicenseBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsApplicationBusiness? ApplicationInfo { get; set; }
        public clsDriverBusiness? DriverInfo { get; set; }

        private InternationalLicenseDTO _GetInternationalLicenseDTO()
        {
            return new InternationalLicenseDTO(
                InternationalLicenseID,
                ApplicationID,
                DriverID,
                IssuedUsingLocalLicenseID,
                IssueDate,
                ExpirationDate,
                IsActive,
                CreatedByUserID);
        }

        public clsInternationalLicenseBusiness()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now.AddYears(1);
            IsActive = true;
            CreatedByUserID = -1;

            ApplicationInfo = new clsApplicationBusiness
            {
                ApplicationTypeID = 6
            };

            Mode = enMode.AddNew;
        }

        public clsInternationalLicenseBusiness(InternationalLicenseDTO dto)
        {
            InternationalLicenseID = dto.InternationalLicenseID;
            ApplicationID = dto.ApplicationID;
            DriverID = dto.DriverID;
            IssuedUsingLocalLicenseID = dto.IssuedUsingLocalLicenseID;
            IssueDate = dto.IssueDate;
            ExpirationDate = dto.ExpirationDate;
            IsActive = dto.IsActive;
            CreatedByUserID = dto.CreatedByUserID;

            ApplicationInfo = clsApplicationBusiness.GetApplicationInfoByID(ApplicationID);
            DriverInfo = clsDriverBusiness.GetDriverInfoByDriverID(DriverID);

            Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            InternationalLicenseID =
                clsInternationalLicenseDataAccess.AddNewInternationalLicense(
                    _GetInternationalLicenseDTO());

            return InternationalLicenseID != -1;
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseDataAccess.UpdateInternationalLicense(
                _GetInternationalLicenseDTO());
        }

        public bool Save()
        {
            if (ApplicationInfo == null || !ApplicationInfo.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }

            return false;
        }

        public static clsInternationalLicenseBusiness? GetInternationalLicenseInfoByID(
            int internationalLicenseID)
        {
            InternationalLicenseDTO? dto =
                clsInternationalLicenseDataAccess.GetInternationalLicenseInfoByID(
                    internationalLicenseID);

            return dto != null
                ? new clsInternationalLicenseBusiness(dto)
                : null;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseDataAccess.GetAllInternationalLicenses();
        }

        public static DataTable GetDriverInternationalLicenses(int driverID)
        {
            return clsInternationalLicenseDataAccess.GetDriverInternationalLicenses(driverID);
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int driverID)
        {
            return clsInternationalLicenseDataAccess.GetActiveInternationalLicenseIDByDriverID(
                driverID);
        }
    }
}