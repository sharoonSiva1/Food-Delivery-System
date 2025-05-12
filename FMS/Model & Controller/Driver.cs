using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Model___Controller
{
    internal class Driver : User
        {
        public string DriverName { get; set; }

        public Driver() : base()
        {
        }

        // Optional: Method to save customer-specific data if you have a separate 'customers' table
        public void AddDriver(string userName, string password, string customerName)
        {
            // Step 1: Create base user
            this.userName = userName;
            this.password = password;
            this.userType = 2; // 2 for Customer

            AddUser(userName, password, this.userType);

            int lastUserId = dbConnection.GetLastInsertId();

            string query = $"INSERT INTO drivers (ID, Name) VALUES ({lastUserId}, '{customerName}')";
            dbConnection.ExecuteQuery(query);

        }
    }
}
