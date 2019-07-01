using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Allocates
{
    public class CreateModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public CreateModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Allocate Allocate { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Allocate_1.Add(Allocate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}