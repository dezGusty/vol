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
        public string Days { get; set; }
        public string TimeAvailability { get; set; }
   


    }
}
