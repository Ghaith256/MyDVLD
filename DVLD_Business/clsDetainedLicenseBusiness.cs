using DVLD_DataAccess;
using DVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Business
{
    public class clsDetainedLicenseBusiness {
        
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public clsLicenseBusiness? LicenseInfo { get; set; }

        private DetainedLicenseDTO _GetDetainedLicenseDTO() {
            return new DetainedLicenseDTO(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public clsDetainedLicenseBusiness()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = null;
            this.ReleasedByUserID = null;
            this.ReleaseApplicationID = null;

            this._Mode = enMode.AddNew;
        }

        private clsDetainedLicenseBusiness(DetainedLicenseDTO dto)
        {
            this.DetainID = dto.DetainID;
            this.LicenseID = dto.LicenseID;
            this.DetainDate = dto.DetainDate;
            this.FineFees = dto.FineFees;
            this.CreatedByUserID = dto.CreatedByUserID;
            this.IsReleased = dto.IsReleased;
            this.ReleaseDate = dto.ReleaseDate;
            this.ReleasedByUserID = dto.ReleasedByUserID;
            this.ReleaseApplicationID = dto.ReleaseApplicationID;

            this.LicenseInfo = clsLicenseBusiness.GetLicenseInfoByID(this.LicenseID);

            this._Mode = enMode.Update;
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetainedLicenseDataAccess.AddNewDetainedLicense(this._GetDetainedLicenseDTO());
            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseDataAccess.UpdateDetainedLicense(this._GetDetainedLicenseDTO());
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateDetainedLicense();
            }

            return false;
        }

        public static clsDetainedLicenseBusiness? GetDetainedLicenseInfoByID(int DetainID)
        {
            DetainedLicenseDTO? dto = clsDetainedLicenseDataAccess.GetDetainedLicenseInfoByID(DetainID);

            if (dto != null)
                return new clsDetainedLicenseBusiness(dto);
            else
                return null;
        }

        public static clsDetainedLicenseBusiness? GetActiveDetainInfoByLicenseID(int LicenseID)
        {
            DetainedLicenseDTO? dto = clsDetainedLicenseDataAccess.GetActiveDetainInfoByLicenseID(LicenseID);

            if (dto != null)
                return new clsDetainedLicenseBusiness(dto);
            else
                return null;
        }

        public bool Release(int ReleasedByUserID, int ReleaseApplicationID) {
            this.IsReleased = true;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            return this.Save();
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseDataAccess.GetAllDetainedLicenses();
        }


    }
}