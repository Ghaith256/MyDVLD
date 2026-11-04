using System;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsApplicationBusinessTests
    {
        private clsPersonBusiness _CreateTestPerson()
        {
            clsPersonBusiness person = new clsPersonBusiness();
            person.NationalNo = "A" + Guid.NewGuid().ToString("N").Substring(0, 8);
            person.FirstName = "Applicant";
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
        public void NewApplication_DefaultStatus_IsNew()
        {
            clsApplicationBusiness app = new clsApplicationBusiness();

            Assert.Equal(1, app.ApplicationStatus);
        }

        [Fact]
        public void AddApplication_ValidData_ReturnsTrueAndAssignsApplicationID()
        {
            clsPersonBusiness person = _CreateTestPerson();

            clsApplicationBusiness app = new clsApplicationBusiness();
            app.ApplicantPersonID = person.PersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = 1;
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = 15;
            app.CreatedByUserID = 1;

            bool isSaved = app.Save();

            Assert.True(isSaved);
            Assert.True(app.ApplicationID > 0);
            Assert.NotNull(app.PersonInfo);
            Assert.Equal(person.PersonID, app.PersonInfo.PersonID);

            clsApplicationBusiness.DeleteApplication(app.ApplicationID);
            clsPersonBusiness.Delete(person.PersonID);
        }

        [Theory]
        [InlineData(-1)]
        public void GetApplicationInfoByID_NonExistentID_ReturnsNull(int invalidID)
        {
            clsApplicationBusiness app = clsApplicationBusiness.GetApplicationInfoByID(invalidID);

            Assert.Null(app);
        }

        [Fact]
        public void UpdateApplication_ExistingApplication_UpdatesFieldsCorrectly()
        {
            clsPersonBusiness person = _CreateTestPerson();

            clsApplicationBusiness app = new clsApplicationBusiness();
            app.ApplicantPersonID = person.PersonID;
            app.ApplicationTypeID = 1;
            app.PaidFees = 15;
            app.CreatedByUserID = 1;
            app.Save();

            app.PaidFees = 20;
            bool isUpdated = app.Save();

            clsApplicationBusiness fetchedApp = clsApplicationBusiness.GetApplicationInfoByID(app.ApplicationID);

            Assert.True(isUpdated);
            Assert.NotNull(fetchedApp);
            Assert.Equal(20, fetchedApp.PaidFees);

            clsApplicationBusiness.DeleteApplication(app.ApplicationID);
            clsPersonBusiness.Delete(person.PersonID);
        }

        [Fact]
        public void Cancel_NewApplication_SetsStatusToCancelled()
        {
            clsPersonBusiness person = _CreateTestPerson();
            clsApplicationBusiness app = new clsApplicationBusiness();
            try
            {
                app.ApplicantPersonID = person.PersonID;
                app.ApplicationTypeID = 1;
                app.CreatedByUserID = 1;
                Assert.True(app.Save());

                bool isCancelled = app.Cancel();
                clsApplicationBusiness fetchedApp = clsApplicationBusiness.GetApplicationInfoByID(app.ApplicationID);

                Assert.True(isCancelled);
                Assert.Equal(2, fetchedApp.ApplicationStatus);
            }
            finally
            {
                clsApplicationBusiness.DeleteApplication(app.ApplicationID);
                clsPersonBusiness.Delete(person.PersonID);
            }
        }

        [Fact]
        public void Completed_NewApplication_SetsStatusToCompleted()
        {
            clsPersonBusiness person = _CreateTestPerson();

            clsApplicationBusiness app = new clsApplicationBusiness();
            app.ApplicantPersonID = person.PersonID;
            app.ApplicationTypeID = 1;
            app.CreatedByUserID = 1;
            app.Save();

            bool isCompleted = app.Completed();
            clsApplicationBusiness fetchedApp = clsApplicationBusiness.GetApplicationInfoByID(app.ApplicationID);

            Assert.True(isCompleted);
            Assert.NotNull(fetchedApp);
            Assert.Equal(3, fetchedApp.ApplicationStatus);

            clsApplicationBusiness.DeleteApplication(app.ApplicationID);
            clsPersonBusiness.Delete(person.PersonID);
        }

        [Fact]
        public void DeleteApplication_ExistingApplication_ReturnsTrue()
        {
            clsPersonBusiness person = _CreateTestPerson();

            clsApplicationBusiness app = new clsApplicationBusiness();
            app.ApplicantPersonID = person.PersonID;
            app.ApplicationTypeID = 1;
            app.CreatedByUserID = 1;
            app.Save();

            bool isDeleted = clsApplicationBusiness.DeleteApplication(app.ApplicationID);
            clsApplicationBusiness fetchedApp = clsApplicationBusiness.GetApplicationInfoByID(app.ApplicationID);

            Assert.True(isDeleted);
            Assert.Null(fetchedApp);

            clsPersonBusiness.Delete(person.PersonID);
        }
    }
}