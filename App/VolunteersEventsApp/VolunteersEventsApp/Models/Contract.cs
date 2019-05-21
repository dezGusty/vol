using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteersEventsApp.Models
{
    public class Contract
    {
        public int ContractID { get; set; }
        public bool HasContract { get; set; }
        public int ContractPeriod { get; set; }
        public int NumberOfRegistration { get; set; }
        public Volunteer Volunteer { get; set; }
    }
}
