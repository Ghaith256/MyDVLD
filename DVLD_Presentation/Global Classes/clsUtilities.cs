using System;
using System.Windows.Forms;
namespace DVLD.Classes {

    public class clsUtil {

        public static string GenerateGUID() {
            Guid newGuid = Guid.NewGuid();
            return newGuid.ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath) {

            if (!Directory.Exists(FolderPath)) {
                try {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex) {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }


        public static string ReplaceFileNameWithGUID(string SourceFile) {
            string FileName = SourceFile;
            FileInfo File = new FileInfo(FileName);
            string extn = File.Extension;
            return GenerateGUID() + extn;
        }


        public static bool CopyImageToProjectImagesFolder(ref string SourceFile) {

            string DestinationFolder = @"C:\Users\ghait\source\repos\MyDVLD";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
                return false;

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGUID(SourceFile);

            try {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (IOException e) {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceFile = DestinationFile;
            return true;

        }

    }

}

