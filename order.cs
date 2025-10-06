using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class order
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        //id
        public string Id { get; set; }

        [BsonElement("OrderId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string OrderId { get; set; }

        [BsonElement("UserId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserId { get; set; }

        [BsonElement("Items"), BsonRepresentation(MongoDB.Bson.BsonType.Array)]
        public Array Items { get; set; }

        [BsonElement("OrderDate"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime OrderDate { get; set; }

        [BsonElement("Status"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Status { get; set; }

    }
}
