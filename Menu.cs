using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class MenuItem
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        //id
        public string Id { get; set; }

        [BsonElement("ItemId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string ItemId { get; set; }

        [BsonElement("Name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string Name { get; set; }

        [BsonElement("Description"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string Description { get; set; }

        [BsonElement("Price"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]

        public decimal Price { get; set; }

        [BsonElement("Category"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string Category { get; set; }
    }
}
