using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
    public class RegistrationDay
    {
        public int RegistrationDayID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
       
    }
}
