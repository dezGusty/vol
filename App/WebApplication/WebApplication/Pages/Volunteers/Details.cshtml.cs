using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;
namespace WebApplication.Pages.Volunteers
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication.Models.WebApplicationContext _context;

        public DetailsModel(WebApplication.Models.WebApplicationContext context)
        {
            _context = context;
        }

        public WebApplication.Models.Volunteer Volunteer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Volunteer = await _context.Volunteer.FirstOrDefaultAsync(m => m.ID == id);

            if (Volunteer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
