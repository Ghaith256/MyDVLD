using System;
using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsDetainedLicenseBusinessTests
    {
        [Fact]
        public void GetDetainedLicenseInfoByID_NonExistentID_ReturnsNull()
        {
            clsDetainedLicenseBusiness detain = clsDetainedLicenseBusiness.GetDetainedLicenseInfoByID(-1);

            Assert.Null(detain);
        }

        [Fact]
        public void GetActiveDetainInfoByLicenseID_NonExistentLicenseID_ReturnsNull()
        {
            clsDetainedLicenseBusiness detain = clsDetainedLicenseBusiness.GetActiveDetainInfoByLicenseID(-1);

            Assert.Null(detain);
        }

        [Fact]
        public void NewDetainedLicense_DefaultValues_AreCorrect()
        {
            clsDetainedLicenseBusiness detain = new clsDetainedLicenseBusiness();

            Assert.Equal(-1, detain.DetainID);
            Assert.False(detain.IsReleased);
            Assert.Null(detain.ReleaseDate);
            Assert.Null(detain.ReleasedByUserID);
            Assert.Null(detain.ReleaseApplicationID);
            Assert.Equal(0, detain.FineFees);
        }

        [Fact]
        public void GetAllDetainedLicenses_ReturnsDataTable()
        {
            DataTable dt = clsDetainedLicenseBusiness.GetAllDetainedLicenses();

            Assert.NotNull(dt);
        }
    }
}