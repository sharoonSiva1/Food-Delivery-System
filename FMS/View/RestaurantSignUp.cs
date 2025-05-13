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
using System.Xml.Linq;

namespace FMS.View
{
    public partial class RestaurantSignUp : Form
    {
        public RestaurantSignUp()
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
            string restName = NameTextBox.Text;
            string description = DescTextBox.Text;
            string address = AddTextBox.Text;
            DateTime OpenTime = OpenTimeBox.Value;
            DateTime CloseTime = CloseTimeBox.Value;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            if (password == confirmPassword) 
            {
                Restaurant rest = new Restaurant();

                rest.CreateRestaurant(username, password, restName, description,  address, OpenTime, CloseTime);
            }

        }
    }
}
