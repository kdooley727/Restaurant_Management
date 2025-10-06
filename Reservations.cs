using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public class Reservations
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        //id
        public string Id { get; set; }

        [BsonElement("ReservationId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string ReservationId { get; set; }

        [BsonElement("UserId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserId { get; set; }

        [BsonElement("TableNumber"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal TableNumber { get; set; }

        [BsonElement("ReservationDate"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime ReservationDate { get; set; }

        [BsonElement("NumberOfPeople"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal NumberOfPeople { get; set; }
    }
}
