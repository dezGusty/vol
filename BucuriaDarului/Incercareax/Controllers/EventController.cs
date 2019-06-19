using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Incercareax.Models;
using Incercareax.App_Start;

namespace Incercareax.Controllers
{
    public class EventController : Controller
    {
        private MongoDBContext dbcontext;
        private IMongoCollection<Event> eventcollection;
        private IMongoCollection<Volunteer> vollunteercollection;

        public EventController()
        {
            dbcontext = new MongoDBContext();
            eventcollection = dbcontext.database.GetCollection<Event>("events");
            vollunteercollection = dbcontext.database.GetCollection<Volunteer>("volunteers");
        }

        public ActionResult Index(string searching)
        {
            List<Event> events = eventcollection.AsQueryable<Event>().ToList();
            if (searching != null)
            {
                return View(events.Where(x => x.NameOfEvent.Contains(searching)).ToList());
            }
            else
            {
                return View(events);
            }
        }

        public ActionResult VolunteerAllocation (string id, string searching)
        {
            List<Volunteer> volunteers = vollunteercollection.AsQueryable<Volunteer>().ToList();
            List<Event> events = eventcollection.AsQueryable<Event>().ToList();
            var names = events.Find(b => b.EventID.ToString() == id);
            ViewBag.strname = names.AllocatedVolunteers.ToString();
            ViewBag.Eventname = names.NameOfEvent.ToString();
            if (searching != null)
            {
                ViewBag.Evid = id;
                return View(volunteers.Where(x => x.Firstname.Contains(searching)).ToList());
            }
            else
            {
                ViewBag.Evid = id;
                return View(volunteers);
            }
        }

        [HttpPost]
        public ActionResult VolunteerAllocation(string[] vols, string Evid)
        {

            try
            {
                string volname = "";
                for (int i = 0; i < vols.Length; i++)
                {
                    var volunteerId = new ObjectId(vols[i]);
                    var volunteer = vollunteercollection.AsQueryable<Volunteer>().SingleOrDefault(x => x.VolunteerID == volunteerId);
                    
                    volname = volname + volunteer.Firstname + " " + volunteer.Lastname + "; ";
                    var filter = Builders<Event>.Filter.Eq("_id", ObjectId.Parse(Evid));
                    var update = Builders<Event>.Update
                        .Set("AllocatedVolunteers",volname);

                    var result = eventcollection.UpdateOne(filter, update);
                }
         
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //public ActionResult returner(string evid, Volunteer vol)
        //{

        //}


        // GET: Volunteer/Details/5
        public ActionResult Details(string id)
        {
            var eventId = new ObjectId(id);
            var eventt = eventcollection.AsQueryable<Event>().SingleOrDefault(x => x.EventID == eventId);

            return View(eventt);
        }

        // GET: Volunteer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Volunteer/Create
        [HttpPost]
        public ActionResult Create(Event eventt)
        {
            try
            {
                eventt.DateOfEvent = eventt.DateOfEvent.AddHours(5);
                eventcollection.InsertOne(eventt);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Volunteer/Edit/5
        public ActionResult Edit(string id)
        {
            var eventId = new ObjectId(id);
            var eventt = eventcollection.AsQueryable<Event>().SingleOrDefault(x => x.EventID == eventId);
            return View(eventt);
        }

        // POST: Volunteer/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Event eventt)
        {
            try
            {
                var filter = Builders<Event>.Filter.Eq("_id", ObjectId.Parse(id));
                var update = Builders<Event>.Update
                    .Set("NameOfEvent", eventt.NameOfEvent)
                    .Set("PlaceOfEvent", eventt.PlaceOfEvent)
                    .Set("DateOfEvent", eventt.DateOfEvent.AddHours(5))
                    .Set("NumberOfVolunteersNeeded", eventt.NumberOfVolunteersNeeded)
                    .Set("TypeOfActivities", eventt.TypeOfActivities)
                    .Set("TypeOfEvent", eventt.TypeOfEvent)
                    .Set("Duration", eventt.Duration);


                var result = eventcollection.UpdateOne(filter, update);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       

        // GET: Volunteer/Delete/5
        public ActionResult Delete(string id)
        {
            var eventId = new ObjectId(id);
            var eventt = eventcollection.AsQueryable<Event>().SingleOrDefault(x => x.EventID == eventId);
            return View(eventt);
        }

        // POST: Volunteer/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                eventcollection.DeleteOne(Builders<Event>.Filter.Eq("_id", ObjectId.Parse(id)));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
