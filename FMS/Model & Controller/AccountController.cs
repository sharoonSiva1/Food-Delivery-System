using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Model___Controller
{
    internal class AccountController
    {
        public AccountController() { }

        public void CreateAccount(string username, string password, int userType)
        {
            if (userType == 1) 
            {
                
            }
            // Logic to create an account
            // This could involve inserting the user into a database
            // For example:
            // string query = $"INSERT INTO users (username, password, userType) VALUES ('{username}', '{password}', {userType})";
            // dbConnection.ExecuteQuery(query);
        }

        public void Login(string username, string password, string confirmPassword) 
        { 
            if (password != confirmPassword)
            {
                throw new Exception("Passwords do not match.");
            }

            // Logic to log in the user
        }
    }
}
