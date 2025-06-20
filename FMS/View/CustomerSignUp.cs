﻿using FMS.Model___Controller;
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
            string customerName = NameTextBox.Text;
            string address = AddressTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            Customer customer = new Customer();
            bool success = customer.AddCustomer(username, password, customerName, address);

            if (success)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
