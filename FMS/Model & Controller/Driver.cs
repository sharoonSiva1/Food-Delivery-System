using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS.Model___Controller
{
    internal class Driver : User
        {
        public string DriverName { get; set; }
        public int Availability { get; set; }

        public Driver() : base()
        {
        }

        // Optional: Method to save customer-specific data if you have a separate 'customers' table
        public bool AddDriver(string userName, string password, string customerName)
        {
            // Step 1: Create base user
            this.userName = userName;
            this.password = password;
            this.userType = 2; // 2 for Customer
            this.Availability = 1;

            AddUser(userName, password, this.userType);

            int lastUserId = dbConnection.GetLastInsertId();

            string query = $"INSERT INTO drivers (ID, Name, Availability) VALUES ({lastUserId}, '{customerName}', '{Availability}')";

            try
            {
                dbConnection.ExecuteQuery(query);
                MessageBox.Show("Driver registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering driver: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public int AssignDriver()
        {
            int selectedDriverId = -1;
            string selectQuery = "SELECT ID FROM drivers WHERE Availability = 1 LIMIT 1";

            DBConnection db = new DBConnection();

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(selectQuery, db.GetConnection());
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    selectedDriverId = Convert.ToInt32(reader["ID"]);
                }
                reader.Close();

                if (selectedDriverId != -1)
                {
                    string updateQuery = $"UPDATE drivers SET Availability = 0 WHERE ID = {selectedDriverId}";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, db.GetConnection());
                    updateCmd.ExecuteNonQuery();
                }

                db.CloseConnection();
            }
            return selectedDriverId;
        }
    }
}
