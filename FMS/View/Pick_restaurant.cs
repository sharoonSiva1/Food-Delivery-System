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
            customerId = id; // store it for later use
        }
        int selectedRestaurantId;
        private void LoadRestaurants()
        {
            FMS.Model___Controller.Restaurant controller = new FMS.Model___Controller.Restaurant();
            List<FMS.Model___Controller.Restaurant> restaurants = controller.GetAllRestaurants();

            AvailableRestaurantsBtn.Items.Clear();
            foreach (var res in restaurants)
            {
                AvailableRestaurantsBtn.Items.Add(res.RestaurantName);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedRestaurantId == 0)
            {
                MessageBox.Show("Please select a restaurant first.");
                return;
            }

            PlaceOrder orderForm = new PlaceOrder(customerId, selectedRestaurantId);
            this.Hide();
            orderForm.Show();
        }


        private void AvailableRestaurantsBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = AvailableRestaurantsBtn.SelectedItem.ToString();
            FMS.Model___Controller.Restaurant controller = new FMS.Model___Controller.Restaurant();
            List<FMS.Model___Controller.Restaurant> restaurants = controller.GetAllRestaurants();

            var selected = restaurants.FirstOrDefault(r => r.RestaurantName == selectedName);
            if (selected != null)
            {
                selectedRestaurantId = selected.RestaurantID;
            }
        }

        private void Pick_restaurant_Load(object sender, EventArgs e)
        {
            LoadRestaurants();
        }

    }
}
