using DVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypeDataAccess {
        
        public static DataTable GetAllTestTypes() {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees
                             FROM TestTypes";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return dt;
        }
        
        public static bool UpdateTestType(TestTypeDTO TestType) {

            int RowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE TestTypes
                             SET TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestTypeFees
                             WHERE TestTypeID = @TestTypeID";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@TestTypeTitle", TestType.TestTypeTitle);
                command.Parameters.AddWithValue("@TestTypeDescription", TestType.TestTypeDescription);
                command.Parameters.AddWithValue("@TestTypeFees", TestType.TestTypeFees);
                command.Parameters.AddWithValue("@TestTypeID", TestType.TestTypeID);

                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);

        }
        
        public static TestTypeDTO? GetTestTypeInfoByID(int TestTypeID) {
            
            TestTypeDTO TestType = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees
                             FROM TestTypes
                             WHERE TestTypeID = @TestTypeID";
            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    TestType = new TestTypeDTO(reader.GetInt32(reader.GetOrdinal("TestTypeID")), reader.GetString(reader.GetOrdinal("TestTypeTitle")), reader.GetString(reader.GetOrdinal("TestTypeDescription")), reader.GetDecimal(reader.GetOrdinal("TestTypeFees")));

            }
            catch(SqlException ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return TestType;


        }

    }
}
