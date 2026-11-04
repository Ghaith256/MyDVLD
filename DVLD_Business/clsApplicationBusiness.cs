using DVLD_DataAccess;
using DVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationBusiness
    {

        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsPersonBusiness? PersonInfo
        {
            get
            {
                if (this.ApplicantPersonID != -1)
                    return clsPersonBusiness.Find(this.ApplicantPersonID);

                return null;
            }
        }

        public clsApplicationBusiness()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        private clsApplicationBusiness(ApplicationDTO Application)
        {
            this.ApplicationID = Application.ApplicationID;
            this.ApplicantPersonID = Application.ApplicantPersonID;
            this.ApplicationDate = Application.ApplicationDate;
            this.ApplicationTypeID = Application.ApplicationTypeID;
            this.ApplicationStatus = Application.ApplicationStatus;
            this.LastStatusDate = Application.LastStatusDate;
            this.PaidFees = Application.PaidFees;
            this.CreatedByUserID = Application.CreatedByUserID;

            _Mode = enMode.Update;
        }

        private ApplicationDTO _GetApplicationDTO()
        {
            return new ApplicationDTO(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateApplication();

            }

            return false;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication(this._GetApplicationDTO());
            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(this._GetApplicationDTO());
        }

        public static clsApplicationBusiness? GetApplicationInfoByID(int ApplicationID)
        {
            ApplicationDTO? dto = clsApplicationDataAccess.GetApplicationInfoByID(ApplicationID);

            if (dto != null)
                return new clsApplicationBusiness(dto);
            else
                return null;
        }

        public bool Cancel()
        {
            return clsApplicationDataAccess.UpdateStatus(this.ApplicationID, 2); 
        }

        public bool Completed()
        {
            return clsApplicationDataAccess.UpdateStatus(this.ApplicationID, 3);  
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationDataAccess.DeleteApplication(ApplicationID); 
        }
    }
}