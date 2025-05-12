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
    internal class DBConnection
    {
        private MySqlConnection connection;

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

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
