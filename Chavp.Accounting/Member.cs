using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chavp.Accounting
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class Member : DomainModel
    {
        public Member(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
