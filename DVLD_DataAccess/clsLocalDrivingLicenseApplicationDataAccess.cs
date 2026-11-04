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
    public class clsLocalDrivingLicenseApplicationDataAccess {

        public static int AddNewLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationDTO LocalDrivingLicenseApplication)
        {
            int LocalDrivingLicenseApplicationID = -1;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                             VALUES (@ApplicationID, @LicenseClassID);
                             SELECT SCOPE_IDENTITY();";
            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicationID", LocalDrivingLicenseApplication.ApplicationID);
                command.Parameters.AddWithValue("@LicenseClassID", LocalDrivingLicenseApplication.LicenseClassID);

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    LocalDrivingLicenseApplicationID = insertedID;
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }
                
            
            return LocalDrivingLicenseApplicationID;
        }

        public static LocalDrivingLicenseApplicationDTO? GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID)
        {

            LocalDrivingLicenseApplicationDTO? dto = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID
                             FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    dto = new LocalDrivingLicenseApplicationDTO(reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID")), reader.GetInt32(reader.GetOrdinal("ApplicationID")), reader.GetInt32(reader.GetOrdinal("LicenseClassID")));

            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return dto;
        }

        public static bool UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationDTO dto)
        {

            int RowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE LocalDrivingLicenseApplications
                             SET ApplicationID = @ApplicationID, LicenseClassID = @LicenseClassID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicationID", dto.ApplicationID);
                command.Parameters.AddWithValue("@LicenseClassID", dto.LicenseClassID);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", dto.LocalDrivingLicenseApplicationID);

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);
        }

        public static LocalDrivingLicenseApplicationDTO? GetLocalDrivingLicenseApplicationInfoByPersonID(int PersonID)
        {
            LocalDrivingLicenseApplicationDTO? dto = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT L.LocalDrivingLicenseApplicationID, L.ApplicationID, L.LicenseClassID
                             FROM LocalDrivingLicenseApplications L
                             INNER JOIN Applications A ON L.ApplicationID = A.ApplicationID
                             WHERE A.ApplicantPersonID = @PersonID";
            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    dto = new LocalDrivingLicenseApplicationDTO(reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID")), reader.GetInt32(reader.GetOrdinal("ApplicationID")), reader.GetInt32(reader.GetOrdinal("LicenseClassID")));
            
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }
            return dto;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LDLA.LocalDrivingLicenseApplicationID, LC.ClassName, P.NationalNo, P.FirstName + ' ' + P.SecondName + ' ' + ISNULL(P.ThirdName, '') + ' ' + P.LastName AS FullName, A.ApplicationDate, (SELECT COUNT(*) FROM Tests T INNER JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID WHERE TA.LocalDrivingLicenseApplicationID = LDLA.LocalDrivingLicenseApplicationID AND T.TestResult = 1) AS PassedTests, A.ApplicationStatus, A.ApplicantPersonID
                             FROM LocalDrivingLicenseApplications LDLA
                             INNER JOIN Applications A ON LDLA.ApplicationID = A.ApplicationID
                             INNER JOIN LicenseClasses LC ON LDLA.LicenseClassID = LC.LicenseClassID
                             INNER JOIN People P ON A.ApplicantPersonID = P.PersonID
                             ORDER BY LDLA.LocalDrivingLicenseApplicationID DESC";
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

        public static bool DoesActiveApplicationExist(int PersonID, int LicenseClassID) {
            
            bool IsExist = false;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1
                             FROM LocalDrivingLicenseApplications L
                             INNER JOIN Applications A ON L.ApplicationID = A.ApplicationID
                             WHERE A.ApplicantPersonID = @PersonID
                             AND L.LicenseClassID = @LicenseClassID
                             AND A.ApplicationStatus IN (1, 3)";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);
                
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                object result = command.ExecuteScalar();
                
                IsExist = (result != null);
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return IsExist;
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int RowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM LocalDrivingLicenseApplications 
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);
        }

        public static int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            int PassedTests = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT COUNT(*) 
                     FROM Tests T 
                     INNER JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID 
                     WHERE TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                       AND T.TestResult = 1";

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int count))
                    PassedTests = count;
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return PassedTests;
        }

    }
}
