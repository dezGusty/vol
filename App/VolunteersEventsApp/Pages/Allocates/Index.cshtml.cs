using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Allocates
{
    public class IndexModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public IndexModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

        public Allocate Allocate { get;set; }
        public IList<AllocateViewModel> AllocateVM { get; set; }


        public async Task OnGetAsync()
        {
            //     //Allocate = await _context.Allocate_1.ToListAsync();
            //     Allocate = await _context.Allocate_1
            //.Include(c => c.Volunteer)
            //.AsNoTracking()
            ////.ToListAsync();
            //Allocate = await _context.Allocate_1
            // .Include(c => c.Volunteer.Firstname)
            // .Include(c => c.Volunteer.Lastname)
            // .AsNoTracking()
            // .ToListAsync();
            await _context.SaveChangesAsync();

            AllocateVM = await _context.Volunteer
            .Select(p => new AllocateViewModel
            {
                AllocateID = p.VolunteerID,
                Firstname = p.Firstname,
                Lastname = p.Lastname,
              
               
            })
            .Include(p=>p.IsAllocate)
            .ToListAsync();

       

             async Task<IActionResult> OnPostAsync()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _context.Attach(Allocate).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllocateExists(Allocate.AllocateID))
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

             bool AllocateExists(int id)
            {
                return _context.Allocate_1.Any(e => e.AllocateID == id);
            }

        }
    }
}
