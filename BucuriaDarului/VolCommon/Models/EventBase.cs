using System;
using System.ComponentModel.DataAnnotations;


namespace VolCommon
{
    public class EventBase
    {

        public string NameOfEvent { get; set; }

        public string PlaceOfEvent { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfEvent { get; set; }

        public int NumberOfVolunteersNeeded { get; set; }

        public string TypeOfActivities { get; set; }

        public string TypeOfEvent { get; set; }
        
        public int Duration { get; set; }
    }
}