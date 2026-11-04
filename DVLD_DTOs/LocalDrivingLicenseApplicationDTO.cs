namespace DVLD_DTOs {
    public class LocalDrivingLicenseApplicationDTO
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public LocalDrivingLicenseApplicationDTO(int localDrivingLicenseApplicationID, int applicationID, int licenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.ApplicationID = applicationID;
            this.LicenseClassID = licenseClassID;
        }
    }
}