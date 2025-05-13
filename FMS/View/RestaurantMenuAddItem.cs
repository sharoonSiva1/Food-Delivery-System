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
    public partial class RestaurantMenuAddItem : Form
    {
        private int RestaurantID;
        public RestaurantMenuAddItem(int restaurantUserId)
        {
            InitializeComponent();
            RestaurantID = restaurantUserId;
        }

        // GO BACK BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            RestaurantManageMenuUI manageMenuUI = new RestaurantManageMenuUI(RestaurantID);
            manageMenuUI.Show();
            this.Hide();
        }

        //CREATE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = ItemNameTextBox.Text.Trim();
            string itemDesc = ItemDescTextBox.Text.Trim();
            string itemPriceText = ItemPriceTextBox.Text.Trim();
            string available = ItemAvailabilityComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemDesc) || string.IsNullOrEmpty(itemPriceText) || string.IsNullOrEmpty(available))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(itemPriceText, out decimal price))
            {
                MessageBox.Show("Please enter a valid numeric price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool availability = true;
            if (available == "Available")
            {
                availability = true;
            } else
            {
                availability = false;
            }

            // Call the AddItem function
            Model___Controller.Menu menu = new Model___Controller.Menu();
            menu.AddItem(RestaurantID, itemName, itemDesc, price, availability);

            RestaurantManageMenuUI manageMenuUI = new RestaurantManageMenuUI(RestaurantID);
            manageMenuUI.Show();
            this.Hide();
        }
    }
}
