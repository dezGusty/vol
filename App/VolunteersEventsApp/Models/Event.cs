using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string NameOfEvent { get; set; }
        public string PlaceOfEvent { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfEvents { get; set; }
        public int Lasting { get; set; }
        public int NumberOfVolunteersNeeded { get; set; }
        public string TypeOfActivities { get; set; }
        public string TypeOfEvent { get; set; }
        public List<Allocate> AllocatedVolunteer { get; set; }

        public Event() {
            AllocatedVolunteer = new List<Allocate>();
}
        //public string AllocateMethod(string[] vols,int EventId)
        //{ string Initial = " ";

        //    foreach (Volunteer volunteer in Allocate)
        //    {if (Allocate.IsAllocate == true)
        //        {
        //            Initial = Initial + volunteer.Firstname+ volunteer.Lastname;
        //        }
        //        else
        //            return Initial;
        //    }
        //}

    }
}
