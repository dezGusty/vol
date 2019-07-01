using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
    public class Workschedule
    {public int WorkscheduleID { get; set; }
        public string HoursWeek { get; set; }
       
        public Comments Comments { get; set; }
    }
}
