using System;
using System.ComponentModel.DataAnnotations;

namespace VolCommon
{
    public enum Gender
    {
        Male, Female
    }
    public enum Desired_workplace
    {
        Canteen, Packages, Events, Anywhere
    }
    public class VolunteerBase
    {
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
}

