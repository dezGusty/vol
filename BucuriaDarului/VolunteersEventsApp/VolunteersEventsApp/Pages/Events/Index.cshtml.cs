using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Data;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Events
{
    public class IndexModel : PageModel
    {
        private readonly VolunteersEventsApp.Data.ApplicationDbContext _context;

        public IndexModel(VolunteersEventsApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }
    }
}
