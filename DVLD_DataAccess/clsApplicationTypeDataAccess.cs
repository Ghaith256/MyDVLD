using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DTOs;

namespace DVLD_DataAccess
{
    public class clsApplicationTypeDataAccess {
        
        public static DataTable GetAllApplicationTypes() {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationTypeID, ApplicationTypeTitle, ApplicationFees
                             FROM ApplicationTypes";

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                using SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                    dt.Load(reader);

            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return dt;
        }

        public static bool UpdateApplicationType(ApplicationTypeDTO ApplicationType) {
            int RowsAffected = 0;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE ApplicationTypes
                             SET ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees
                             WHERE ApplicationTypeID = @ApplicationTypeID";

            try {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationType.ApplicationTypeTitle);
                command.Parameters.AddWithValue("@ApplicationFees", ApplicationType.ApplicationFees);
                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationType.ApplicationTypeID);

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return (RowsAffected > 0);
        }

        public static ApplicationTypeDTO? GetApplicationTypeInfoByID(int ApplicationTypeID)
        {
            ApplicationTypeDTO? ApplicationType = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            try
            {
                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                con.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    ApplicationType = new ApplicationTypeDTO(reader.GetInt32(reader.GetOrdinal("ApplicationTypeID")), reader.GetString(reader.GetOrdinal("ApplicationTypeTitle")), reader.GetDecimal(reader.GetOrdinal("ApplicationFees")) );
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return ApplicationType;
        }


    }
}
