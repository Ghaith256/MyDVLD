using System;
using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsInternationalLicenseBusinessTests
    {
        [Fact]
        public void GetInternationalLicenseInfoByID_NonExistentID_ReturnsNull()
        {
            clsInternationalLicenseBusiness license = clsInternationalLicenseBusiness.GetInternationalLicenseInfoByID(-1);

            Assert.Null(license);
        }

        [Fact]
        public void NewInternationalLicense_DefaultValues_AreCorrect()
        {
            clsInternationalLicenseBusiness license = new clsInternationalLicenseBusiness();

            Assert.Equal(-1, license.InternationalLicenseID);
            Assert.True(license.IsActive);
            Assert.Equal(6, license.ApplicationInfo.ApplicationTypeID); // النوع الافتراضي للرخصة الدولية

            // التحقق من أن تاريخ الانتهاء يبعد سنة تقريباً عن تاريخ الإصدار
            int yearDifference = license.ExpirationDate.Year - license.IssueDate.Year;
            Assert.Equal(1, yearDifference);
        }

        [Fact]
        public void GetDriverInternationalLicenses_NonExistentDriverID_ReturnsDataTable()
        {
            DataTable dt = clsInternationalLicenseBusiness.GetDriverInternationalLicenses(-1);

            Assert.NotNull(dt);
        }

        [Fact]
        public void GetAllInternationalLicenses_ReturnsDataTable()
        {
            DataTable dt = clsInternationalLicenseBusiness.GetAllInternationalLicenses();

            Assert.NotNull(dt);
        }
    }
}