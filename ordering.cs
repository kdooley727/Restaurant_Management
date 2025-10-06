using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Menu;

namespace RestaurantManagement
{
    public partial class ordering : Form
    {
        IMongoCollection<MenuItem> orderingCollection;
        IMongoCollection<Orders> ordersCollection;
        List<OrderItem> orderItems;
        private string LoggedInUserId {  get; set; }
        public ordering(string loggedInUserId)
        {
            InitializeComponent();
            LoggedInUserId = loggedInUserId;
            orderItems = new List<OrderItem>();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            orderingCollection = database.GetCollection<MenuItem>("MenuItems");
            ordersCollection = database.GetCollection<Orders>("Orders");

            // Define DataGridView columns

            dgv_Orders.Columns.Add("ItemId", "Item ID");
            dgv_Orders.Columns.Add("Name", "Name");
            dgv_Orders.Columns.Add("Description", "Description");
            dgv_Orders.Columns.Add("Price", "Price");
            dgv_Orders.Columns.Add("Category", "Category");
            dgv_Orders.Columns.Add("Quantity", "Quantity");

            RefreshOrderItems();
        }
        private void RefreshOrderItems()
        {
            // Clear DataGridView
            dgv_Orders.Rows.Clear();

            // Retrieve menu items from the collection
            var menuItems = orderingCollection.Find(Builders<MenuItem>.Filter.Empty).ToList();

            // Add menu items to DataGridView
            foreach (var menuItem in menuItems)
            {
                dgv_Orders.Rows.Add(menuItem.ItemId, menuItem.Name, menuItem.Description, menuItem.Price, menuItem.Category);
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            string userId = LoggedInUserId;

            // Generate order id (example)
            string orderId = "ORDER_" + Guid.NewGuid().ToString().Substring(0, 8);

            DateTime orderDate = DateTime.Now;

            // Iterate through DataGridView to retrieve orders
            foreach (DataGridViewRow row in dgv_Orders.Rows)
            {
                var quantityCell = row.Cells["Quantity"];
                if (row.Cells["Quantity"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Quantity"].Value.ToString()))
                {
                    if (int.TryParse(quantityCell.Value.ToString(), out int quantity) && quantity > 0)
                    {
                        var orderItem = new OrderItem
                        {
                            ItemId = row.Cells["ItemId"].Value.ToString(),
                            Name = row.Cells["Name"].Value.ToString(),
                            Description = row.Cells["Description"].Value.ToString(),
                            Price = Convert.ToDecimal(row.Cells["Price"].Value),
                            Category = row.Cells["Category"].Value.ToString(),
                            Quantity = quantity
                        };

                        orderItems.Add(orderItem);
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity value for item: " + row.Cells["Name"].Value.ToString());
                    }
                }
            }

            // Create the order object
            var order = new Orders
            {
                OrderId = orderId,
                UserId = userId,
                Items = orderItems,
                OrderDate = orderDate,
                Status = "Placed"
            };

            // Insert order into the MongoDB collection
            ordersCollection.InsertOne(order);

            MessageBox.Show("Order placed successfully!");
        }
    }
}
