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
    public partial class feedback : Form
    {
        IMongoCollection<Feedbacks> feedbackCollection;

        private string LoggedInUserId {  get; set; }
        public feedback(string loggedInUserId)
        {
            InitializeComponent();

            LoggedInUserId = loggedInUserId;

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            feedbackCollection = database.GetCollection<Feedbacks>("Feedback");

            LoadFeedback();
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Capture input data from UI elements
                string orderId = txtbox_OrderId.Text;
                int rating = Convert.ToInt32(combox_Rating.SelectedItem);
                string comment = rtxbx_Comment.Text;

                // Generate a unique feedbackId
                string feedbackId = GenerateFeedbackId();

                // Create a Feedback object
                Feedbacks feedback = new Feedbacks
                {
                    FeedbackId = feedbackId,
                    UserId = LoggedInUserId,
                    OrderId = orderId,
                    Rating = rating,
                    Comment = comment
                };

                // Insert the Feedback object into the collection
                await feedbackCollection.InsertOneAsync(feedback);

                MessageBox.Show("Feedback submitted successfully!");

                LoadFeedback();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error submitting feedback: " + ex.Message);
            }
        }
        private string GenerateFeedbackId()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Generate a random 4-digit number
            string feedbackId = "feedback" + randomNumber.ToString();
            return feedbackId;
        }

        private async void LoadFeedback()
        {
            try
            {
                // Clear existing rows and columns
                dgv_Feedback.Rows.Clear();
                dgv_Feedback.Columns.Clear();

                // Add DataGridView columns
                dgv_Feedback.Columns.Add("FeedbackId", "Feedback ID");
                dgv_Feedback.Columns.Add("UserId", "User ID");
                dgv_Feedback.Columns.Add("OrderId", "Order ID");
                dgv_Feedback.Columns.Add("Rating", "Rating");
                dgv_Feedback.Columns.Add("Comment", "Comment");

                // Retrieve feedback from the collection
                var feedbacks = await feedbackCollection.Find(_ => true).ToListAsync();

                // Add feedback to the DataGridView
                foreach (var feedback in feedbacks)
                {
                    dgv_Feedback.Rows.Add(feedback.FeedbackId, feedback.UserId, feedback.OrderId, feedback.Rating, feedback.Comment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }

    }
}
