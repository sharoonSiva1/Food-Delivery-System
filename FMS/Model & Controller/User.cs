using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void DeleteUser(int userID)
        {
            string query = $"DELETE FROM users WHERE userID = {userID}";
            dbConnection.ExecuteQuery(query);
        }
    }
}
