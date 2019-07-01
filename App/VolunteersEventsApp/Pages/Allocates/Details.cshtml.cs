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
    public class DetailsModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public DetailsModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

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
    }
}
