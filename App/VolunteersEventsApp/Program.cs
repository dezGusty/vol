using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

      

        //public void WriteDataVolunteer()
        //{
            
        //    Excel excel1 = new Excel("D:/Work/Test.ods", 1);
        //    excel1.WriteExcelVolunteer(IList < Volunteer > Volunteers);
        //    excel1.SaveFile();
         
        //}
    }
}


