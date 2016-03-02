using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chavp.Accounting
{
    public abstract class DomainModel
    {

        [BsonId]
        public ObjectId Id { get; protected set; }

        [BsonDateTimeOptions(Representation = BsonType.Document)]
        public DateTime CreatedOn { get; } = DateTime.UtcNow;

        [BsonDateTimeOptions(Representation = BsonType.Document)]
        public DateTime? LastModified { get; protected set; }
    }
}
