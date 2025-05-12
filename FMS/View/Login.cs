using FMS.Model___Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            User user = new User().GetUser(username);

            if (user == null || user.password != password)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            } else
            {
                if (user.userType == 1)
                {
                    new RestaurantUI(user.userID).Show();
                    this.Hide();
                }
                else if (user.userType == 2)
                {
                    new DriverUI().Show();
                    this.Hide();
                }
                else if (user.userType == 3)
                {
                    new CustomerUI().Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
