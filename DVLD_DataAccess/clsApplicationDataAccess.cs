using DVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationDataAccess {
        
        public static int AddNewApplication(ApplicationDTO Application) {
            
            int ApplicationID = -1;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                             VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicantPersonID", Application.ApplicantPersonID);
                command.Parameters.AddWithValue("@ApplicationDate", Application.ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", Application.ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", Application.ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", Application.LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", Application.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", Application.CreatedByUserID);

                object result = command.ExecuteScalar();
                
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ApplicationID = insertedID;


            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return ApplicationID;
        }
        
        public static ApplicationDTO? GetApplicationInfoByID(int ApplicationID) {

            ApplicationDTO? Application = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID
                             FROM Applications
                             WHERE ApplicationID = @ApplicationID";
            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    Application = new ApplicationDTO(reader.GetInt32(reader.GetOrdinal("ApplicationID")), reader.GetInt32(reader.GetOrdinal("ApplicantPersonID")), reader.GetDateTime(reader.GetOrdinal("ApplicationDate")), reader.GetInt32(reader.GetOrdinal("ApplicationTypeID")), reader.GetByte(reader.GetOrdinal("ApplicationStatus")), reader.GetDateTime(reader.GetOrdinal("LastStatusDate")), reader.GetDecimal(reader.GetOrdinal("PaidFees")), reader.GetInt32(reader.GetOrdinal("CreatedByUserID")) );

            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return Application;
        }

        public static bool UpdateApplication(ApplicationDTO? Application) {

            int RowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Applications
                             SET ApplicantPersonID = @ApplicantPersonID, ApplicationDate = @ApplicationDate, ApplicationTypeID = @ApplicationTypeID, ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate, PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID
                             WHERE ApplicationID = @ApplicationID";


            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicantPersonID", Application.ApplicantPersonID);
                command.Parameters.AddWithValue("@ApplicationDate", Application.ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", Application.ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", Application.ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", Application.LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", Application.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", Application.CreatedByUserID);
                command.Parameters.AddWithValue("@ApplicationID", Application.ApplicationID);

                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);

        }

        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {
            int RowsAffected = 0;
            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Applications 
                         SET ApplicationStatus = @NewStatus, LastStatusDate = @LastStatusDate
                         WHERE ApplicationID = @ApplicationID";
            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@NewStatus", NewStatus);
                command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
                        RowsAffected = command.ExecuteNonQuery();
             }
             catch (Exception ex) {
                  clsDataAccessSettings.LogError(ex);
             }
            return (RowsAffected > 0);

        }

        public static bool DeleteApplication(int ApplicationID) {
            int RowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM Applications
                     WHERE ApplicationID = @ApplicationID";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);
        }

    }
}

   