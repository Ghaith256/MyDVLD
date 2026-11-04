using System.Data;
using Xunit;
using DVLD_Business;

namespace DVLD_Test
{
    public class clsTestTypeBusinessTests
    {
        [Fact]
        public void GetAllTestTypes_ReturnsNonEmptyDataTable()
        {
            DataTable dt = clsTestTypeBusiness.GetAllTestTypes();

            Assert.NotNull(dt);
            Assert.True(dt.Rows.Count > 0);
        }

        [Fact]
        public void GetTestTypeInfoByID_ValidID_ReturnsCorrectData()
        {
            int validID = 1;

            clsTestTypeBusiness? testType =
                clsTestTypeBusiness.GetTestTypeInfoByID(validID);

            Assert.NotNull(testType);
            Assert.Equal(validID, testType.TestTypeID);
            Assert.True(testType.TestTypeFees >= 0);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(9999)]
        public void GetTestTypeInfoByID_InvalidID_ReturnsNull(int invalidID)
        {
            clsTestTypeBusiness? testType =
                clsTestTypeBusiness.GetTestTypeInfoByID(invalidID);

            Assert.Null(testType);
        }

        [Fact]
        public void UpdateTestType_UpdatesFeesSuccessfully()
        {
            int validID = 1;

            clsTestTypeBusiness? testType =
                clsTestTypeBusiness.GetTestTypeInfoByID(validID);

            Assert.NotNull(testType);

            decimal originalFees = testType.TestTypeFees;
            decimal newFees = originalFees + 2;

            testType.TestTypeFees = newFees;

            bool isUpdated = testType.UpdateTestType();

            clsTestTypeBusiness? updatedType =
                clsTestTypeBusiness.GetTestTypeInfoByID(validID);

            Assert.True(isUpdated);
            Assert.NotNull(updatedType);
            Assert.Equal(newFees, updatedType.TestTypeFees);

            updatedType.TestTypeFees = originalFees;
            bool isRestored = updatedType.UpdateTestType();

            Assert.True(isRestored);
        }
    }
}