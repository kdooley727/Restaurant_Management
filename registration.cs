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
    public partial class registration : Form
    {
        IMongoCollection<User> usersCollection;
        public registration()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            usersCollection = database.GetCollection<User>("Users");
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string userId = txtbox_UserId.Text;
            string username = txtbox_Username.Text;
            string password = txtbox_Password.Text;
            string email = txtbox_Email.Text;
            string role = combox_Role.Text;

            var filter = Builders<User>.Filter.Eq("username", username);
            var existingUser = usersCollection.Find(filter).Any();
            if (existingUser != null)
            {
                var user = new User
                {
                    UserId = userId,
                    Username = username,
                    Password = password,
                    Email = email,
                    Role = role
                };

                usersCollection.InsertOne(user);

                MessageBox.Show("Registration successful!");
            }
            else 
            {
                MessageBox.Show("Username already exists, Please choose a different one");
            }

        }
    }
}
