using DVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseDataAccess
    {
        public static DetainedLicenseDTO? GetDetainedLicenseInfoByID(int DetainID) {
            DetainedLicenseDTO? DetainedLicense = null;
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DetainID", DetainID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    DetainedLicense = new DetainedLicenseDTO((int)reader["DetainID"], (int)reader["LicenseID"], (DateTime)reader["DetainDate"], (decimal)reader["FineFees"], (int)reader["CreatedByUserID"], (bool)reader["IsReleased"], reader["ReleaseDate"] == DBNull.Value ? null : (DateTime?)reader["ReleaseDate"], reader["ReleasedByUserID"] == DBNull.Value ? null : (int?)reader["ReleasedByUserID"], reader["ReleaseApplicationID"] == DBNull.Value ? null : (int?)reader["ReleaseApplicationID"]);
            
            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return DetainedLicense;
        }

        public static DetainedLicenseDTO? GetActiveDetainInfoByLicenseID(int LicenseID)
        {
            DetainedLicenseDTO? DetainedLicense = null;
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0 ORDER BY DetainID DESC";

            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    DetainedLicense = new DetainedLicenseDTO((int)reader["DetainID"], (int)reader["LicenseID"], (DateTime)reader["DetainDate"], (decimal)reader["FineFees"], (int)reader["CreatedByUserID"], (bool)reader["IsReleased"], reader["ReleaseDate"] == DBNull.Value ? null : (DateTime?)reader["ReleaseDate"], reader["ReleasedByUserID"] == DBNull.Value ? null : (int?)reader["ReleasedByUserID"], reader["ReleaseApplicationID"] == DBNull.Value ? null : (int?)reader["ReleaseApplicationID"]);
            
            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return DetainedLicense;
        }

        public static int AddNewDetainedLicense(DetainedLicenseDTO DetainedLicense) {
            int DetainID = -1;

            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses 
                                (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
                                VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased);
                                SELECT SCOPE_IDENTITY();";

            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseID", DetainedLicense.LicenseID);
                command.Parameters.AddWithValue("@DetainDate", DetainedLicense.DetainDate);
                command.Parameters.AddWithValue("@FineFees", DetainedLicense.FineFees);
                command.Parameters.AddWithValue("@CreatedByUserID", DetainedLicense.CreatedByUserID);
                command.Parameters.AddWithValue("@IsReleased", DetainedLicense.IsReleased);

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    DetainID = insertedID;
            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return DetainID;
        }

        public static bool UpdateDetainedLicense(DetainedLicenseDTO DetainedLicense) {
            
            int RowsAffected = 0;

            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE DetainedLicenses 
                             SET LicenseID = @LicenseID, DetainDate = @DetainDate, FineFees = @FineFees, CreatedByUserID = @CreatedByUserID, IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID";

            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@DetainID", DetainedLicense.DetainID);
                command.Parameters.AddWithValue("@LicenseID", DetainedLicense.LicenseID);
                command.Parameters.AddWithValue("@DetainDate", DetainedLicense.DetainDate);
                command.Parameters.AddWithValue("@FineFees", DetainedLicense.FineFees);
                command.Parameters.AddWithValue("@CreatedByUserID", DetainedLicense.CreatedByUserID);
                command.Parameters.AddWithValue("@IsReleased", DetainedLicense.IsReleased);

                command.Parameters.AddWithValue("@ReleaseDate", (object?)DetainedLicense.ReleaseDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", (object?)DetainedLicense.ReleasedByUserID ?? DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", (object?)DetainedLicense.ReleaseApplicationID ?? DBNull.Value);

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT dl.DetainID, dl.LicenseID, dl.DetainDate, dl.IsReleased, dl.FineFees, dl.ReleaseDate,
                             p.NationalNo,
                             (p.FirstName + ' ' + p.SecondName + ' ' + ISNULL(p.ThirdName + ' ', '') + p.LastName) AS FullName,
                             dl.ReleaseApplicationID
                      FROM DetainedLicenses dl
                      INNER JOIN Licenses l ON dl.LicenseID = l.LicenseID
                      INNER JOIN Drivers d ON l.DriverID = d.DriverID
                      INNER JOIN People p ON d.PersonID = p.PersonID";

            try
            {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);
                using SqlDataReader reader = command.ExecuteReader();

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