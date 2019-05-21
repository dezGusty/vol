using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
    public class Comments
    {
        public int CommentsID { get; set; }
        public DayOfWeek? Days { get; set; }
        public int TimeAvailability { get; set; }

        public Workschedule Workschedule { get; set; }
    }
}
