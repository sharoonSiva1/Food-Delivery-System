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
    public partial class DriverSignUp : Form
    {
        public DriverSignUp()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string name = NameTextBox.Text;

            Driver driver = new Driver();
            bool success = driver.AddDriver(username, password, name);

            if (success)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
