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
    public class clsApplicationTypeBusiness {

        public int ApplicationTypeID { set; get; }
        public string? ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        private clsApplicationTypeBusiness(ApplicationTypeDTO ApplicationType) { 
            this.ApplicationTypeID = ApplicationType.ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationType.ApplicationTypeTitle;
            this.ApplicationFees = ApplicationType.ApplicationFees;
        }

        public bool UpdateApplicationType() {
            return clsApplicationTypeDataAccess.UpdateApplicationType(_GetApplicationTypeDTO());
        }

        public static DataTable GetAllApplicationTypes() {
            return clsApplicationTypeDataAccess.GetAllApplicationTypes();
        }

        private ApplicationTypeDTO _GetApplicationTypeDTO()
        {
            return new ApplicationTypeDTO(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public static clsApplicationTypeBusiness? GetApplicationTypeInfoByID(int applicationTypeID) {
            ApplicationTypeDTO? dto = clsApplicationTypeDataAccess.GetApplicationTypeInfoByID(applicationTypeID);

            if (dto != null)
                return new clsApplicationTypeBusiness(dto);

            return null;
        }


    }
}
