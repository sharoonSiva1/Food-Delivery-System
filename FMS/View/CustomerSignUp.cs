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
    public partial class CustomerSignUp : Form
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string CustomerName = NameTextBox.Text;
            string Address = AddressTextBox.Text;
            string Username = UsernameTextBox.Text;
            string Password = PasswordTextBox.Text;

            new Customer().AddCustomer(Username, Password, CustomerName, Address);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
