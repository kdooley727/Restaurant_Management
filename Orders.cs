using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public class Orders
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("OrderId")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string OrderId { get; set; }

        [BsonElement("UserId")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserId { get; set; }

        [BsonElement("Items")]
        public List<OrderItem> Items { get; set; }

        [BsonElement("OrderDate")]
        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime OrderDate { get; set; }

        [BsonElement("Status")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Status { get; set; } // "placed", "InKitchen", "Served"
    }

    public class OrderItem
    {
        [BsonElement("ItemId")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string ItemId { get; set; }

        [BsonElement("Name")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Name { get; set; }

        [BsonElement("Description")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Description { get; set; }

        [BsonElement("Price")]
        [BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Price { get; set; }

        [BsonElement("Category")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Category { get; set; }

        [BsonElement("Quantity")]
        [BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Quantity { get; set; }
    }
}

