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
    public class DeleteModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public DeleteModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Allocate = await _context.Allocate_1.FindAsync(id);

            if (Allocate != null)
            {
                _context.Allocate_1.Remove(Allocate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
