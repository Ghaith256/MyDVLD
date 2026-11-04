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
    public class clsDriverDataAccess {

        public static DriverDTO? GetDriverInfoByID(int DriverID) {
            DriverDTO? Driver = null;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID";

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@DriverID", DriverID);


                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) 
                    Driver = new DriverDTO((int)reader["DriverID"], (int)reader["PersonID"], (int)reader["CreatedByUserID"], (DateTime)reader["CreatedDate"]);
                }
                catch (Exception ex) {
                    clsDataAccessSettings.LogError(ex);
                }
                
            return Driver;
        }

        public static DriverDTO? GetDriverInfoByPersonID(int PersonID)
        {
            DriverDTO? Driver = null;

            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Drivers WHERE PersonID = @PersonID";

            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@PersonID", PersonID);

                using SqlDataReader reader = command.ExecuteReader();
                        
                if (reader.Read())
                    Driver = new DriverDTO((int)reader["DriverID"], (int)reader["PersonID"], (int)reader["CreatedByUserID"], (DateTime)reader["CreatedDate"]);
                            
                        
            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return Driver;
        }

        public static int AddNewDriver(DriverDTO dto)
        {
            int NewDriverID = -1;

            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate) 
                                 VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                                 SELECT SCOPE_IDENTITY();";
            try
            {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID", dto.PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", dto.CreatedByUserID);
                command.Parameters.AddWithValue("@CreatedDate", dto.CreatedDate);


                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    NewDriverID = insertedID;
                }
                catch (Exception ex) {
                    clsDataAccessSettings.LogError(ex);
            }

            return NewDriverID;
        }

        public static bool UpdateDriver(DriverDTO dto) {
            int RowsAffected = 0;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"UPDATE Drivers 
                             SET PersonID = @PersonID, CreatedByUserID = @CreatedByUserID, CreatedDate = @CreatedDate
                             WHERE DriverID = @DriverID";

            try {
                con.Open();


                using SqlCommand command = new SqlCommand(query, con);
                
                command.Parameters.AddWithValue("@DriverID", dto.DriverID);
                command.Parameters.AddWithValue("@PersonID", dto.PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", dto.CreatedByUserID);
                command.Parameters.AddWithValue("@CreatedDate", dto.CreatedDate);


                RowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetLocalLicenses(int DriverID)
        {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                             FROM Licenses 
                             INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                             WHERE DriverID = @DriverID
                             ORDER BY Licenses.ExpirationDate DESC";

            try
            {
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", DriverID);

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }
            return dt;
        }

        public static DataTable GetInternationalLicenses(int DriverID)
        {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT InternationalLicenseID, ApplicationID,  IssuedUsingLocalLicenseID AS LocalLicenseID,  IssueDate, ExpirationDate, IsActive
                             FROM InternationalLicenses 
                             WHERE DriverID = @DriverID
                             ORDER BY ExpirationDate DESC";

            try {
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", DriverID);

                using SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                    dt.Load(reader);

            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);

            }

            return dt;
        }

        public static DataTable GetAllDrivers() {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Drivers.DriverID, 
                            Drivers.PersonID, 
                            People.NationalNo, 
                            People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName AS FullName, 
                            Drivers.CreatedDate AS [Date],
                            (SELECT COUNT(*) FROM Licenses WHERE Licenses.DriverID = Drivers.DriverID AND IsActive = 1) AS ActiveLicenses
                     FROM Drivers 
                     INNER JOIN People ON Drivers.PersonID = People.PersonID
                     ORDER BY Drivers.DriverID DESC";

            try
            {
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return dt;
        }


    }
}
