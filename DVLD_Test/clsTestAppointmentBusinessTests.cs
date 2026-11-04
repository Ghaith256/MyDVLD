using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsTestAppointmentBusinessTests
    {
        [Fact]
        public void GetTestAppointmentInfoByID_NonExistentID_ReturnsNull()
        {
            clsTestAppointmentBusiness? appointment =
                clsTestAppointmentBusiness.GetTestAppointmentInfoByID(-1);

            Assert.Null(appointment);
        }

        [Fact]
        public void NewTestAppointment_DefaultValues_AreCorrect()
        {
            clsTestAppointmentBusiness appointment =
                new clsTestAppointmentBusiness();

            Assert.Equal(-1, appointment.TestAppointmentID);
            Assert.Equal(-1, appointment.TestTypeID);
            Assert.Equal(-1, appointment.LocalDrivingLicenseApplicationID);
            Assert.False(appointment.IsLocked);
            Assert.Equal(-1, appointment.RetakeTestApplicationID);
            Assert.Equal(0, appointment.PaidFees);
        }

        [Fact]
        public void GetAllTestAppointmentsByLocalAppID_NonExistentID_ReturnsDataTable()
        {
            DataTable dt =
                clsTestAppointmentBusiness.GetAllTestAppointmentsByLocalAppID(-1, 1);

            Assert.NotNull(dt);
        }

        [Fact]
        public void GetTotalTrialsPerTest_NonExistentID_ReturnsZeroOrValidCount()
        {
            int trials =
                clsTestAppointmentBusiness.GetTotalTrialsPerTest(-1, 1);

            Assert.True(trials >= 0);
        }
    }
}