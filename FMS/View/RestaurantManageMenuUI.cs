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
    }
}
