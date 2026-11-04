using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsTestBusinessTests
    {
        [Fact]
        public void NewTest_DefaultValues_AreCorrect()
        {
            clsTestBusiness test = new clsTestBusiness();

            Assert.Equal(-1, test.TestID);
            Assert.Equal(-1, test.TestAppointmentID);
            Assert.False(test.TestResult);
            Assert.Equal(string.Empty, test.Notes);
            Assert.Equal(-1, test.CreatedByUserID);
        }
    }
}