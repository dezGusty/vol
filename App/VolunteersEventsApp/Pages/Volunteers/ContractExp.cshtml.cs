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
    public class ContractExpModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public ContractExpModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

        

        public IList<Volunteer> Volunteer { get;set; }

        public async Task OnGetAsync()
        {

            Volunteer = await _context.Volunteer
                .Include(v => v.Contract)
                .ToListAsync();

        }

    }
}

