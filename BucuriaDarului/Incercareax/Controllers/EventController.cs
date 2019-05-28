using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using System.Configuration;
using Incercareax.Models;
using Incercareax.App_Start;

namespace Incercareax.Controllers
{
    public class EventController : Controller
    {
        private MongoDBContext dbcontext;
        private IMongoCollection<Event> eventcollection;

        public EventController()
        {
            dbcontext = new MongoDBContext();
            eventcollection = dbcontext.database.GetCollection<Event>("events");
        }
        public ActionResult Index()
        {
            List<Event> events = eventcollection.AsQueryable<Event>().ToList();
            return View(events);
        }

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
                    .Set("Firstname", eventt.NameOfEvent);
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
