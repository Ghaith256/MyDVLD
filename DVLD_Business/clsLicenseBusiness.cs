using DVLD_DataAccess;
using DVLD_DTOs;
using System;

namespace DVLD_Business
{
    public class clsLicenseBusiness
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsDriverBusiness DriverInfo { get; set; }
        public clsLicenseClassBusiness LicenseClassInfo { get; set; }

        public string IssueReasonText
        {
            get
            {
                switch (IssueReason)
                {
                    case 1:
                        return "First Time";
                    case 2:
                        return "Renew";
                    case 3:
                        return "Replacement for Lost";
                    case 4:
                        return "Replacement for Damaged";
                    default:
                        return "Unknown";
                }
            }
        }

        private LicenseDTO _GetLicenseDTO()
        {
            return new LicenseDTO(
                LicenseID,
                ApplicationID,
                DriverID,
                LicenseClassID,
                IssueDate,
                ExpirationDate,
                Notes,
                PaidFees,
                IsActive,
                IssueReason,
                CreatedByUserID);
        }

        public clsLicenseBusiness()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
            IsActive = true;
            IssueReason = 1;
            CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        private clsLicenseBusiness(LicenseDTO license)
        {
            LicenseID = license.LicenseID;
            ApplicationID = license.ApplicationID;
            DriverID = license.DriverID;
            LicenseClassID = license.LicenseClassID;
            IssueDate = license.IssueDate;
            ExpirationDate = license.ExpirationDate;
            Notes = license.Notes;
            PaidFees = license.PaidFees;
            IsActive = license.IsActive;
            IssueReason = license.IssueReason;
            CreatedByUserID = license.CreatedByUserID;

            DriverInfo = clsDriverBusiness.GetDriverInfoByDriverID(DriverID);
            LicenseClassInfo = clsLicenseClassBusiness.GetLicenseClassInfoByID(LicenseClassID);

            _Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            LicenseID = clsLicenseDataAccess.AddNewLicense(_GetLicenseDTO());
            return LicenseID != -1;
        }

        private bool _UpdateLicense()
        {
            return clsLicenseDataAccess.UpdateLicense(_GetLicenseDTO());
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateLicense();
            }

            return false;
        }

        public static clsLicenseBusiness? GetLicenseInfoByID(int licenseID)
        {
            LicenseDTO? dto = clsLicenseDataAccess.GetLicenseInfoByID(licenseID);

            return dto != null ? new clsLicenseBusiness(dto) : null;
        }

        public static clsLicenseBusiness? GetLicenseInfoByApplicationID(int applicationID)
        {
            LicenseDTO? dto = clsLicenseDataAccess.GetLicenseInfoByApplicationID(applicationID);

            return dto != null ? new clsLicenseBusiness(dto) : null;
        }

        public int GetActiveLicenseID()
        {
            clsLicenseBusiness? license = GetLicenseInfoByApplicationID(ApplicationID);

            return license != null ? license.LicenseID : -1;
        }
    }
}