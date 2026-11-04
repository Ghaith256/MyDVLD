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
    public class clsLicenseClassDataAccess {

        public static DataTable GetAllLicenseClasses() {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees FROM LicenseClasses";

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

        public static LicenseClassDTO? GetLicenseClassInfoByID(int LicenseClassID)
        {
            LicenseClassDTO? LicenseClass = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees
                     FROM LicenseClasses
                     WHERE LicenseClassID = @LicenseClassID";
            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    LicenseClass = new LicenseClassDTO(
                        reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                        reader.GetString(reader.GetOrdinal("ClassName")),
                        reader.GetString(reader.GetOrdinal("ClassDescription")),
                        reader.GetByte(reader.GetOrdinal("MinimumAllowedAge")),
                        reader.GetByte(reader.GetOrdinal("DefaultValidityLength")),
                        reader.GetDecimal(reader.GetOrdinal("ClassFees"))
                    );
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.LogError(ex);
            }

            return LicenseClass;
        }

    }
}
