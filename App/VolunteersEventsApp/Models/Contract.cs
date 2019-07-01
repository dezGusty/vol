using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
       
    }
}
