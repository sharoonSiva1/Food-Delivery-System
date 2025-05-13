using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace FMS.Model___Controller
{
    internal class Menu
    {
        private DBConnection db;
        public Menu()
        {
            db = new DBConnection();
        }

        // Add new menu item
        public void AddItem(int restaurantId, string name, string description, decimal price, bool availability)
        {
            string query = $"INSERT INTO menuitems (RestaurantID, Name, Description, Price, Availability) " +
                           $"VALUES ('{restaurantId}', '{name}', '{description}', {price}, {availability})";

            try
            {
                db.ExecuteQuery(query);
                MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Edit existing item
        public void EditItem(int itemId, string name, string description, decimal price, bool availability)
        {
            string query = "UPDATE menuitems SET ";
            var updates = new System.Collections.Generic.List<string>();

            if (!string.IsNullOrWhiteSpace(name))
                updates.Add($"Name = '{name}'");
            if (!string.IsNullOrWhiteSpace(description))
                updates.Add($"Description = '{description}'");
            if (price > 0)
                updates.Add($"Price = {price}");
                updates.Add($"Availability = {availability}");

            if (updates.Count > 0)
            {
                query += string.Join(", ", updates) + $" WHERE ItemID = {itemId}";

                try
                {
                    db.ExecuteQuery(query);
                    MessageBox.Show("Menu item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No changes provided.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Delete menu item
        public void DeleteItem(int itemId)
        {
            string query = $"DELETE FROM menuitems WHERE ItemID = {itemId}";

            try
            {
                db.ExecuteQuery(query);
                MessageBox.Show("Menu item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Load Items

        public void LoadMenuItemsForRestaurant(int restaurantId, DataGridView grid)
        {
            string query = $"SELECT ItemID, Name, Description, Price, Availability FROM menuitems WHERE RestaurantID = {restaurantId}";

            if (db.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    grid.DataSource = table;
                    grid.Columns["ItemID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading menu items: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
        public DataTable GetMenuItemById(int itemId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM menuitems WHERE ItemID = {itemId}";

            if (db.OpenConnection())
            {
                try
                {
                    using (var command = new MySqlCommand(query, db.GetConnection()))
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching menu item: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }

            return dt;
        }
    }
}
