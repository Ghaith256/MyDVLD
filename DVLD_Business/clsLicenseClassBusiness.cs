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
    public class clsLicenseClassBusiness {
        
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private clsLicenseClassBusiness(LicenseClassDTO dto)
        {
            this.LicenseClassID = dto.LicenseClassID;
            this.ClassName = dto.ClassName;
            this.ClassDescription = dto.ClassDescription;
            this.MinimumAllowedAge = dto.MinimumAllowedAge;
            this.DefaultValidityLength = dto.DefaultValidityLength;
            this.ClassFees = dto.ClassFees;
        }

        public static DataTable GetAllLicenseClasses() {
            return clsLicenseClassDataAccess.GetAllLicenseClasses();
        }

        public static clsLicenseClassBusiness? GetLicenseClassInfoByID(int licenseClassID) {
            LicenseClassDTO? dto = clsLicenseClassDataAccess.GetLicenseClassInfoByID(licenseClassID);

            if (dto != null)
                return new clsLicenseClassBusiness(dto);

            return null;
        }


    }
}
