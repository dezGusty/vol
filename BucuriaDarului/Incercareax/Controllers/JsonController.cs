using Incercareax.App_Start;
using Incercareax.Models;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Json;
using System.Web.Mvc;

namespace Incercareax.Controllers
{
    public class JsonController : Controller
    {
        private MongoDBContext dbcontext;
        private IMongoCollection<Event> eventcollection;
        private IMongoCollection<Volunteer> vollunteercollection;


        public JsonController()
        {
            dbcontext = new MongoDBContext();
            eventcollection = dbcontext.database.GetCollection<Event>("events");
            vollunteercollection = dbcontext.database.GetCollection<Volunteer>("volunteers");
        }

        [HttpPost]
        public ActionResult SavetoJson()
        {
            try
            {
                System.IO.File.WriteAllText(@"D:\", "BLALDALSDLASDLASDLASLDASLD");
                //        string tojson = Newtonsoft.Json.JsonConvert.SerializeObject(eventcollection);
                //        if (tojson[0] == '[')
                //        {
                //            System.IO.File.WriteAllText(@"..\..\data\volunteers.json", tojson);
                //        }
                //        else
                //        {
                //            System.IO.File.WriteAllText(@"..\..\data\volunteer.json", "[");
                //            System.IO.File.AppendAllText(@"..\..\data\volunteer.json", tojson);
                //            System.IO.File.AppendAllText(@"..\..\data\volunteer.json", "]");
                //        }
                //    }
                //}
                //catch
                //{
                //    return View();
                //}

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

            public ActionResult Index()
        {  
            return View();
        }
    }
}