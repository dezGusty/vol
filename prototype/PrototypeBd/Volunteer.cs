using System;
using System.Collections.Generic;
using System.Text;


namespace SiemensProject
{
    public class Volunteer
    {
        public int id { get; set; }
        public Address address = new Address();
        public Aditionalinfo aditionalInfo = new Aditionalinfo();
        public int Age { get; set; }
        public BirthDate birthdate = new BirthDate();
        public Contactinformations contactInformations = new Contactinformations();
        public Contract contract = new Contract();
        public RegistrationDay registrationday = new RegistrationDay();
        public string Desired_workplace { get; set; }
        public string Field_of_activity { get; set; }
        public string Firstname { get; set; }
        public string Gender { get; set; }
        public int HourCount { get; set; }
        public bool InActivity { get; set; }
        public string Lastname { get; set; }
        public string Occupation { get; set; }
        public string Occupation_description { get; set; }
        public Workschedule workSchedule = new Workschedule();
        internal Workschedule WorkSchedule { get => workSchedule; set => workSchedule = value; }
        internal Contactinformations ContactInformations { get => ContactInformations1; set => ContactInformations1 = value; }
        internal Aditionalinfo AditionalInfo { get => aditionalInfo; set => aditionalInfo = value; }
        internal Address Address { get => address; set => address = value; }
        internal Contract Contract { get => contract; set => contract = value; }
        internal Contactinformations ContactInformations1 { get => contactInformations; set => contactInformations = value; }
        internal Comments comments { get; set; }

        public Volunteer() { }
    }

    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
    }
    public class BirthDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }

    public class Aditionalinfo
    {
        public bool HasDrivingLicence { get; set; }
        public bool HasCar { get; set; }
    }

    public class Contactinformations
    {
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
    }

    public class Contract
    {
        public bool HasContract { get; set; }
        public int ContractPeriod { get; set; }
        public int NumberOfRegistration { get; set; }

    }

    public class RegistrationDay
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

    }

    public class Workschedule
    {
        public string HoursWeek { get; set; }
        public Comments Comments = new Comments();
    }

    public class Comments
    {
        public string Days { get; set; }
        public string TimeAvailability { get; set; }
    }

}
