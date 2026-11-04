using System;
using System.Data;
using DVLD_DataAccess;
using DVLD_DTOs;

namespace DVLD_Business {
    public class clsPersonBusiness {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        
        private static DataTable? _dtCountries;

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

        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + (string.IsNullOrEmpty(ThirdName) ? "" : ThirdName + " ") + LastName;
            }
        }

        public clsPersonBusiness() {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            this.Mode = enMode.AddNew;
        }

        private clsPersonBusiness(PersonDTO DTO, enMode mode = enMode.Update) {
            this.PersonID = DTO.PersonID;
            this.NationalNo = DTO.NationalNo;
            this.FirstName = DTO.FirstName;
            this.SecondName = DTO.SecondName;
            this.ThirdName = DTO.ThirdName;
            this.LastName = DTO.LastName;
            this.DateOfBirth = DTO.DateOfBirth;
            this.Gendor = DTO.Gendor;
            this.Address = DTO.Address;
            this.Phone = DTO.Phone;
            this.Email = DTO.Email;
            this.NationalityCountryID = DTO.NationalityCountryID;
            this.ImagePath = DTO.ImagePath;

            this.Mode = mode;
        }

        private PersonDTO _GetPersonDTO() {
            return new PersonDTO(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        private bool _AddNewPerson() {
            this.PersonID = clsPersonDataAccess.AddNewPerson(_GetPersonDTO());

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson() {
            return clsPersonDataAccess.UpdatePerson(_GetPersonDTO());
        }


        public bool Save() {
            switch(Mode) {
                case enMode.AddNew:
                    if (_AddNewPerson()) {
                        Mode = enMode.Update;
                        return true;
                    } else
                        return false;
                case enMode.Update:
                    return _UpdatePerson();

            }
            return false;
        }

        public static clsPersonBusiness? Find(int PersonID) {
            PersonDTO? PersonInfo = clsPersonDataAccess.GetPersonInfoByID(PersonID);

            if(PersonInfo != null)
                return new clsPersonBusiness(PersonInfo);

            return null;
        }

        public static clsPersonBusiness? Find(string NationalNo) {
            PersonDTO? PersonInfo = clsPersonDataAccess.GetPersonInfoByNationalNo(NationalNo);

            if (PersonInfo != null)
                return new clsPersonBusiness(PersonInfo);

            return null;
        }

        public static DataTable GetAllPeople() {
            return clsPersonDataAccess.GetAllPeople();
        }

        public static bool Delete(int PersonID) {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID) {
            return clsPersonDataAccess.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo) {
            return clsPersonDataAccess.IsPersonExist(NationalNo);
        }

        public static DataTable GetAllCountries()
        {
            if (_dtCountries == null || _dtCountries.Rows.Count == 0)
                _dtCountries = clsPersonDataAccess.GetAllCountries();

            return _dtCountries;
        }

        public static string GetCountryNameByID(int CountryID) {
            return clsPersonDataAccess.GetCountryNameByID(CountryID);
        }


    }
}
