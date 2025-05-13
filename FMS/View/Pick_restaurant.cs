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
    public partial class Pick_restaurant : Form
    {
        int customerId;

        public Pick_restaurant(int id)
        {
            InitializeComponent();
            customerId = id;
        }
        int selectedRestaurantId;
        private void LoadRestaurants()
        {
            FMS.Model___Controller.Restaurant restaurantModel = new FMS.Model___Controller.Restaurant();
            List<FMS.Model___Controller.Restaurant> restaurants = restaurantModel.GetAllRestaurants();

            if (restaurants != null && restaurants.Count > 0)
            {
                AvailableRestaurantsBtn.DataSource = restaurants;

                AvailableRestaurantsBtn.Columns["userName"].Visible = false;
                AvailableRestaurantsBtn.Columns["password"].Visible = false;
                AvailableRestaurantsBtn.Columns["userType"].Visible = false;
                AvailableRestaurantsBtn.Columns["RestaurantID"].Visible = false;
                AvailableRestaurantsBtn.Columns["UserID"].Visible = false;

            }
            else
            {
                AvailableRestaurantsBtn.DataSource = null;
                MessageBox.Show("No restaurants found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            selectedRestaurantId = Convert.ToInt32(AvailableRestaurantsBtn.Rows[0].Cells["RestaurantID"].Value);
            if (selectedRestaurantId == 0)
            {
                MessageBox.Show("Please select a restaurant first.");
                return;
            }

            PlaceOrder orderForm = new PlaceOrder(customerId, selectedRestaurantId);
            this.Hide();
            orderForm.Show();
        }

        private void Pick_restaurant_Load_1(object sender, EventArgs e)
        {
            LoadRestaurants();
        }
    }
}
