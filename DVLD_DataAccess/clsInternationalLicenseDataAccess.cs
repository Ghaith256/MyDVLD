using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsInternationalLicenseDataAccess {

        public static InternationalLicenseDTO? GetInternationalLicenseInfoByID(int InternationalLicenseID) {
            
            InternationalLicenseDTO? LicenseDTO = null; 

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);
                
                command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) 
                    LicenseDTO = new InternationalLicenseDTO((int)reader["InternationalLicenseID"], (int)reader["ApplicationID"], (int)reader["DriverID"], (int)reader["IssuedUsingLocalLicenseID"], (DateTime)reader["IssueDate"], (DateTime)reader["ExpirationDate"], (bool)reader["IsActive"], (int)reader["CreatedByUserID"]);
   
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return LicenseDTO; 
        }

        public static int AddNewInternationalLicense(InternationalLicenseDTO newLicenseDTO)
        {
            int InternationalLicenseID = -1;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                             VALUES(@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicationID", newLicenseDTO.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", newLicenseDTO.DriverID);
                command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", newLicenseDTO.IssuedUsingLocalLicenseID);
                command.Parameters.AddWithValue("@IssueDate", newLicenseDTO.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", newLicenseDTO.ExpirationDate);
                command.Parameters.AddWithValue("@IsActive", newLicenseDTO.IsActive);
                command.Parameters.AddWithValue("@CreatedByUserID", newLicenseDTO.CreatedByUserID);

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    InternationalLicenseID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return InternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(InternationalLicenseDTO licenseDTO)
        {
            int rowsAffected = 0;
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE InternationalLicenses  
                             SET ApplicationID = @ApplicationID, DriverID = @DriverID, IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID, IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, IsActive = @IsActive, CreatedByUserID = @CreatedByUserID
                             WHERE InternationalLicenseID = @InternationalLicenseID";

            try {
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@InternationalLicenseID", licenseDTO.InternationalLicenseID);
                command.Parameters.AddWithValue("@ApplicationID", licenseDTO.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", licenseDTO.DriverID);
                command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", licenseDTO.IssuedUsingLocalLicenseID);
                command.Parameters.AddWithValue("@IssueDate", licenseDTO.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", licenseDTO.ExpirationDate);
                command.Parameters.AddWithValue("@IsActive", licenseDTO.IsActive);
                command.Parameters.AddWithValue("@CreatedByUserID", licenseDTO.CreatedByUserID);

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return (rowsAffected > 0);
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID) {
            int ActiveLicenseID = -1;
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TOP 1 InternationalLicenseID
                             FROM InternationalLicenses 
                             WHERE DriverID = @DriverID AND IsActive = 1 AND ExpirationDate >= GETDATE()
                             ORDER BY ExpirationDate DESC";

            try {
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", DriverID);

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ActiveID))
                    ActiveLicenseID = ActiveID;

            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return ActiveLicenseID;
        }

        public static DataTable GetAllInternationalLicenses() {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive FROM InternationalLicenses ORDER BY IsActive DESC, ExpirationDate DESC";

            try {
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);
                
                using SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows) 
                    dt.Load(reader);
            }
            catch (Exception ex) { 
                clsDataAccessSettings.LogError(ex); 
            }

            return dt;
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID, 
                            IssueDate, ExpirationDate, IsActive
                     FROM InternationalLicenses 
                     WHERE DriverID = @DriverID
                     ORDER BY ExpirationDate DESC";

            try
            {
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", DriverID);

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


    }
}
