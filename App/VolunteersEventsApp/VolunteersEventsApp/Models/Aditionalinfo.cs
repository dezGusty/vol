using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
    public class Aditionalinfo
    {
        public int AditionalinfoID { get; set; }
        public bool HasDrivingLicence { get; set; }
        public bool HasCar { get; set; }
        public Volunteer Volunteer { get; set; }
    }
}
