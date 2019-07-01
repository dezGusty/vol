using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Volunteers
{
    public class EditModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public EditModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Volunteer Volunteer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            Volunteer = await _context.Volunteer
                .Include(v => v.Address)
                        .Include(v => v.AditionalInfo)
                        .Include(v => v.ContactInformation)
                        .Include(v => v.Contract)
                        .Include(v => v.Workschedule)
                            .ThenInclude(w => w.Comments)
                .FirstOrDefaultAsync(m => m.VolunteerID == id);

            if (Volunteer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Volunteer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolunteerExists(Volunteer.VolunteerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VolunteerExists(int id)
        {
            return _context.Volunteer.Any(e => e.VolunteerID == id);
        }
    }
}
