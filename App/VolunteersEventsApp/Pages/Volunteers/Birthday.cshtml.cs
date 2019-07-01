using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Volunteers
{
    public class BirthdayModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _contextb;

        public BirthdayModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _contextb = context;
        }

        public IList<Volunteer> Volunteerb { get;set; }

        public async Task OnGetAsync()
        {



            Volunteerb = await _contextb.Volunteer.ToListAsync();
        }
    }
}
