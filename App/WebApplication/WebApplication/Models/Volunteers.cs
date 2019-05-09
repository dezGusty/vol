using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Address address = new Address();
        public Aditionalinfo aditionalInfo = new Aditionalinfo();
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public Contract contract = new Contract();
        public Contactinformations contactInformations = new Contactinformations();
        public RegistrationDay registrationday = new RegistrationDay();
        public string Desired_workplace { get; set; }
        public string Field_of_activity { get; set; }
        public string Occupation { get; set; }
        public string Occupation_description { get; set; }
        public bool InActivity { get; set; }
        public int HourCount { get; set; }
        public Workschedule workSchedule = new Workschedule();
       
    }

    //public class Comments
    //{
    //    public string Days { get; set; }
    //    public string TimeAvailability { get; set; }
    //}

    public class Workschedule

    {
        public string HoursWeek { get; set; }
        
        public class Comments {
            public string Days { get; set; }
            public string TimeAvailability { get; set; }
        }
        
    }
    }

    public class BirthDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
    
    

    public class RegistrationDay
    {
      
        
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        
    }

    public class Contract
{
    public bool HasContract { get; set; }
    public int ContractPeriod { get; set; }
    public int NumberOfRegistration { get; set; }

}

public class Contactinformations
    {
    public string PhoneNumber { get; set; }
    public string MailAdress { get; set; }
}

    public class Aditionalinfo
    {
        
     public bool HasDrivingLicence { get; set; }
    public bool HasCar { get; set; }

    }

    public class Address
{ 
    public string City { get; set; }
    public string Country { get; set; }
    public string Number { get; set; }
    public string Street { get; set; }

}

