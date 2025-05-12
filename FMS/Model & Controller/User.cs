using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS.Model___Controller
{
    public class User
    {
        protected DBConnection dbConnection;
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int userType { get; set; } // 0 for admin, 1 for restaurant, 2 for delivery person

        public User()
        {
            dbConnection = new DBConnection();
        }
        public void AddUser(string userName, string password, int userType)
        {
            string query = $"INSERT INTO users (Username, Password, Role) VALUES ('{userName}', '{password}', {userType})";
            dbConnection.ExecuteQuery(query);
        }
        public void UpdateUser(int userID, string userName, string password, int userType)
        {
            string query = $"UPDATE users SET userName = '{userName}', password = '{password}', userType = {userType} WHERE userID = {userID}";
            dbConnection.ExecuteQuery(query);
        }

        public User GetUser(string username)
        {
            User user = null;
            if (dbConnection.OpenConnection())
            {
                try
                {
                    string query = "SELECT * FROM Users WHERE Username = @Username LIMIT 1";
                    using (var command = new MySqlCommand(query, dbConnection.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    userID = reader.GetInt32("ID"),
                                    userName = reader.GetString("Username"),
                                    password = reader.GetString("Password"),
                                    userType = reader.GetInt32("Role")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
            return user;
        }

    }
}
