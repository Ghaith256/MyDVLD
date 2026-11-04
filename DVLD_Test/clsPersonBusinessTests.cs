using System;
using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsPersonBusinessTests
    {
        private clsPersonBusiness _CreateTestPerson()
        {
            clsPersonBusiness person = new clsPersonBusiness();

            person.NationalNo = "N" + Guid.NewGuid().ToString("N").Substring(0, 8);
            person.FirstName = "Ahmad";
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
        public void AddPerson_ValidData_ReturnsTrueAndAssignsPersonID()
        {
            clsPersonBusiness person = new clsPersonBusiness();

            person.NationalNo = "T" + Guid.NewGuid().ToString("N").Substring(0, 8);
            person.FirstName = "Test";
            person.SecondName = "User";
            person.LastName = "Automated";
            person.DateOfBirth = new DateTime(1995, 1, 1);
            person.Gendor = 0;
            person.Address = "Test Address";
            person.Phone = "0790000000";
            person.NationalityCountryID = 1;

            bool isSaved = person.Save();

            Assert.True(isSaved);
            Assert.True(person.PersonID > 0);

            clsPersonBusiness.Delete(person.PersonID);
        }

        [Fact]
        public void AddPerson_ThenFindByID_ReturnsSamePersonData()
        {
            clsPersonBusiness newPerson = _CreateTestPerson();

            clsPersonBusiness? fetchedPerson =
                clsPersonBusiness.Find(newPerson.PersonID);

            Assert.NotNull(fetchedPerson);
            Assert.Equal(newPerson.NationalNo, fetchedPerson.NationalNo);
            Assert.Equal(newPerson.FirstName, fetchedPerson.FirstName);

            clsPersonBusiness.Delete(newPerson.PersonID);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void FindByID_NonExistentID_ReturnsNull(int invalidID)
        {
            clsPersonBusiness? result = clsPersonBusiness.Find(invalidID);

            Assert.Null(result);
        }

        [Fact]
        public void UpdatePerson_ExistingPerson_UpdatesFieldsCorrectly()
        {
            clsPersonBusiness person = _CreateTestPerson();

            person.FirstName = "UpdatedName";
            person.Phone = "0770000000";

            bool isUpdated = person.Save();

            clsPersonBusiness? fetchedPerson =
                clsPersonBusiness.Find(person.PersonID);

            Assert.True(isUpdated);
            Assert.NotNull(fetchedPerson);
            Assert.Equal("UpdatedName", fetchedPerson.FirstName);
            Assert.Equal("0770000000", fetchedPerson.Phone);

            clsPersonBusiness.Delete(person.PersonID);
        }

        [Fact]
        public void DeletePerson_ExistingPersonNoDependencies_ReturnsTrue()
        {
            clsPersonBusiness person = _CreateTestPerson();

            bool isDeleted = clsPersonBusiness.Delete(person.PersonID);

            clsPersonBusiness? fetchedPerson =
                clsPersonBusiness.Find(person.PersonID);

            Assert.True(isDeleted);
            Assert.Null(fetchedPerson);
        }

        [Fact]
        public void IsPersonExist_ByID_ExistingPerson_ReturnsTrue()
        {
            clsPersonBusiness person = _CreateTestPerson();

            bool exists = clsPersonBusiness.IsPersonExist(person.PersonID);

            Assert.True(exists);

            clsPersonBusiness.Delete(person.PersonID);
        }

        [Theory]
        [InlineData(-1)]
        public void IsPersonExist_ByID_NonExistentPerson_ReturnsFalse(int invalidID)
        {
            bool exists = clsPersonBusiness.IsPersonExist(invalidID);

            Assert.False(exists);
        }

        [Fact]
        public void GetAllCountries_ReturnsNonEmptyDataTable()
        {
            DataTable dtCountries = clsPersonBusiness.GetAllCountries();

            Assert.NotNull(dtCountries);
            Assert.True(dtCountries.Rows.Count > 0);
        }
    }
}