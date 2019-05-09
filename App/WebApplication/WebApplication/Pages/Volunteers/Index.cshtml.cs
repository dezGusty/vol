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
    public class IndexModel : PageModel
    {
        private readonly WebApplication.Models.WebApplicationContext _context;

        public IndexModel(WebApplication.Models.WebApplicationContext context)
        {
            _context = context;
        }

        public IList<WebApplication.Models.Volunteer> Volunteers { get;set; }

        public async Task OnGetAsync()
        {
            Volunteers = await _context.Volunteer.ToListAsync();
        }
    }
}
