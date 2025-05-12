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
    public partial class RestaurantManageProfileUI : Form
    {
        private Restaurant restaurant;
        private int RestaurantId;
        public RestaurantManageProfileUI(int restaurantId)
        {
            InitializeComponent();
            restaurant = new Restaurant();

            // Set format for time pickers
            OpeningTimeBox.Format = DateTimePickerFormat.Custom;
            OpeningTimeBox.CustomFormat = "HH:mm";
            ClosingTimeBox.Format = DateTimePickerFormat.Custom;
            ClosingTimeBox.CustomFormat = "HH:mm";
            RestaurantId = restaurantId;
        }  

        private void LoadRestaurantDetails()
        {
            var details = restaurant.GetRestaurantById(RestaurantId);

            if (details != null)
            {
                NameTextBox.Text = details.RestaurantName;
                DescTextBox.Text = details.Description;
                AddressTextBox.Text = details.Address;
                OpeningTimeBox.Value = DateTime.Today.Add(details.OpeningTime);
                ClosingTimeBox.Value = DateTime.Today.Add(details.ClosingTime);
            }
            else
            {
                MessageBox.Show("No restaurant profile found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            RestaurantUI restaurantUI = new RestaurantUI(RestaurantId);
            restaurantUI.Show();
            this.Hide();
        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string desc = DescTextBox.Text.Trim();
            string address = AddressTextBox.Text.Trim();
            DateTime opening = OpeningTimeBox.Value;
            DateTime closing = ClosingTimeBox.Value;

            restaurant.EditRestaurant(RestaurantId, name, desc, address, opening, closing);
        }

        private void DeleteProfileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to delete this restaurant? This action cannot be undone.",
        "Confirm Deletion",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Warning
        );

            if (result == DialogResult.OK)
            {
                Restaurant restaurant = new Restaurant();
                restaurant.DeleteRestaurant(RestaurantId);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void RestaurantManageProfileUI_Load_1(object sender, EventArgs e)
        {
            LoadRestaurantDetails();
            OpeningTimeBox.Format = DateTimePickerFormat.Custom;
            OpeningTimeBox.CustomFormat = "HH:mm";
            OpeningTimeBox.ShowUpDown = true;

            ClosingTimeBox.Format = DateTimePickerFormat.Custom;
            ClosingTimeBox.CustomFormat = "HH:mm";
            ClosingTimeBox.ShowUpDown = true;

        }
    }
}
