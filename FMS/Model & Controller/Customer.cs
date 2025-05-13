using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS.Model___Controller
{
    public class Customer : User
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public Customer() : base()
        {
        }

        public bool AddCustomer(string userName, string password, string customerName, string address)
        {
            // Check if username already exists
            string checkQuery = $"SELECT COUNT(*) FROM users WHERE Username = '{userName}'";
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

            // Proceed to create customer
            this.userName = userName;
            this.password = password;
            this.userType = 3; // 3 for Customer

            AddUser(userName, password, this.userType);
            int lastUserId = dbConnection.GetLastInsertId();

            string query = $"INSERT INTO customers (ID, Name, Address) VALUES ({lastUserId}, '{customerName}', '{address}')";

            try
            {
                dbConnection.ExecuteQuery(query);
                MessageBox.Show("Customer registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
