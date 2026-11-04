namespace DVLD_DTOs
{
    public class ApplicationTypeDTO
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public ApplicationTypeDTO(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }
    }
}