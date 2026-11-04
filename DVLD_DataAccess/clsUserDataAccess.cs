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
    public class clsUserDataAccess {
        public static int AddNewUser(UserDTO user) {
            int UserID = -1;

            using SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive)
                         VALUES (@PersonID, @UserName, @Password, @IsActive);
                         SELECT SCOPE_IDENTITY();";


            try {
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID", user.PersonID);
                command.Parameters.AddWithValue("@UserName", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                object result = command.ExecuteScalar();

                 if (result != null && int.TryParse(result.ToString(), out int insertedID))
                      UserID = insertedID;
                    }
                    catch (Exception ex)
                    {
                        clsDataAccessSettings.LogError(ex);
                    }
            return UserID;

        }

        public static UserDTO? GetUserInfoByUserID(int userID)
        {
            UserDTO? user = null;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserID = @UserID";


            try { 
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@UserID", userID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) 
                    user = new UserDTO((int)reader["UserID"], (int)reader["PersonID"], (string)reader["Username"],  (string)reader["Password"], (bool)reader["IsActive"]);
                        
            }
            catch(SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return user; 
        }

        public static UserDTO? GetUserInfoByPersonID(int PersonID)
        {
            UserDTO? user = null;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE PersonID = @PersonID";


            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    user = new UserDTO((int)reader["UserID"], (int)reader["PersonID"], (string)reader["Username"], (string)reader["Password"], (bool)reader["IsActive"]);

            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return user;
        }

        public static UserDTO? GetUserInfoByUsername(string Username) {
            UserDTO? user = null;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * 
                             FROM Users 
                             WHERE Username = @Username";

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@Username", Username);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    user = new UserDTO((int)reader["UserID"], (int)reader["PersonID"], (string)reader["Username"], (string)reader["Password"], (bool)reader["IsActive"]);
            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return user;
        }

        public static DataTable GetAllUsers() {
            DataTable dt = new DataTable();
            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string query = @"SELECT Users.UserID, Users.PersonID, (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName) as FullName, Users.UserName,  Users.IsActive
                             FROM Users
                             INNER JOIN People ON Users.PersonID = People.PersonID";

            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                    dt.Load(reader);


            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return dt;

        }

        public static bool UpdateUser(UserDTO user) {
            int RowsAffected = 0;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE users
                     SET Username = @Username, 
                         Password = @Password,
                         IsActive = @IsActive
                     WHERE UserID = @UserID";

            try
            {
                con.Open();
                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);
                command.Parameters.AddWithValue("@UserID", user.UserID);

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return (RowsAffected > 0);
        }

        public static bool IsUserExist(int userID) {
            bool isFound = false;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@UserID", userID);

                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return isFound;
        }

        public static bool IsUserExist(string username)
        {
            bool isFound = false;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@UserName", username);

                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return isFound;
        }

        public static bool IsUserExistForPersonID(int personID)
        {
            bool isFound = false;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@PersonID", personID);

                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return isFound;
        }

        public static bool DeleteUser(int userID)
        {
            int rowsAffected = 0;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Users WHERE UserID = @UserID";

            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@UserID", userID);

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return (rowsAffected > 0);
        }

        public static bool ChangePassword(int UserID, string NewPasswordHash)
        {
            int rowsAffected = 0;

            using SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Users 
                             SET Password = @NewPasswordHash 
                             WHERE UserID = @UserID";

            try
            {
                con.Open();

                using SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@NewPasswordHash", NewPasswordHash);

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                clsDataAccessSettings.LogError(e);
            }

            return (rowsAffected > 0);
        }


    }
}
