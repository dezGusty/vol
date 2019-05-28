using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using VolCommon;

namespace Incercareax.Models
{
    public class Event : EventBase
    {
        [BsonId]
        public ObjectId EventID { get; set; }
    }
}