using DVLD_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace DVLD_Presentation
{
    public static class clsGlobal
    {
        public static clsUserBusiness? CurrentUser;
        private const string RegistryKeyPath = @"HKEY_CURRENT_USER\Software\DVLD";

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                string CurrentDirectory = Directory.GetCurrentDirectory();
                string FilePath = CurrentDirectory + "\\data.txt";

                if (string.IsNullOrEmpty(Username) && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                string DataToSave = Username + "#//#" + Password;

                byte[] DataBytes = Encoding.UTF8.GetBytes(DataToSave);
                byte[] EncryptedBytes = ProtectedData.Protect(DataBytes, null, DataProtectionScope.CurrentUser);
                string EncryptedText = Convert.ToBase64String(EncryptedBytes);

                using StreamWriter writer = new StreamWriter(FilePath);
                writer.WriteLine(EncryptedText);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {

            try
            {
                string CurrentDirectory = Directory.GetCurrentDirectory();
                string FilePath = CurrentDirectory + "\\data.txt";

                if (File.Exists(FilePath))
                {
                    using StreamReader reader = new StreamReader(FilePath);

                    string? line = reader.ReadLine();

                    while (line != null)
                    {
                        byte[] EncryptedBytes = Convert.FromBase64String(line);
                        byte[] DecryptedBytes = ProtectedData.Unprotect(EncryptedBytes, null, DataProtectionScope.CurrentUser);
                        string DecryptedText = Encoding.UTF8.GetString(DecryptedBytes);


                        string[] result = DecryptedText.Split(new string[] { "#//#" }, StringSplitOptions.None);

                        if (result.Length >= 2)
                        {
                            Username = result[0];
                            Password = result[1];
                        }

                        line = reader.ReadLine();
                    }

                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool RememberUsernameAndPasswordInRegistry(string Username, string Password)
        {

            try
            {

                if (string.IsNullOrEmpty(Username))
                {
                    Registry.SetValue(RegistryKeyPath, "Username", "", RegistryValueKind.String);
                    Registry.SetValue(RegistryKeyPath, "Password", "", RegistryValueKind.String);
                    return true;
                }

                byte[] PasswordBytes = Encoding.UTF8.GetBytes(Password);
                byte[] EncryptedBytes = ProtectedData.Protect(PasswordBytes, null, DataProtectionScope.CurrentUser);
                string EncryptedPassword = Convert.ToBase64String(EncryptedBytes);

                Registry.SetValue(RegistryKeyPath, "Username", Username, RegistryValueKind.String);
                Registry.SetValue(RegistryKeyPath, "Password", EncryptedPassword, RegistryValueKind.String);

                return true;

            }
            catch (Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

            return false;
        }

        public static bool GetStoredCredentialFromRegistry(ref string Username, ref string Password) {
            
            try {

                string? storedUsername = Registry.GetValue(RegistryKeyPath, "Username", null) as string;
                string? storedPassword = Registry.GetValue(RegistryKeyPath, "Password", null) as string;

                if (!string.IsNullOrEmpty(storedUsername) && !string.IsNullOrEmpty(storedPassword)) {
                    Username = storedUsername;

                    byte[] EncryptedBytes = Convert.FromBase64String(storedPassword);
                    byte[] DecryptedBytes = ProtectedData.Unprotect(EncryptedBytes, null, DataProtectionScope.CurrentUser);
                    Password = Encoding.UTF8.GetString(DecryptedBytes);

                    return true;
                }

                return false;

            } catch(Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

            return false;
        }

    }



}