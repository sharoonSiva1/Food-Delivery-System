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
    public partial class RestaurantUI : Form
    {
        private int restaurantUserId;
        public RestaurantUI(int userID)
        {
            InitializeComponent();
            restaurantUserId = userID;

        }

        private void ManageProfileButton_Click(object sender, EventArgs e)
        {       
            RestaurantManageProfileUI restaurantManageProfileUI = new RestaurantManageProfileUI(restaurantUserId);
            restaurantManageProfileUI.Show();
            this.Hide();
        }

        private void ManageMenuButton_Click(object sender, EventArgs e)
        {
            RestaurantManageMenuUI restaurantManageMenuUI = new RestaurantManageMenuUI(restaurantUserId);
            restaurantManageMenuUI.Show();
            this.Hide();
        }

        private void OngoingOrdersButton_Click(object sender, EventArgs e)
        {
            RestaurantViewOrder restaurantViewOrder = new RestaurantViewOrder(restaurantUserId);
            restaurantViewOrder.Show();
            this.Hide();
        }
    }
}
