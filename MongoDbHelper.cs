using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class MongoDbHelper
    {
        private readonly IMongoDatabase _database;

        public MongoDbHelper(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Orders> GetOrdersCollection()
        {
            return _database.GetCollection<Orders>("Orders");
        }
    }
}
