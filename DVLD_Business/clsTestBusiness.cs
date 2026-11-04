using DVLD_DataAccess;
using DVLD_DTOs;
using System;

namespace DVLD_Business
{
    public class clsTestBusiness
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTestBusiness()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = string.Empty;
            this.CreatedByUserID = -1;
        }

        private TestDTO _GetTestDTO()
        {
            return new TestDTO(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public bool AddNewTest()
        {
            this.TestID = clsTestDataAccess.AddNewTest(this._GetTestDTO());
            return (this.TestID != -1);
        }
    }
}