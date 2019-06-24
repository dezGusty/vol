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