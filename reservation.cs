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

namespace RestaurantManagement
{
    public partial class reservation : Form
    {
        private string userId;
        IMongoCollection<Reservations> reservationCollection;
        public reservation(string userId)
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            reservationCollection = database.GetCollection<Reservations>("Reservations");
            this.userId = userId;
            LoadTimeOptions();
        }

        private void LoadTimeOptions()
        {
            // Add time options to the ComboBox
            List<string> timeOptions = new List<string>
            {
                "12:00", "12:30", "1:00", "1:30",
                "2:00", "2:30", "3:00", "3:30",
                "4:00", "4:30", "5:00", "5:30",
                "6:00", "6:30", "7:00", "7:30",
                "8:00", "8:30", "9:00", "9:30",
                "10:00", "10:30", "11:00", "11:30"
            };

            combox_Time.DataSource = timeOptions;
        }

        private async void btn_Book_Click(object sender, EventArgs e)
        {
            try
            {
                // Capture reservation details from UI elements
                decimal tableNumber = decimal.Parse(txtbox_Table.Text);
                DateTime reservationDate = dateTimePicker1.Value.Date;
                string selectedTime = combox_Time.SelectedItem.ToString();
                DateTime reservationDateTime = reservationDate.Date + TimeSpan.Parse(selectedTime);
                decimal numberOfPeople = decimal.Parse(txtbox_PartySize.Text);

                string reservationNumber = GenerateReservationNumber();

                // Create a Reservation object
                Reservations reservation = new Reservations
                {
                    UserId = userId, // Set the userId based on the logged-in user
                    TableNumber = tableNumber,
                    ReservationDate = reservationDateTime,
                    NumberOfPeople = numberOfPeople,
                    ReservationId = reservationNumber
                };

                // Insert the reservation into the collection
                await reservationCollection.InsertOneAsync(reservation);

                MessageBox.Show("Reservation booked successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking reservation: " + ex.Message);
            }
        }
        private string GenerateReservationNumber()
        {
            // Generate a unique reservation number based on current date/time and a random number
            string dateString = DateTime.Now.ToString("yyyyMMddHHmmss");
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Generate a random 4-digit number
            string reservationNumber = dateString + randomNumber.ToString();
            return reservationNumber;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the reservation number from the user input
                string reservationNumber = txtbox_ResNum.Text;

                // Define the filter to find the reservation based on its reservation number
                var filter = Builders<Reservations>.Filter.Eq(r => r.ReservationId, reservationNumber);

                // Delete the reservation from the collection
                var result = reservationCollection.DeleteOne(filter);

                // Check if the reservation was found and deleted successfully
                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Reservation canceled successfully!");
                }
                else
                {
                    MessageBox.Show("Reservation not found or already canceled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error canceling reservation: " + ex.Message);
            }
        }
    }
}
