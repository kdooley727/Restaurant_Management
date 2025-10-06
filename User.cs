using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class User
    {

        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("UserId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserId { get; set; }

        [BsonElement("Username"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Username { get; set; }

        [BsonElement("Password"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Password { get; set; }
        
        [BsonElement("Email"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Email { get; set; }

        [BsonElement("Role"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Role { get; set; }
    }
}
