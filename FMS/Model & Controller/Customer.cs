using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Model___Controller
{
    public class Customer : User
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public Customer() : base()
        {
        }

        // Optional: Method to save customer-specific data if you have a separate 'customers' table
        public void AddCustomer(string userName, string password, string customerName, string address)
        {
            // Step 1: Create base user
            this.userName = userName;
            this.password = password;
            this.userType = 3; // 3 for Customer

            AddUser(userName, password, this.userType);

            int lastUserId = dbConnection.GetLastInsertId();

            string query = $"INSERT INTO customers (ID, Name, Address) VALUES ({lastUserId}, '{customerName}', '{address}')";
            dbConnection.ExecuteQuery(query);

        }
    }

}
