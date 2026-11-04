using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsLicenseClassBusinessTests
    {
        [Fact]
        public void GetAllLicenseClasses_ReturnsNonEmptyDataTable()
        {
            DataTable dt = clsLicenseClassBusiness.GetAllLicenseClasses();

            Assert.NotNull(dt);
            Assert.True(dt.Rows.Count > 0);
        }

        [Fact]
        public void GetLicenseClassInfoByID_ValidID_ReturnsCorrectData()
        {
            int validID = 1;

            clsLicenseClassBusiness? licenseClass =
                clsLicenseClassBusiness.GetLicenseClassInfoByID(validID);

            Assert.NotNull(licenseClass);
            Assert.Equal(validID, licenseClass.LicenseClassID);
            Assert.False(string.IsNullOrEmpty(licenseClass.ClassName));
            Assert.True(licenseClass.ClassFees >= 0);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(9999)]
        public void GetLicenseClassInfoByID_InvalidID_ReturnsNull(int invalidID)
        {
            clsLicenseClassBusiness? licenseClass =
                clsLicenseClassBusiness.GetLicenseClassInfoByID(invalidID);

            Assert.Null(licenseClass);
        }
    }
}