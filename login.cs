using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Configuration;

namespace RestaurantManagement
{
    public partial class login : Form
    {
        IMongoCollection<User> usersCollection;
        private string loggedInUserId;
        private mainmenu mainMenuForm;

        public string LoggedInUserId
        {
            get { return loggedInUserId; }
        }
        public login(mainmenu mainMenuForm)
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            usersCollection = database.GetCollection<User>("Users");
            this.mainMenuForm = mainMenuForm;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtbox_LoginUsername.Text;
            string password = txtbox_LoginPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var filter = Builders<User>.Filter.Eq("Username", username) &
                         Builders<User>.Filter.Eq("Password", password);

            var user = usersCollection.Find(filter).FirstOrDefault(); // Retrieve the user

            if (user != null)
            {
                loggedInUserId = user.Id;
                mainMenuForm.OnLoginSuccess(loggedInUserId); // Pass the logged-in user ID to mainmenu form
                MessageBox.Show("Login successful!");
                this.Close(); // Close the login form
            }
            else
            {
                Console.WriteLine("No user found with username: " + username + " and password: " + password);
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
