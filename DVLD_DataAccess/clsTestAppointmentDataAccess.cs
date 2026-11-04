using DVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentDataAccess
    {
        public static TestAppointmentDTO? GetTestAppointmentInfoByID(int TestAppointmentID)
        {
            TestAppointmentDTO? dto = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, 
                            AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID 
                     FROM TestAppointments 
                     WHERE TestAppointmentID = @TestAppointmentID";

            try
            {
                con.Open();
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int RetakeTestApplicationID = reader.IsDBNull(reader.GetOrdinal("RetakeTestApplicationID"))
                        ? -1
                        : reader.GetInt32(reader.GetOrdinal("RetakeTestApplicationID"));

                    dto = new TestAppointmentDTO(reader.GetInt32(reader.GetOrdinal("TestAppointmentID")), reader.GetInt32(reader.GetOrdinal("TestTypeID")), reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID")), reader.GetDateTime(reader.GetOrdinal("AppointmentDate")), reader.GetDecimal(reader.GetOrdinal("PaidFees")), reader.GetInt32(reader.GetOrdinal("CreatedByUserID")), reader.GetBoolean(reader.GetOrdinal("IsLocked")), RetakeTestApplicationID );
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }
            return dto;
        }
        
        public static bool LockTestAppointment(int TestAppointmentID)
        {
            int rowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID";

            try
            {
                con.Open();
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }
            return (rowsAffected > 0);
        }

        public static int GetTotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int TotalTrials = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT COUNT(*) 
                     FROM TestAppointments 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                       AND TestTypeID = @TestTypeID
                       AND IsLocked = 1"; 

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int trials))
                {
                    TotalTrials = trials;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return TotalTrials;
        }

        public static int AddNewTestAppointment(TestAppointmentDTO dto)
        {
            int TestAppointmentID = -1;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments 
                     (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID) 
                     VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                     SELECT SCOPE_IDENTITY();";
            try
            {
                con.Open();
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TestTypeID", dto.TestTypeID);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", dto.LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@AppointmentDate", dto.AppointmentDate);
                cmd.Parameters.AddWithValue("@PaidFees", dto.PaidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", dto.CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", dto.IsLocked);

                if (dto.RetakeTestApplicationID != -1)
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID", dto.RetakeTestApplicationID);
                else
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }
            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment(TestAppointmentDTO dto)
        {
            int rowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments 
                     SET TestTypeID = @TestTypeID, 
                         LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, 
                         AppointmentDate = @AppointmentDate, 
                         PaidFees = @PaidFees, 
                         CreatedByUserID = @CreatedByUserID, 
                         IsLocked = @IsLocked, 
                         RetakeTestApplicationID = @RetakeTestApplicationID
                     WHERE TestAppointmentID = @TestAppointmentID";
            try
            {
                con.Open();
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TestAppointmentID", dto.TestAppointmentID);
                cmd.Parameters.AddWithValue("@TestTypeID", dto.TestTypeID);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", dto.LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@AppointmentDate", dto.AppointmentDate);
                cmd.Parameters.AddWithValue("@PaidFees", dto.PaidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", dto.CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", dto.IsLocked);

                if (dto.RetakeTestApplicationID != -1)
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID", dto.RetakeTestApplicationID);
                else
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllTestAppointmentsByLocalAppID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked
                     FROM TestAppointments
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                       AND TestTypeID = @TestTypeID
                     ORDER BY AppointmentDate DESC";

            try
            {
                con.Open();
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                using SqlDataReader reader = cmd.ExecuteReader();
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