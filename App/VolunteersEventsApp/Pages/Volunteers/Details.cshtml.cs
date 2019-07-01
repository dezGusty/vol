using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Volunteers
{
    public class DetailsModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public DetailsModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

        public Volunteer Volunteer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Volunteer = await _context.Volunteer.FirstOrDefaultAsync(m => m.VolunteerID == id);
            Volunteer = await _context.Volunteer
                        .Include(v => v.Address)
                        .Include(v => v.AditionalInfo)
                        .Include(v => v.ContactInformation)
                        .Include(v => v.Contract)
                        .Include(v => v.Workschedule)
                            .ThenInclude(w => w.Comments)
                        .AsNoTracking()
                        .FirstOrDefaultAsync(m => m.VolunteerID == id);
            if (Volunteer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
