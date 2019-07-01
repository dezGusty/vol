using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteersEventsApp.Models
{
    public class Allocate
    { public int AllocateID { get; set; }
        public bool IsAllocate { get; set; }
        public Volunteer Volunteer { get; set; }
    }
}
