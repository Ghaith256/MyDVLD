using DVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DVLD_DataAccess {
    public class clsPersonDataAccess {

        public static DataTable GetAllPeople() {
            DataTable dt = new DataTable();

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) {
                    dt.Load(reader);
                }

            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return dt;
        }

        public static int AddNewPerson(PersonDTO PersonInfo) {
            int PersonID = -1;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO People (FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                             VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@FirstName", PersonInfo.FirstName);
                command.Parameters.AddWithValue("@SecondName", PersonInfo.SecondName);

                if (string.IsNullOrEmpty(PersonInfo.ThirdName))
                    command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ThirdName", PersonInfo.ThirdName);

                command.Parameters.AddWithValue("@LastName", PersonInfo.LastName);
                command.Parameters.AddWithValue("@NationalNo", PersonInfo.NationalNo);
                command.Parameters.AddWithValue("@DateOfBirth", PersonInfo.DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", PersonInfo.Gendor);
                command.Parameters.AddWithValue("@Address", PersonInfo.Address);
                command.Parameters.AddWithValue("@Phone", PersonInfo.Phone);
                if (string.IsNullOrEmpty(PersonInfo.Email))
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", PersonInfo.Email);

                command.Parameters.AddWithValue("@NationalityCountryID", PersonInfo.NationalityCountryID);

                if (string.IsNullOrEmpty(PersonInfo.ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ImagePath", PersonInfo.ImagePath);

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    PersonID = insertedID;

            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }
            return PersonID;
        }

        public static bool IsPersonExist(int PersonID) {
            bool IsFound = false;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT found = 1 FROM People WHERE PersonID = @PersonID";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PersonID", PersonID);

                object result = command.ExecuteScalar();

                if (result != null)
                    IsFound = true;


            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return IsFound;
        }

        public static bool IsPersonExist(string NationalNo) {
            bool IsFound = false;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT found = 1 FROM People WHERE NationalNo = @NationalNo";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@NationalNo", NationalNo);

                object result = command.ExecuteScalar();

                if (result != null)
                    IsFound = true;


            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return IsFound;
        }

        public static bool DeletePerson(int PersonID) {
            bool IsDeleted = false;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM People WHERE PersonID = @PersonID";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                    IsDeleted = true;



            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return IsDeleted;
        }

        public static bool UpdatePerson(PersonDTO PersonInfo) {

            bool IsUpdated = false;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE People
                             SET FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, NationalNo = @NationalNo, DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
                             WHERE PersonID = @PersonID";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PersonID", PersonInfo.PersonID);

                command.Parameters.AddWithValue("@FirstName", PersonInfo.FirstName);
                command.Parameters.AddWithValue("@SecondName", PersonInfo.SecondName);

                if (string.IsNullOrEmpty(PersonInfo.ThirdName))
                    command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ThirdName", PersonInfo.ThirdName);

                command.Parameters.AddWithValue("@LastName", PersonInfo.LastName);
                command.Parameters.AddWithValue("@NationalNo", PersonInfo.NationalNo);
                command.Parameters.AddWithValue("@DateOfBirth", PersonInfo.DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", PersonInfo.Gendor);
                command.Parameters.AddWithValue("@Address", PersonInfo.Address);
                command.Parameters.AddWithValue("@Phone", PersonInfo.Phone);

                if (string.IsNullOrEmpty(PersonInfo.Email))
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", PersonInfo.Email);

                command.Parameters.AddWithValue("@NationalityCountryID", PersonInfo.NationalityCountryID);

                if (string.IsNullOrEmpty(PersonInfo.ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ImagePath", PersonInfo.ImagePath);

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                    IsUpdated = true;


            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return IsUpdated;
        }

        public static PersonDTO? GetPersonInfoByID(int PersonID) {

            PersonDTO? PersonInfo = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PersonID", PersonID);

                using SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                    PersonInfo = new PersonDTO(reader.GetInt32(reader.GetOrdinal("PersonID")), reader.GetString(reader.GetOrdinal("NationalNo")), reader.GetString(reader.GetOrdinal("FirstName")), reader.GetString(reader.GetOrdinal("SecondName")), reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? null : reader.GetString(reader.GetOrdinal("ThirdName")), reader.GetString(reader.GetOrdinal("LastName")), reader.GetDateTime(reader.GetOrdinal("DateOfBirth")), reader.GetByte(reader.GetOrdinal("Gendor")), reader.GetString(reader.GetOrdinal("Address")), reader.GetString(reader.GetOrdinal("Phone")), reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")), reader.GetInt32(reader.GetOrdinal("NationalityCountryID")), reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath")));


            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }
            return PersonInfo;
        }

        public static PersonDTO? GetPersonInfoByNationalNo(string NationalNo) {

            PersonDTO? PersonInfo = null;
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@NationalNo", NationalNo);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    PersonInfo = new PersonDTO(reader.GetInt32(reader.GetOrdinal("PersonID")), reader.GetString(reader.GetOrdinal("NationalNo")), reader.GetString(reader.GetOrdinal("FirstName")), reader.GetString(reader.GetOrdinal("SecondName")), reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? null : reader.GetString(reader.GetOrdinal("ThirdName")), reader.GetString(reader.GetOrdinal("LastName")), reader.GetDateTime(reader.GetOrdinal("DateOfBirth")), reader.GetByte(reader.GetOrdinal("Gendor")), reader.GetString(reader.GetOrdinal("Address")), reader.GetString(reader.GetOrdinal("Phone")), reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")), reader.GetInt32(reader.GetOrdinal("NationalityCountryID")), reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath")));


            } catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }
            return PersonInfo;
        }

        public static DataTable GetAllCountries() {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries";

            try {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                using SqlDataReader reader = command.ExecuteReader();
                
                if(reader.HasRows)
                    dt.Load(reader);

            }
            catch (Exception ex) {
                clsDataAccessSettings.LogError(ex);
            }

            return dt;

        }


        public static string GetCountryNameByID(int CountryID) {
            string CountryName = "N/A";
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";

            try {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CountryID", CountryID);
                con.Open();

                object result = command.ExecuteScalar();
                
                if (result != null)
                    CountryName = result.ToString();
                
            } catch(Exception e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return CountryName;
        }
    }
}
