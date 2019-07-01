using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Pages.Volunteers
{
    public class IndexModel : PageModel
    {
        private readonly VolunteersEventsApp.Models.VolunteersEventsAppContext _context;

        public IndexModel(VolunteersEventsApp.Models.VolunteersEventsAppContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Volunteer> Volunteer { get; set; }
        Excel excel = new Excel("D:/Work/Test.Test.ods", 1);

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            CurrentFilter = searchString;

            IQueryable<Volunteer> volunteerIQ = from v in _context.Volunteer
                                                select v;

            if (!String.IsNullOrEmpty(searchString))
            {
                volunteerIQ = volunteerIQ.Where(v => v.Lastname.Contains(searchString)
                                       || v.Firstname.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    volunteerIQ = volunteerIQ.OrderByDescending(v => v.Lastname);
                    break;

                default:
                    volunteerIQ = volunteerIQ.OrderBy(v => v.Firstname);
                    break;
            }

            Volunteer = await volunteerIQ.AsNoTracking().ToListAsync();
            excel.WriteExcelVolunteer(Volunteer);
            excel.SaveFile();


            }
    }
}
