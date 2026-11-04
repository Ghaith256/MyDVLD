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
    public class clsDriverBusiness {

        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsPersonBusiness? PersonInfo { get; set; }

        private DriverDTO _GetDriverDTO() {
            return new DriverDTO(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }


        public clsDriverBusiness() {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;

            this._Mode = enMode.AddNew;
        }

        private clsDriverBusiness(DriverDTO dto) {
            this.DriverID = dto.DriverID;
            this.PersonID = dto.PersonID;
            this.CreatedByUserID = dto.CreatedByUserID;
            this.CreatedDate = dto.CreatedDate;

            this.PersonInfo = clsPersonBusiness.Find(dto.PersonID);

            this._Mode = enMode.Update;
        }

        private bool _AddNewDriver() {
            this.DriverID = clsDriverDataAccess.AddNewDriver(this._GetDriverDTO());
            return (this.DriverID != -1);
        }

        private bool _UpdateDriver() {
            return clsDriverDataAccess.UpdateDriver(this._GetDriverDTO());
        }

        public bool Save() {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateDriver();
            }

            return false;
        }

        public static clsDriverBusiness? GetDriverInfoByDriverID(int DriverID) {
            DriverDTO? dto = clsDriverDataAccess.GetDriverInfoByID(DriverID);

            if (dto != null)
                return new clsDriverBusiness(dto);
            else
                return null;
        }

        public static clsDriverBusiness? GetDriverInfoByPersonID(int PersonID) {
            DriverDTO? dto = clsDriverDataAccess.GetDriverInfoByPersonID(PersonID);

            if (dto != null)
                return new clsDriverBusiness(dto);
            else
                return null;
        }

        public static DataTable GetLocalLicenses(int DriverID)
        {
            return clsDriverDataAccess.GetLocalLicenses(DriverID);
        }

        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return clsDriverDataAccess.GetInternationalLicenses(DriverID);
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();
        }


    }
}
