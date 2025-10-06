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
    public partial class mainmenu : Form
    {
        private string LoggedInUserId { get; set; }
        private bool IsLoggedIn { get; set; }
        private string FirstLoggedInUserId { get; set; }
        public IMongoCollection<Orders> OrdersCollection { get; set; }
        public mainmenu(IMongoCollection<Orders> ordersCollection)
        {
            InitializeComponent();

            IsLoggedIn = false;
            UpdateUI();
            OrdersCollection = ordersCollection;
        }

        // Method to update the UI based on login status
        private void UpdateUI()
        {
            // Enable or disable buttons based on login status
            btn_Menu.Enabled = IsLoggedIn;
            btn_Orders.Enabled = IsLoggedIn;
            btn_Reservation.Enabled = IsLoggedIn;
            btn_Feedback.Enabled = IsLoggedIn;
            btn_OrderTracking.Enabled = IsLoggedIn;
        }

        // Method to handle successful login
        public void OnLoginSuccess(string loggedInUserId)
        {
            LoggedInUserId = loggedInUserId;
            IsLoggedIn = true;
            UpdateUI();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Instantiate the login form
            login loginForm = new login(this);

            // Show the login form as a dialog
            var result = loginForm.ShowDialog();

            // Check if the login form was closed with OK result
            if (result == DialogResult.OK)
            {
                // Retrieve the logged-in user ID from the login form
                string userId = loginForm.LoggedInUserId;

                // Check if the user ID is not null
                if (userId != null)
                {
                    // Update the logged-in user ID in the mainmenu form
                    LoggedInUserId = userId;

                    UpdateUI();
                }
                else
                {
                    // Handle case where login failed
                    MessageBox.Show("Login failed. Please try again.");
                }
            }
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            registration registration = new registration();

            registration.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menumanagement menumanagement = new menumanagement();

            menumanagement.Show();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            ordering ordering = new ordering(LoggedInUserId);

            ordering.Show();
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            reservation reservation = new reservation(LoggedInUserId);

            reservation.Show();
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            string loggedInUserId = LoggedInUserId;

            feedback feedback = new feedback(loggedInUserId);

            feedback.Show();
        }

        private void btn_OrderTracking_Click(object sender, EventArgs e)
        {
            ordertracking ordertracking = new ordertracking(OrdersCollection);

            ordertracking.Show();
        }
    }
}
