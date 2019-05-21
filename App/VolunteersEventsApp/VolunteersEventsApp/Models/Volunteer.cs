using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace VolunteersEventsApp.Models
{
    public enum Gender
    {
        M, F
    }
    public enum Desired_workplace
    {
        CANTINA, PACHETE, EVENIMENTE
    }
    public class Volunteer
    {
            public int VolunteerID { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public Gender? Gender { get; set; }
            public int Age { get; set; }
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }
            public Desired_workplace? Desired_workplace { get; set; }
            public string Field_of_activity { get; set; }
            public string Occupation { get; set; }
            public string Occupation_description { get; set; }
            public bool InActivity { get; set; }
            public int HourCount { get; set; }

            public ICollection<Address> Address { get; set; }
            public ICollection<Aditionalinfo> AditionalInfo { get; set; }
            public ICollection<Contract> Contract { get; set; }
            public ICollection<ContactInformation> ContactInformation { get; set; }
            public ICollection<RegistrationDay> RegistrationDay { get; set; }
            public ICollection<Workschedule> Workschedule { get; set; }

        }
    }

