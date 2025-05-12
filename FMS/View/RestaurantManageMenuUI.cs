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
    public partial class RestaurantManageMenuUI : Form
    {
        private int RestaurantId;
        public RestaurantManageMenuUI(int restaurantUserId)
        {
            InitializeComponent();
            RestaurantId = restaurantUserId;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            RestaurantUI restaurantUI = new RestaurantUI(RestaurantId);
            restaurantUI.Show();
            this.Hide();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            RestaurantMenuAddItem addMenuUI = new RestaurantMenuAddItem(RestaurantId);
            addMenuUI.Show();
            this.Hide();
        }

        private void RestaurantManageMenuUI_Load(object sender, EventArgs e)
        {
            Model___Controller.Menu menuItem = new Model___Controller.Menu();
            menuItem.LoadMenuItemsForRestaurant(RestaurantId, menuItemsGrid);
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            if (menuItemsGrid.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(menuItemsGrid.SelectedRows[0].Cells["ItemID"].Value);
                RestaurantMenuEditItems editForm = new RestaurantMenuEditItems(itemId, RestaurantId);
                editForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (menuItemsGrid.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(menuItemsGrid.SelectedRows[0].Cells["ItemID"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Model___Controller.Menu selectedItem = new Model___Controller.Menu();
                        selectedItem.DeleteItem(itemId);
                        selectedItem.LoadMenuItemsForRestaurant(RestaurantId, menuItemsGrid);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
