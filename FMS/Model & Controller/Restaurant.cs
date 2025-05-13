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
<<<<<<< HEAD
        public int ID { get; set; }
=======
        public int RestaurantID { get; set; }
>>>>>>> c5019d217a9aabaad3ea5b91650c94a1de16a8d9
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

        // Create a new restaurant
        public void CreateRestaurant(string username, string password, string name, string description, string address, DateTime openingTime, DateTime closingTime)
        {

            this.userName = username;
            this.password = password;
            this.userType = 1; // 1 for Customer

            AddUser(userName, password, this.userType);

            int lastUserId = dbConnection.GetLastInsertId();

            string query = $"INSERT INTO restaurants (ID, Name, Description, Address, OpenTime, CloseTime) " +
                           $"VALUES ('{lastUserId}', '{name}', '{description}', '{address}', '{openingTime}', '{closingTime}');";

            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Restaurant created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Edit an existing restaurant
        public void EditRestaurant(int id, string name, string description, string address, DateTime openingTime, DateTime closingTime)
        {
            string query = $"UPDATE restaurants SET ";
            List<string> updateFields = new List<string>();

            if (!string.IsNullOrEmpty(name))
                updateFields.Add($"Name = '{name}'");
            if (!string.IsNullOrEmpty(description))
                updateFields.Add($"description = '{description}'");
            if (!string.IsNullOrEmpty(address))
                updateFields.Add($"address = '{address}'");
            updateFields.Add($"OpenTime = '{openingTime}'");
            updateFields.Add($"CloseTime = '{closingTime}'");

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
            string query = $"DELETE FROM restaurants WHERE ID = {id};";

            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Restaurant deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
