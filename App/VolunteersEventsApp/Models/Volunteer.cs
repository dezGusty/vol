using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
   
    public class Volunteer
    {
            public int VolunteerID { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }
            public string Desired_workplace { get; set; }
            public string Field_of_activity { get; set; }
            public string Occupation { get; set; }
            public string Occupation_description { get; set; }
            public bool InActivity { get; set; }
            public int HourCount { get; set; }
        public string FullName => Firstname + "," + Lastname;

        public Address Address { get; set; }
        public Aditionalinfo AditionalInfo { get; set; }
        public Contract Contract { get; set; }
        public ContactInformation ContactInformation { get; set; }
        public Workschedule Workschedule { get; set; }

        public static int Volbd(Volunteer vol)
        {
            int voldays;
            {
                voldays = (vol.Birthdate.Month - 1) * 30 + vol.Birthdate.Day;

            }
            return voldays;
        }

        public static int Nowdate()
        {
            string todaydate = DateTime.Today.ToString("dd-MM-yyyy");
            string[] dates = todaydate.Split('-');
            int Day = Convert.ToInt16(dates[0]);
            int Month = Convert.ToInt16(dates[1]);
            int Year = Convert.ToInt16(dates[2]);
            Day = (Month - 1) * 30 + Day;
            return Day;
        }

        public static int Volexp(Volunteer vol)
        {
            int volexp;
            {
                volexp = (vol.Contract.ExpirationDate.Month - 1) * 30 + vol.Contract.ExpirationDate.Day;
            }
            return volexp;
        }

    }

}
   

