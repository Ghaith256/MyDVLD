using DVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseDataAccess {

        public static LicenseDTO? GetLicenseInfoByID(int LicenseID)
        {
            LicenseDTO? License = null;
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                using SqlDataReader reader = command.ExecuteReader();
                            
                if (reader.Read())
                    License = new LicenseDTO((int)reader["LicenseID"], (int)reader["ApplicationID"], (int)reader["DriverID"], (int)reader["LicenseClass"], (DateTime)reader["IssueDate"], (DateTime)reader["ExpirationDate"], reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"], (decimal)reader["PaidFees"], (bool)reader["IsActive"], (byte)reader["IssueReason"], (int)reader["CreatedByUserID"]);

            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }

            return License;
        }

        public static int AddNewLicense(LicenseDTO License)
        {
            int LicenseID = -1;

            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"INSERT INTO Licenses 
                                (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                                VALUES 
                                (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                                SELECT SCOPE_IDENTITY();";
            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@ApplicationID", License.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", License.DriverID);
                command.Parameters.AddWithValue("@LicenseClass", License.LicenseClassID);
                command.Parameters.AddWithValue("@IssueDate", License.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", License.ExpirationDate);

                if (string.IsNullOrEmpty(License.Notes))
                    command.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Notes", License.Notes);

                command.Parameters.AddWithValue("@PaidFees", License.PaidFees);
                command.Parameters.AddWithValue("@IsActive", License.IsActive);
                command.Parameters.AddWithValue("@IssueReason", License.IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", License.CreatedByUserID);

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    LicenseID = insertedID;

            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
                
            
            return LicenseID;
        }


        public static bool UpdateLicense(LicenseDTO License) {
            int RowsAffected = 0;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Licenses 
                             SET ApplicationID = @ApplicationID, DriverID = @DriverID, LicenseClass = @LicenseClass, IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, Notes = @Notes, PaidFees = @PaidFees, IsActive = @IsActive, IssueReason = @IssueReason, CreatedByUserID = @CreatedByUserID
                             WHERE LicenseID = @LicenseID";

            try {

                con.Open();


                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@LicenseID", License.LicenseID);
                command.Parameters.AddWithValue("@ApplicationID", License.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", License.DriverID);
                command.Parameters.AddWithValue("@LicenseClass", License.LicenseClassID);
                command.Parameters.AddWithValue("@IssueDate", License.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", License.ExpirationDate);

                if (string.IsNullOrEmpty(License.Notes))
                    command.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Notes", License.Notes);

                command.Parameters.AddWithValue("@PaidFees", License.PaidFees);
                command.Parameters.AddWithValue("@IsActive", License.IsActive);
                command.Parameters.AddWithValue("@IssueReason", License.IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", License.CreatedByUserID);


                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            
            return (RowsAffected > 0);
        }

        public static LicenseDTO? GetLicenseInfoByApplicationID(int ApplicationID)
        {
            LicenseDTO? License = null;
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID";

            try
            {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    License = new LicenseDTO((int)reader["LicenseID"], (int)reader["ApplicationID"], (int)reader["DriverID"], (int)reader["LicenseClass"], (DateTime)reader["IssueDate"], (DateTime)reader["ExpirationDate"], reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"], (decimal)reader["PaidFees"], (bool)reader["IsActive"], (byte)reader["IssueReason"], (int)reader["CreatedByUserID"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return License;
        }


    }
}
