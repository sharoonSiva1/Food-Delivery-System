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
            try
            {
                string restName = NameTextBox.Text.Trim();
                string description = DescTextBox.Text.Trim();
                string address = AddTextBox.Text.Trim();
                DateTime openTime = OpenTimeBox.Value;
                DateTime closeTime = CloseTimeBox.Value;
                string username = UsernameTextBox.Text.Trim();
                string password = PasswordTextBox.Text;
                string confirmPassword = ConfirmPasswordTextBox.Text;

                // Basic validation
                if (string.IsNullOrWhiteSpace(restName) ||
                    string.IsNullOrWhiteSpace(description) ||
                    string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (openTime >= closeTime)
                {
                    MessageBox.Show("Opening time must be earlier than closing time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((closeTime - openTime).TotalHours < 6)
                {
                    MessageBox.Show("The restaurant's closing time must be at least 6 hours after the opening time.", "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Restaurant rest = new Restaurant();
                bool created = rest.CreateRestaurant(username, password, restName, description, address, openTime, closeTime);

                if (created)
                {
                    MessageBox.Show("Restaurant registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Login().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to register restaurant. Username might already exist.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestaurantSignUp_Load(object sender, EventArgs e)
        {
            OpenTimeBox.Format = DateTimePickerFormat.Custom;
            OpenTimeBox.CustomFormat = "HH:mm";
            OpenTimeBox.ShowUpDown = true;

            CloseTimeBox.Format = DateTimePickerFormat.Custom;
            CloseTimeBox.CustomFormat = "HH:mm";
            CloseTimeBox.ShowUpDown = true;

        }
    }
}
