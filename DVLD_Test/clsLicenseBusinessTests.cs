using System;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsLicenseBusinessTests
    {
        // دالة مساعدة لإنشاء بيئة متكاملة (شخص + سائق + طلب + صنف رخصة) لتجربة الرخصة
        private int _CreateValidApplicationAndDriver()
        {
            clsPersonBusiness person = new clsPersonBusiness();
            person.NationalNo = "L" + Guid.NewGuid().ToString("N").Substring(0, 8);
            person.FirstName = "License";
            person.SecondName = "Test";
            person.LastName = "User";
            person.DateOfBirth = new DateTime(1995, 1, 1);
            person.Gendor = 0;
            person.Address = "Amman";
            person.Phone = "0790000000";
            person.NationalityCountryID = 1;
            person.Save();

            clsDriverBusiness driver = new clsDriverBusiness();
            driver.PersonID = person.PersonID;
            driver.CreatedByUserID = 1;
            driver.Save();

            return driver.DriverID;
        }

        [Fact]
        public void GetLicenseInfoByID_NonExistentID_ReturnsNull()
        {
            clsLicenseBusiness license = clsLicenseBusiness.GetLicenseInfoByID(-1);

            Assert.Null(license);
        }

        [Fact]
        public void GetLicenseInfoByApplicationID_NonExistentID_ReturnsNull()
        {
            clsLicenseBusiness license = clsLicenseBusiness.GetLicenseInfoByApplicationID(-1);

            Assert.Null(license);
        }

        [Theory]
        [InlineData(1, "First Time")]
        [InlineData(2, "Renew")]
        [InlineData(3, "Replacement for Lost")]
        [InlineData(4, "Replacement for Damaged")]
        [InlineData(99, "Unknown")]
        public void IssueReasonText_ReturnsCorrectLabelForEachReasonCode(byte reasonCode, string expectedText)
        {
            clsLicenseBusiness license = new clsLicenseBusiness();
            license.IssueReason = reasonCode;

            Assert.Equal(expectedText, license.IssueReasonText);
        }

        [Fact]
        public void NewLicense_DefaultValues_AreCorrect()
        {
            clsLicenseBusiness license = new clsLicenseBusiness();

            Assert.Equal(-1, license.LicenseID);
            Assert.True(license.IsActive);
            Assert.Equal(1, license.IssueReason);
            Assert.Equal("", license.Notes);
        }
    }
}