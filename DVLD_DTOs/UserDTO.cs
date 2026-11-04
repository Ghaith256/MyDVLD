using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DTOs
{
    public class UserDTO {
        public int UserID;
        public int PersonID;
        public string Username;
        public string Password;
        public bool IsActive;

        public UserDTO()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
        }

        public UserDTO(int UserID, int PersonID, string username, string password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = username;
            this.Password = password;
            this.IsActive = IsActive;
        }

    }
}
