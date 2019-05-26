using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Incercareax.Models
{
    public class Event
    {
        [BsonId]
        public ObjectId EventID { get; set; }

        [Required]
        public string NameOfEvent { get; set; }

        public string PlaceOfEvent { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfEvent { get; set; }

        public int NumberOfVolunteersNeeded { get; set; }

        public string TypeOfActivities { get; set; }

        public string TypeOfEvent { get; set; }

        public int Duration { get; set; }
    }
}
