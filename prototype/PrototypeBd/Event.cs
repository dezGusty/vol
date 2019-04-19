using System;
using System.Collections.Generic;
using System.Text;


namespace SiemensProject
{

    public class Event
    {
        public int Id_Event { get; set; }
        public string NameOfEvent { get; set; }
        public string PlaceOfEvent { get; set; }
        public DateOfEvent dateOfEvent = new DateOfEvent();
        public int Lasting { get; set; }
        public int NumberOfVolunteersNeeded { get; set; }
        public string TipeOfActyvities { get; set; }
        public string TipeOfEvent { get; set; }

        public class DateOfEvent
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }
        }

    }

    //public string Event()
    //  {

    //}

}
