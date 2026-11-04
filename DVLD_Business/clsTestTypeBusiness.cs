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
    public class clsTestTypeBusiness {

        public int TestTypeID { set; get; }
        public string? TestTypeTitle { set; get; }
        public string? TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        private clsTestTypeBusiness(TestTypeDTO TestType) {
            this.TestTypeID = TestType.TestTypeID;
            this.TestTypeTitle = TestType.TestTypeTitle;
            this.TestTypeDescription = TestType.TestTypeDescription;
            this.TestTypeFees = TestType.TestTypeFees;
        }

        private TestTypeDTO _GetTestTypeDTO()
        {
            return new TestTypeDTO(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        public bool UpdateTestType() {
            return clsTestTypeDataAccess.UpdateTestType(_GetTestTypeDTO());
        }

        public static DataTable GetAllTestTypes() { 
            return clsTestTypeDataAccess.GetAllTestTypes();
        }

        public static clsTestTypeBusiness? GetTestTypeInfoByID(int TestTypeID) {
            TestTypeDTO? dto = clsTestTypeDataAccess.GetTestTypeInfoByID(TestTypeID);

            if (dto != null)
                return new clsTestTypeBusiness(dto);

            return null;
        }

    }
}
