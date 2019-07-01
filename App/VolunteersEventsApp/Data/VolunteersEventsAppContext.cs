using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace VolunteersEventsApp.Models
{
    public class VolunteersEventsAppContext : DbContext
    {
        public VolunteersEventsAppContext (DbContextOptions<VolunteersEventsAppContext> options)
            : base(options)
        {
        }

        public DbSet<VolunteersEventsApp.Models.Event> Event { get; set; }
        //public DbSet<VolunteersEventsApp.Models.Event> Allocate { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> Volunteer { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> Address { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> Aditionalinfo { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> Comment { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> ContactInformation { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> Contract { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> RegistrationeDay { get; set; }
        public DbSet<VolunteersEventsApp.Models.Volunteer> Workschedule { get; set; }
        public DbSet<VolunteersEventsApp.Models.Allocate> Allocate_1 { get; set; }
    }
}
