using DVLD_Business;
using DVLD_DataAccess;
using System;
using System.Data;
using Xunit;

namespace DVLD_Test
{
    public class clsUserBusinessTests
    {
        private clsPersonBusiness _CreateTestPerson()
        {
            clsPersonBusiness person = new clsPersonBusiness();

            person.NationalNo = "U" + Guid.NewGuid().ToString("N").Substring(0, 8);
            person.FirstName = "User";
            person.SecondName = "Test";
            person.LastName = "Account";
            person.DateOfBirth = new DateTime(1992, 5, 5);
            person.Gendor = 0;
            person.Address = "Amman";
            person.Phone = "0790000000";
            person.NationalityCountryID = 1;

            person.Save();

            return person;
        }

        [Fact]
        public void FindByUserID_NonExistentID_ReturnsNull()
        {
            clsUserBusiness? user = clsUserBusiness.FindByUserID(-1);

            Assert.Null(user);
        }

        [Fact]
        public void FindByPersonID_NonExistentPersonID_ReturnsNull()
        {
            clsUserBusiness? user = clsUserBusiness.FindByPersonID(-1);

            Assert.Null(user);
        }

        [Fact]
        public void NewUser_DefaultValues_AreCorrect()
        {
            clsUserBusiness user = new clsUserBusiness();

            Assert.Equal(-1, user.UserID);
            Assert.Equal(-1, user.PersonID);
            Assert.True(user.IsActive);
            Assert.Equal(string.Empty, user.Username);
        }

        [Fact]
        public void AddUser_ValidData_HashesPasswordAndSavesSuccessfully()
        {
            clsPersonBusiness person = _CreateTestPerson();

            Assert.True(person.PersonID > 0);

            clsUserBusiness user = new clsUserBusiness();

            user.PersonID = person.PersonID;
            user.Username = "usr_" + Guid.NewGuid().ToString("N").Substring(0, 6);
            user.Password = "PlainPassword123";
            user.IsActive = true;

            bool isSaved = user.Save();

            Assert.True(isSaved);
            Assert.True(user.UserID > 0);
            Assert.StartsWith("$2", user.Password);

            clsUserDataAccess.DeleteUser(user.UserID);
            clsPersonBusiness.Delete(person.PersonID);
        }

        [Fact]
        public void Login_ValidCredentials_ReturnsUserInstance()
        {
            clsPersonBusiness person = _CreateTestPerson();

            string username =
                "login_" + Guid.NewGuid().ToString("N").Substring(0, 6);

            string rawPassword = "SecretPassword!1";

            clsUserBusiness user = new clsUserBusiness();

            user.PersonID = person.PersonID;
            user.Username = username;
            user.Password = rawPassword;
            user.Save();

            clsUserBusiness? loggedInUser =
                clsUserBusiness.Login(username, rawPassword);

            Assert.NotNull(loggedInUser);
            Assert.Equal(user.UserID, loggedInUser.UserID);

            clsUserDataAccess.DeleteUser(user.UserID);
            clsPersonBusiness.Delete(person.PersonID);
        }

        [Fact]
        public void Login_InvalidPassword_ReturnsNull()
        {
            clsUserBusiness? loggedInUser =
                clsUserBusiness.Login("NonExistentUser", "WrongPassword");

            Assert.Null(loggedInUser);
        }

        [Fact]
        public void GetAllUsers_ReturnsDataTable()
        {
            DataTable dt = clsUserBusiness.GetAllUsers();

            Assert.NotNull(dt);
        }

        [Fact]
        public void IsUserExist_NonExistentUsername_ReturnsFalse()
        {
            bool exists =
                clsUserBusiness.IsUserExist("FakeUsernameXYZ123");

            Assert.False(exists);
        }
    }
}