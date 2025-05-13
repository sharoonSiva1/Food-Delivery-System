using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMS.View;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace FMS.Model___Controller
{
    internal class Restaurant : User
    {
        public int RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public string Review { get; set; }

        private DBConnection connection;

        public Restaurant() : base()
        {
            connection = new DBConnection();
        }

        //Create Restaurant
        public bool CreateRestaurant(string username, string password, string name, string description, string address, DateTime openingTime, DateTime closingTime)
        {
            // Check if username already exists
            string checkQuery = $"SELECT COUNT(*) FROM users WHERE Username = '{username}'";
            int count = 0;

            try
            {
                if (dbConnection.OpenConnection())
                {
                    using (var command = new MySqlCommand(checkQuery, dbConnection.GetConnection()))
                    {
                        count = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConnection.CloseConnection();
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            if (count > 0)
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((closingTime - openingTime).TotalHours < 6)
            {
                MessageBox.Show("The restaurant's closing time must be at least 6 hours after the opening time.", "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            this.userName = username;
            this.password = password;
            this.userType = 1; // 1 for Customer

            AddUser(userName, password, this.userType);
            int lastUserId = dbConnection.GetLastInsertId();

            string query = $"INSERT INTO restaurants (ID, Name, Description, Address, OpenTime, CloseTime) " +
                           $"VALUES ('{lastUserId}', '{name}', '{description}', '{address}', '{openingTime:HH:mm}', '{closingTime:HH:mm}')";

            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Restaurant created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Edit an existing restaurant
        public void EditRestaurant(int id, string name, string description, string address, DateTime openingTime, DateTime closingTime)
        {
            // Ensure there is a 6-hour gap between OpenTime and CloseTime
            if ((closingTime - openingTime).TotalHours < 6)
            {
                MessageBox.Show("The restaurant's closing time must be at least 6 hours after the opening time.", "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"UPDATE restaurants SET ";
            List<string> updateFields = new List<string>();

            if (!string.IsNullOrEmpty(name))
                updateFields.Add($"Name = '{name}'");
            if (!string.IsNullOrEmpty(description))
                updateFields.Add($"description = '{description}'");
            if (!string.IsNullOrEmpty(address))
                updateFields.Add($"address = '{address}'");
            updateFields.Add($"OpenTime = '{openingTime:HH:mm}'");
            updateFields.Add($"CloseTime = '{closingTime:HH:mm}'");

            if (updateFields.Count > 0)
            {
                query += string.Join(", ", updateFields) + $" WHERE ID = {id};";

                try
                {
                    connection.ExecuteQuery(query);
                    MessageBox.Show("Restaurant updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Delete a restaurant
        public void DeleteRestaurant(int id)
        {
            string deleteMenuItems = $"DELETE FROM menuitems WHERE RestaurantID = {id};";
            connection.ExecuteQuery(deleteMenuItems);

            string deleteRestaurant = $"DELETE FROM restaurants WHERE ID = {id};";
            connection.ExecuteQuery(deleteRestaurant);

            string deleteUser = $"DELETE FROM users WHERE ID = {id};";
            connection.ExecuteQuery(deleteUser);
        }

        // Get all restaurants
        public List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            string query = "SELECT * FROM restaurants";

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Restaurant restaurant = new Restaurant
                            {
                                RestaurantID = reader.GetInt32("ID"),
                                RestaurantName = reader["Name"].ToString(),
                                Description = reader["description"].ToString(),
                                Address = reader["address"].ToString(),
                                OpeningTime = TimeSpan.Parse(reader["OpenTime"].ToString()),
                                ClosingTime = TimeSpan.Parse(reader["CloseTime"].ToString()),
                                Review = reader["Review"].ToString()
                            };
                            restaurants.Add(restaurant);
                        }
                    }
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return restaurants;
        }

        // Get restaurant by ID
        public Restaurant GetRestaurantById(int id)
        {
            Restaurant restaurant = null;
            string query = $"SELECT * FROM restaurants WHERE ID = {id}";

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            restaurant = new Restaurant
                            {
                                RestaurantName = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                Address = reader["Address"].ToString(),
                                OpeningTime = TimeSpan.Parse(reader["OpenTime"].ToString()),
                                ClosingTime = TimeSpan.Parse(reader["CloseTime"].ToString()),
                                Review = reader["Review"].ToString()
                            };
                        }
                    }
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return restaurant;
        }
    }
}
