using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Incercareax.Models;
using Incercareax.App_Start;

namespace Incercareax.Controllers
{
    public class VolunteerController : Controller
    {
        private MongoDBContext dbcontext;
        private IMongoCollection<Event> eventcollection;
        private IMongoCollection<Volunteer> vollunteercollection;

        public VolunteerController()
        {
            dbcontext = new MongoDBContext();
            eventcollection = dbcontext.database.GetCollection<Event>("events");
            vollunteercollection = dbcontext.database.GetCollection<Volunteer>("volunteers");
        }

        public ActionResult Index(string searching)
        {
            List<Volunteer> volunteers = vollunteercollection.AsQueryable().ToList();
            if (searching != null)
            {
                return View(volunteers.Where(x => x.Firstname.Contains(searching) || x.Lastname.Contains(searching)).ToList());
            }
            else
            {
                return View(volunteers);
            }
        }

        public ActionResult Birthday()
        {
            List<Volunteer> volunteers = vollunteercollection.AsQueryable<Volunteer>().ToList();
            return View(volunteers);
        }

        public ActionResult ContractExp()
        {
            List<Volunteer> volunteers = vollunteercollection.AsQueryable<Volunteer>().ToList();
            return View(volunteers);
        }


        // GET: Volunteer/Details/5
        public ActionResult Details(string id)
        {
            var volunteerId = new ObjectId(id);
            var volunteer = vollunteercollection.AsQueryable<Volunteer>().SingleOrDefault(x => x.VolunteerID == volunteerId);

            return View(volunteer);
        }

        // GET: Volunteer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Volunteer/Create
        [HttpPost]
        public ActionResult Create(Volunteer volunteer)
        {
            try
            {
                volunteer.Birthdate = volunteer.Birthdate.AddHours(5);
                volunteer.Contract.RegistrationDate = volunteer.Contract.RegistrationDate.AddHours(5);
                volunteer.Contract.ExpirationDate = volunteer.Contract.ExpirationDate.AddHours(5);
                vollunteercollection.InsertOne(volunteer);
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
            var volunteerId = new ObjectId(id);
            var volunteer = vollunteercollection.AsQueryable<Volunteer>().SingleOrDefault(x => x.VolunteerID == volunteerId);
            return View(volunteer);
        }

        // POST: Volunteer/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Volunteer volunteer)
        {
            try
            {
                var filter = Builders<Volunteer>.Filter.Eq("_id", ObjectId.Parse(id));
                var update = Builders<Volunteer>.Update
                    .Set("Firstname", volunteer.Firstname)
                    .Set("Lastname", volunteer.Lastname)
                    .Set("Birthdate", volunteer.Birthdate.AddHours(5))
                    .Set("Address.Country", volunteer.Address.Country)
                    .Set("Address.City", volunteer.Address.City)
                    .Set("Address.Street", volunteer.Address.Street)
                    .Set("Address.Number", volunteer.Address.Number)
                    .Set("Gender", volunteer.Gender)
                    .Set("Desired_workplace", volunteer.Desired_workplace)
                    .Set("Field_of_activity", volunteer.Field_of_activity)
                    .Set("Occupation", volunteer.Occupation)
                    .Set("InActivity", volunteer.InActivity)
                    .Set("HourCount", volunteer.HourCount)
                    .Set("Contract.HasContract", volunteer.Contract.HasContract)
                    .Set("Contract.NumberOfRegistration", volunteer.Contract.NumberOfRegistration)
                    .Set("Contract.RegistrationDate", volunteer.Contract.RegistrationDate.AddHours(5))
                    .Set("Contract.ExpirationDate", volunteer.Contract.ExpirationDate.AddHours(5))
                    .Set("ContactInformation.PhoneNumber", volunteer.ContactInformation.PhoneNumber)
                    .Set("ContactInformation.MailAdress", volunteer.ContactInformation.MailAdress)
                    .Set("Additionalinfo.HasCar", volunteer.Additionalinfo.HasCar)
                    .Set("Additionalinfo.HasDrivingLicence", volunteer.Additionalinfo.HasDrivingLicence);
                var result = vollunteercollection.UpdateOne(filter, update);
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
            var volunteerId = new ObjectId(id);
            var volunteer = vollunteercollection.AsQueryable<Volunteer>().SingleOrDefault(x => x.VolunteerID == volunteerId);
            return View(volunteer);
        }

        // POST: Volunteer/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                vollunteercollection.DeleteOne(Builders<Volunteer>.Filter.Eq("_id", ObjectId.Parse(id)));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}