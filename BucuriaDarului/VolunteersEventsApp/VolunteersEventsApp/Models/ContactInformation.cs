using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolunteersEventsApp.Models
{
    public class ContactInformation
    {
        public int ContactInformationID { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public Volunteer Volunteer { get; set; }
    }
}
