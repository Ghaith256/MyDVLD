using DVLD_DataAccess;
using DVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsUserBusiness
    {

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }

        public clsPersonBusiness? PersonInfo { get; set; }


        public clsUserBusiness()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = true;
            this.Mode = enMode.AddNew;
        }

        private clsUserBusiness(UserDTO userDTO)
        {
            this.UserID = userDTO.UserID;
            this.PersonID = userDTO.PersonID;
            this.Username = userDTO.Username;
            this.Password = userDTO.Password;
            this.IsActive = userDTO.IsActive;

            this.PersonInfo = clsPersonBusiness.Find(this.PersonID);

            this.Mode = enMode.Update;
        }

        public void SetPassword(string plainTextPassword)
        {
            this.Password = BCrypt.Net.BCrypt.HashPassword(plainTextPassword, workFactor: 12);
        }

        private UserDTO _GetUserDTO()
        {
            return new UserDTO(this.UserID, this.PersonID, this.Username, this.Password, this.IsActive);
        }

        private bool _AddNewUser()
        {
            if (this.Password != null && !this.Password.StartsWith("$2"))
            {
                this.Password = BCrypt.Net.BCrypt.HashPassword(this.Password, workFactor: 12);
            }

            this.UserID = clsUserDataAccess.AddNewUser(_GetUserDTO());
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(_GetUserDTO());
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static clsUserBusiness? FindByUserID(int UserID)
        {
            UserDTO? UserDTO = clsUserDataAccess.GetUserInfoByUserID(UserID);

            if (UserDTO != null)
                return new clsUserBusiness(UserDTO);
            else
                return null;
        }

        public static clsUserBusiness? FindByPersonID(int PersonID)
        {
            UserDTO? UserDTO = clsUserDataAccess.GetUserInfoByPersonID(PersonID);

            if (UserDTO != null)
                return new clsUserBusiness(UserDTO);
            else
                return null;
        }

        public static clsUserBusiness? Login(string Username, string PlainTextPassword) {
            
            UserDTO? dto = clsUserDataAccess.GetUserInfoByUsername(Username);
            
            if (dto == null)
                return null;

            if (!BCrypt.Net.BCrypt.Verify(PlainTextPassword, dto.Password))
                return null;

            return new clsUserBusiness(dto);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static bool DeleteUser(int userID)
        {
            return clsUserDataAccess.DeleteUser(userID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserDataAccess.IsUserExist(UserID);
        }

        public static bool IsUserExist(string Username)
        {
            return clsUserDataAccess.IsUserExist(Username);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserDataAccess.IsUserExistForPersonID(PersonID);
        }

        public bool ChangePassword(string OldPlainTextPassword, string NewPlainTextPassword)
        {
            if (!BCrypt.Net.BCrypt.Verify(OldPlainTextPassword, this.Password))
                return false;

            this.Password = BCrypt.Net.BCrypt.HashPassword(NewPlainTextPassword, workFactor: 12);

            return clsUserDataAccess.ChangePassword(this.UserID, this.Password);
        }
    }
}