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
    public partial class RestaurantMenuEditItems : Form
    {
        private int ItemID;
        private int RestaurantID;
        public RestaurantMenuEditItems(int itemId, int restID)
        {
            InitializeComponent();
            ItemID = itemId;
            RestaurantID = restID;
            LoadItemDetails();
        }

        private void LoadItemDetails()
        {
            Model___Controller.Menu item = new Model___Controller.Menu();
            DataTable dt = item.GetMenuItemById(ItemID);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                ItemNameTextBox.Text = row["Name"].ToString();
                ItemDescTextBox.Text = row["Description"].ToString();
                ItemPriceTextBox.Text = row["Price"].ToString();

                string availability = row["Availability"].ToString();
                if (availability == "True")
                    ItemAvailabilityComboBox.SelectedIndex = 0;
                else if (availability == "False")
                    ItemAvailabilityComboBox.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Item not found.");
                this.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Getting updated values from form fields
                string updatedName = ItemNameTextBox.Text.Trim();
                string updatedDesc = ItemDescTextBox.Text.Trim();
                string priceText = ItemPriceTextBox.Text.Trim();
                string availabilityText = ItemAvailabilityComboBox.SelectedItem?.ToString();

                // Validate inputs
                if (string.IsNullOrEmpty(updatedName) || string.IsNullOrEmpty(priceText) || availabilityText == null)
                {
                    MessageBox.Show("Please fill all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(priceText, out decimal updatedPrice))
                {
                    MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool availability = true;
                if (availabilityText == "Available")
                {
                    availability = true;
                }
                else
                {
                    availability = false;
                }

                Model___Controller.Menu updateItem = new Model___Controller.Menu();
                updateItem.EditItem(ItemID, updatedName, updatedDesc, updatedPrice, availability);

                this.Close();
                RestaurantManageMenuUI manageForm = new RestaurantManageMenuUI(RestaurantID);
                manageForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new RestaurantManageMenuUI(RestaurantID).Show();
            this.Close();
        }
    }
}
