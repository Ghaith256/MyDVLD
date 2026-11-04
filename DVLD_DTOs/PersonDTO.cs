namespace DVLD_DTOs {
    public class PersonDTO {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string? ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string? ImagePath { get; set; }

        public PersonDTO() { }

        public PersonDTO(int PersonID, string NationalNo, string FirstName, string SecondName, string? ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string? Email, int NationalityCountryID, string? ImagePath) {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
        }


    }
}
