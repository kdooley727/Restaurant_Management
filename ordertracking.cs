using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class ordertracking : Form
    {
        public IMongoCollection<Orders> OrdersCollection { get; }
        private Timer timer;

        public ordertracking(IMongoCollection<Orders> ordersCollection)
        {
            InitializeComponent();
            OrdersCollection = ordersCollection;
            LoadOrders();

            // Set up timer
            timer = new Timer();
            timer.Interval = 30000; // 30 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void LoadOrders()
        {
            try
            {
                var orders = await OrdersCollection.Find(_ => true).ToListAsync();

                // Clear existing rows and columns
                dgv_OrderTracking.Rows.Clear();
                dgv_OrderTracking.Columns.Clear();

                // Define DataGridView columns
                dgv_OrderTracking.Columns.Add("OrderId", "Order ID");
                dgv_OrderTracking.Columns.Add("UserId", "User ID");
                dgv_OrderTracking.Columns.Add("OrderDate", "Order Date");
                dgv_OrderTracking.Columns.Add("Status", "Status");

                foreach (var order in orders)
                {
                    dgv_OrderTracking.Rows.Add(order.OrderId, order.UserId, order.OrderDate, order.Status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                await Task.Delay(30000);

                var placedFilter = Builders<Orders>.Filter.Eq("Status", "Placed");
                var inKitchenUpdate = Builders<Orders>.Update.Set("Status", "In Kitchen");
                await OrdersCollection.UpdateManyAsync(placedFilter, inKitchenUpdate);

                // Refresh orders after updating "Pending" to "In Kitchen"
                LoadOrders();

                // Wait for 30 seconds
                await Task.Delay(30000);

                // Update orders with status "In Kitchen" to "Served"
                var inKitchenFilter = Builders<Orders>.Filter.Eq("Status", "In Kitchen");
                var servedUpdate = Builders<Orders>.Update.Set("Status", "Served");
                await OrdersCollection.UpdateManyAsync(inKitchenFilter, servedUpdate);

                LoadOrders(); // Refresh the orders after updating status
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order status: " + ex.Message);
            }
        }
    }
}
