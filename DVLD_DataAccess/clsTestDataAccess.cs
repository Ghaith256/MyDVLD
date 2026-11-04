using DVLD_DTOs;
using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestDataAccess
    {
        public static int AddNewTest(TestDTO Test)
        {
            int TestID = -1;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                             VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            try
            {
                con.Open();
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TestAppointmentID", Test.TestAppointmentID);
                cmd.Parameters.AddWithValue("@TestResult", Test.TestResult);

                if (string.IsNullOrEmpty(Test.Notes))
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", Test.Notes);

                cmd.Parameters.AddWithValue("@CreatedByUserID", Test.CreatedByUserID);

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    TestID = insertedID;
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }
            return TestID;
        }
    
    
   }
}