using Incercareax.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Incercareax.Controllers
{

    public class Birthday
    {
        //IList<Volunteer> allvolunteers2 = IEnumerator<Volunteer>.ToList();

        internal static void Birthdayalert(IEnumerable<Volunteer> allvolunteers2)//Este Facut Blana pentru toate cazurile si din ianuarie si la sfarsitul lui decembrie
        {
            string todaydate = DateTime.Today.ToString("dd-MM-yyyy");
            string[] dates = todaydate.Split('-');
            int Day = Convert.ToInt16(dates[0]);
            int Month = Convert.ToInt16(dates[1]);
            Day = (Month - 1) * 30 + Day;
            int voldays;

            Console.WriteLine("The following Volunteers are going to have birthdays");
            foreach (Volunteer vol in allvolunteers2)
            {
                voldays = (vol.Birthdate.Month - 1) * 30 + vol.Birthdate.Day;

                if ((Day <= voldays && Day + 7 > voldays) || (Day > 354 && 362 - Day >= voldays))
                {
                    Console.WriteLine(vol.Firstname + " " + vol.Lastname + " : " + vol.Birthdate.Year + "." + vol.Birthdate.Month + "." + vol.Birthdate.Day);
                }

            }
        }
    }
   
}