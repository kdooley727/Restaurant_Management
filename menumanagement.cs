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
    public partial class menumanagement : Form
    {
        IMongoCollection<MenuItem> menuItemCollection;
        public menumanagement()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            menuItemCollection = database.GetCollection<MenuItem>("MenuItems");

            // Define DataGridView columns
            dgv_Menu.Columns.Add("ItemId", "Item ID");
            dgv_Menu.Columns.Add("Name", "Name");
            dgv_Menu.Columns.Add("Description", "Description");
            dgv_Menu.Columns.Add("Price", "Price");
            dgv_Menu.Columns.Add("Category", "Category");

            RefreshMenuItems();
        }

        private void RefreshMenuItems()
        {
            // Clear DataGridView
            dgv_Menu.Rows.Clear();

            // Retrieve menu items from the collection
            var menuItems = menuItemCollection.Find(Builders<MenuItem>.Filter.Empty).ToList();

            // Add menu items to DataGridView
            foreach (var menuItem in menuItems)
            {
                dgv_Menu.Rows.Add(menuItem.ItemId, menuItem.Name, menuItem.Description, menuItem.Price, menuItem.Category);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string itemId = txtbox_ItemId.Text;
            string name = txtbox_Name.Text;
            string description = txtbox_Description.Text;
            decimal price;
            if (!decimal.TryParse(txtbox_Price.Text, out price))
            {
                MessageBox.Show("Price must be a valid decimal value.");
                return;
            }
            string category = combox_Category.Text;

            if (string.IsNullOrEmpty(itemId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            MenuItem newItem = new MenuItem
            {
                ItemId = itemId,
                Name = name,
                Description = description,
                Price = price,
                Category = category
            };

            menuItemCollection.InsertOne(newItem);

            RefreshMenuItems();

            MessageBox.Show("Menu item added successfully!");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgv_Menu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item to update.");
                return;
            }

            // Get the selected row index
            int selectedIndex = dgv_Menu.SelectedRows[0].Index;

            // Retrieve input values from the form
            string itemId = txtbox_ItemId.Text;
            string name = txtbox_Name.Text;
            string description = txtbox_Description.Text;
            decimal price;
            if (!decimal.TryParse(txtbox_Price.Text, out price))
            {
                MessageBox.Show("Price must be a valid decimal value.");
                return;
            }
            string category = combox_Category.Text;

            // Validate input fields
            if (string.IsNullOrEmpty(itemId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                // Get the ObjectId of the selected menu item
                string selectedItemId = dgv_Menu.Rows[selectedIndex].Cells[0].Value.ToString();

                // Create a filter to find the menu item by its ItemId
                var filter = Builders<MenuItem>.Filter.Eq("ItemId", selectedItemId);

                // Create an update definition to update the menu item details
                var update = Builders<MenuItem>.Update
                    .Set("Name", name)
                    .Set("Description", description)
                    .Set("Price", price)
                    .Set("Category", category);

                // Update the menu item in the MenuItems collection
                menuItemCollection.UpdateOne(filter, update);

                // Refresh DataGridView to display the updated list of menu items
                RefreshMenuItems();

                MessageBox.Show("Menu item updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating menu item: {ex.Message}");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Retrieve input value (name) from the form
            string nameToDelete = txtbox_Name.Text; 

            // Validate input field
            if (string.IsNullOrEmpty(nameToDelete))
            {
                MessageBox.Show("Please enter the name of the menu item to delete.");
                return;
            }

            try
            {
                // Find the menu item to delete by its name
                var filter = Builders<MenuItem>.Filter.Eq("Name", nameToDelete);

                // Delete the menu item from the MenuItems collection
                var result = menuItemCollection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    // Menu item deleted successfully
                    RefreshMenuItems();
                    MessageBox.Show($"Menu item '{nameToDelete}' deleted successfully!");
                }
                else
                {
                    // Menu item with the specified name was not found
                    MessageBox.Show($"Menu item '{nameToDelete}' not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting menu item: {ex.Message}");
            }
        }
    }
}
