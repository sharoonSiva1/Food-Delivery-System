using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FMS.Model___Controller
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string connectionString;

        public DBConnection()
        {
            string connectionString = "server=localhost;database=food_delivery_system;user=root;password=;";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Closing Error: " + ex.Message, "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ExecuteQuery(string query)
        {
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Execution Error: " + ex.Message, "Query Execution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public int GetLastInsertId()
        {
            int id = -1;
            if (OpenConnection())
            {
                try
                {
                    string query = "SELECT LAST_INSERT_ID()";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving last insert ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }
            }
            return id;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
