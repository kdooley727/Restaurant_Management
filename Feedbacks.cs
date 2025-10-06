using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class Feedbacks
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        //id
        public string Id { get; set; }

        [BsonElement("FeedbackId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string FeedbackId { get; set; }

        [BsonElement("UserId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserId { get; set; }

        [BsonElement("OrderId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string OrderId { get; set; }

        [BsonElement("Rating"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]

        public int Rating { get; set; }

        [BsonElement("Comment"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string Comment
        {
            get; set;
        }
    }
}
