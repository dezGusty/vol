using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using VolCommon;

namespace Incercareax.Models
{

    public class Volunteer : VolunteerBase
    {
        [BsonId]
        public ObjectId VolunteerID { get; set; }

        [Required]
        override public string Firstname { get; set; } 
        
      
    }
}

