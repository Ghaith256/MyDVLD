using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsApplicationTypeBusinessTests
    {
        [Fact]
        public void GetAllApplicationTypes_ReturnsNonEmptyDataTable()
        {
            DataTable dt = clsApplicationTypeBusiness.GetAllApplicationTypes();

            Assert.NotNull(dt);
            Assert.True(dt.Rows.Count > 0);
        }

        [Fact]
        public void GetApplicationTypeInfoByID_ValidID_ReturnsCorrectData()
        {
            int validID = 1;
            clsApplicationTypeBusiness? appType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(validID);

            Assert.NotNull(appType);
            Assert.Equal(validID, appType.ApplicationTypeID);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(9999)]
        public void GetApplicationTypeInfoByID_InvalidID_ReturnsNull(int invalidID)
        {
            clsApplicationTypeBusiness? appType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(invalidID);

            Assert.Null(appType);
        }

        [Fact]
        public void UpdateApplicationType_ValidData_ReturnsTrue()
        {
            clsApplicationTypeBusiness? appType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(1);

            Assert.NotNull(appType);

            string originalTitle = appType.ApplicationTypeTitle ?? "";

            appType.ApplicationTypeTitle = "Updated Title";
            bool isUpdated = appType.UpdateApplicationType();

            Assert.True(isUpdated);

            appType.ApplicationTypeTitle = originalTitle;
            bool isRestored = appType.UpdateApplicationType();

            Assert.True(isRestored);
        }
    }
}