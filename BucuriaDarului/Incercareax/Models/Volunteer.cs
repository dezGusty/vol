using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using VolCommon;


namespace Incercareax.Models
{

    public class Volunteer : VolunteerBase
    {
        [BsonId]
        public ObjectId VolunteerID { get; set; }


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
            /*Day = 28;
            Month = 12;
            Year = 2019;*/
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

