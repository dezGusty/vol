using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VolunteersEventsApp.Models;


namespace VolunteersEventsApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VolunteersEventsApp.Models.Volunteer> Volunteer { get; set; }
        public DbSet<VolunteersEventsApp.Models.Address> Address { get; set; }
        public DbSet<VolunteersEventsApp.Models.Aditionalinfo> Aditionalinfo { get; set; }
        public DbSet<VolunteersEventsApp.Models.Comments> Comments { get; set; }
        public DbSet<VolunteersEventsApp.Models.ContactInformation> ContactInformation{ get; set; }
        public DbSet<VolunteersEventsApp.Models.Contract> Contract { get; set; }
        public DbSet<VolunteersEventsApp.Models.RegistrationDay> RegistrationDay { get; set; }
        public DbSet<VolunteersEventsApp.Models.Workschedule> Workschedule { get; set; }
        public DbSet<VolunteersEventsApp.Models.Event> Event { get; set; }
    }
}
