using FMS.Model___Controller;
using MySql.Data.MySqlClient;
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
    public partial class RestaurantViewOrder : Form
    {
        private int RestaurantId;
        public RestaurantViewOrder(int restaurantUserId)
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

        private void LoadOrders(int restID)
        {
            OngoingOrdersDataGrid.DataSource = FMS.Model___Controller.OrderController.GetOrdersByRestaurant(restID);
            OngoingOrdersDataGrid.Columns["CustomerID"].Visible = false;
            OngoingOrdersDataGrid.Columns["ID"].Visible = false;
        }

        private void RestaurantViewOrder_Load(object sender, EventArgs e)
        {
            LoadOrders(RestaurantId);
        }
    }
}
