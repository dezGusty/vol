using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }

        public Volunteer Volunteer { get; set; }
    }
}
