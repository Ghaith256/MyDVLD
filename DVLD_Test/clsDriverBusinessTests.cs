using System;
using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsDriverBusinessTests
    {
        private clsPersonBusiness _CreateTestPerson()
        {
            clsPersonBusiness person = new clsPersonBusiness();
            person.NationalNo = "D" + Guid.NewGuid().ToString("N").Substring(0, 8);
            person.FirstName = "Driver";
            person.SecondName = "Test";
            person.LastName = "User";
            person.DateOfBirth = new DateTime(1990, 1, 1);
            person.Gendor = 0;
            person.Address = "Amman, Jordan";
            person.Phone = "0790000000";
            person.NationalityCountryID = 1;
            person.Save();
            return person;
        }

        [Fact]
        public void AddDriver_ValidPersonID_ReturnsTrueAndAssignsDriverID()
        {
            clsPersonBusiness person = _CreateTestPerson();

            Assert.True(person.PersonID > 0);

            clsDriverBusiness driver = new clsDriverBusiness();
            driver.PersonID = person.PersonID;
            driver.CreatedByUserID = 1;
            driver.CreatedDate = DateTime.Now;

            bool isSaved = driver.Save();

            Assert.True(isSaved);
            Assert.True(driver.DriverID > 0);

            clsDriverBusiness? fetchedDriver = clsDriverBusiness.GetDriverInfoByDriverID(driver.DriverID);

            Assert.NotNull(fetchedDriver);
            Assert.Equal(person.PersonID, fetchedDriver.PersonID);

            clsPersonBusiness.Delete(person.PersonID);
        }

        [Fact]
        public void GetDriverInfoByDriverID_NonExistentID_ReturnsNull()
        {
            clsDriverBusiness? driver = clsDriverBusiness.GetDriverInfoByDriverID(-1);

            Assert.Null(driver);
        }

        [Fact]
        public void GetDriverInfoByPersonID_NonExistentPersonID_ReturnsNull()
        {
            clsDriverBusiness? driver = clsDriverBusiness.GetDriverInfoByPersonID(-1);

            Assert.Null(driver);
        }

        [Fact]
        public void GetAllDrivers_ReturnsDataTable()
        {
            DataTable dt = clsDriverBusiness.GetAllDrivers();

            Assert.NotNull(dt);
        }
    }
}