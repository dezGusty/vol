using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Incercareax.Models
{
    public enum Gender
    {
        Male, Female
    }
    public enum Desired_workplace
    {
        Canteen, Packages, Events, Anywhere
    }
    public class Volunteer
    {
        [BsonId]
        public ObjectId VolunteerID { get; set; }

        [Required]
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public Address Address { get; set; }

        public Gender Gender { get; set; }

        public Desired_workplace Desired_workplace { get; set; }

        public string Field_of_activity { get; set; }

        public string Occupation { get; set; }

        public bool InActivity { get; set; }

        public int HourCount { get; set; }

        public Contract Contract { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public Additionalinfo Additionalinfo { get; set; }

    }

    public class Contract
    {
        public bool HasContract { get; set; }
        public int ContractPeriod { get; set; }
        public int NumberOfRegistration { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
    }

    public class ContactInformation
    {
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
    }

    public class Additionalinfo
    {
        public bool HasDrivingLicence { get; set; }
        public bool HasCar { get; set; }
    }

    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}

