using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsLocalDrivingLicenseApplicationBusinessTests
    {
        [Fact]
        public void GetLocalDrivingLicenseApplicationInfoByID_NonExistentID_ReturnsNull()
        {
            clsLocalDrivingLicenseApplicationBusiness? localApp =
                clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(-1);

            Assert.Null(localApp);
        }

        [Fact]
        public void GetLocalDrivingLicenseApplicationInfoByPersonID_NonExistentPersonID_ReturnsNull()
        {
            clsLocalDrivingLicenseApplicationBusiness? localApp =
                clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByPersonID(-1);

            Assert.Null(localApp);
        }

        [Fact]
        public void NewLocalDrivingLicenseApplication_DefaultValues_AreCorrect()
        {
            clsLocalDrivingLicenseApplicationBusiness localApp =
                new clsLocalDrivingLicenseApplicationBusiness();

            Assert.Equal(-1, localApp.LocalDrivingLicenseApplicationID);
            Assert.Equal(-1, localApp.ApplicationID);
            Assert.Equal(-1, localApp.LicenseClassID);
            Assert.NotNull(localApp.ApplicationInfo);
        }

        [Fact]
        public void GetAllLocalDrivingLicenseApplications_ReturnsDataTable()
        {
            DataTable dt =
                clsLocalDrivingLicenseApplicationBusiness.GetAllLocalDrivingLicenseApplications();

            Assert.NotNull(dt);
        }

        [Fact]
        public void DoesActiveApplicationExist_NonExistent_ReturnsFalse()
        {
            bool exists =
                clsLocalDrivingLicenseApplicationBusiness.DoesActiveApplicationExist(-1, 1);

            Assert.False(exists);
        }

        [Fact]
        public void GetPassedTestsCount_NonExistentID_ReturnsZero()
        {
            int passedTests =
                clsLocalDrivingLicenseApplicationBusiness.GetPassedTestsCount(-1);

            Assert.Equal(0, passedTests);
        }
    }
}