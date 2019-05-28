using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using System.Configuration;
using System.Web;

namespace Incercareax.App_Start
{
    public class MongoDBContext
    {
        public IMongoDatabase database;

        public MongoDBContext()
        {
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }
    }
}