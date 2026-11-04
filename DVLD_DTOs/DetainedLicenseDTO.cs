using System;

namespace DVLD_DTOs
{
    public class DetainedLicenseDTO
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public DetainedLicenseDTO(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID) {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
        }
    }
}