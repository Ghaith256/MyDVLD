using DVLD_DataAccess;
using DVLD_DTOs;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsTestAppointmentBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; } = -1;

        private clsTestAppointmentBusiness(TestAppointmentDTO dto)
        {
            this.TestAppointmentID = dto.TestAppointmentID;
            this.TestTypeID = dto.TestTypeID;
            this.LocalDrivingLicenseApplicationID = dto.LocalDrivingLicenseApplicationID;
            this.AppointmentDate = dto.AppointmentDate;
            this.PaidFees = dto.PaidFees;
            this.CreatedByUserID = dto.CreatedByUserID;
            this.IsLocked = dto.IsLocked;
            this.RetakeTestApplicationID = dto.RetakeTestApplicationID;

            Mode = enMode.Update;
        }

        public clsTestAppointmentBusiness() {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;

            Mode = enMode.AddNew;
        }

        public static clsTestAppointmentBusiness? GetTestAppointmentInfoByID(int TestAppointmentID)
        {
            TestAppointmentDTO? dto = clsTestAppointmentDataAccess.GetTestAppointmentInfoByID(TestAppointmentID);

            if (dto != null)
                return new clsTestAppointmentBusiness(dto);
            else
                return null;
        }

        public bool LockTestAppointment()
        {
            return clsTestAppointmentDataAccess.LockTestAppointment(this.TestAppointmentID);
        }

        public static int GetTotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID) {
            return clsTestAppointmentDataAccess.GetTotalTrialsPerTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        private TestAppointmentDTO _GetTestAppointmentDTO()
        {
            return new TestAppointmentDTO(
                this.TestAppointmentID,
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,
                this.PaidFees,
                this.CreatedByUserID,
                this.IsLocked,
                this.RetakeTestApplicationID
            );
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentDataAccess.AddNewTestAppointment(_GetTestAppointmentDTO());
            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentDataAccess.UpdateTestAppointment(_GetTestAppointmentDTO());
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateTestAppointment();
            }

            return false;
        }

        public static DataTable GetAllTestAppointmentsByLocalAppID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentDataAccess.GetAllTestAppointmentsByLocalAppID(LocalDrivingLicenseApplicationID, TestTypeID);
        }

    }
}