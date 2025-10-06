using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // MongoDB connection details
            string connectionString = "mongodb://localhost:27017/Restaurant";
            string databaseName = "Restaurant";

            // Create instance of MongoDbHelper
            var dbHelper = new MongoDbHelper(connectionString, databaseName);

            // Get the orders collection
            IMongoCollection<Orders> ordersCollection = dbHelper.GetOrdersCollection();

            // Start the application with the mainmenu form
            Application.Run(new mainmenu(ordersCollection));
        }
    }
}
