using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chavp.Accounting.Test
{
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Bson;
    using MongoDB.Driver;
    [TestClass]
    public class Db
    {
        string connection = "mongodb://dev:123456789@ds064188.mlab.com:64188/accounting";

        MongoClient server = null;
        IMongoDatabase db = null;

        [TestInitialize]
        public void _setup()
        {
            server = new MongoClient(connection);
            db = server.GetDatabase("accounting");
        }

        [TestMethod]
        public void test_connection()
        {

            var members = db.GetCollection<Member>("members");

            var filter = new BsonDocument();
            long expected = 0;
            Assert.AreNotEqual(expected, members.Count(filter));

        }

        [TestMethod]
        public void test_insert_member()
        {
            var members = db.GetCollection<Member>("members");
            members.InsertOne(new Member ("Ding"));
        }


        [TestMethod]
        public void async_query()
        {
            var collection = db.GetCollection<Member>("members");
            var filter = Builders<Member>.Filter.Eq("Name", "Ding");
            var result = collection.Find(filter).Single();
            result.Name = "Ding2";

            var update = Builders<Member>.Update
                .Set("Name", "Ding2")
                .CurrentDate("LastModified");

            collection.UpdateOne(filter, update);

            Assert.AreNotEqual(null, result);
        }


    }
}
