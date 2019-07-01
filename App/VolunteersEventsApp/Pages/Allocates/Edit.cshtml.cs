using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Allocates
{
    public class EditModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public EditModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Allocate Allocate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Allocate = await _context.Allocate_1.FirstOrDefaultAsync(m => m.AllocateID == id);

            if (Allocate == null)
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

        private bool AllocateExists(int id)
        {
            return _context.Allocate_1.Any(e => e.AllocateID == id);
        }
    }
}
