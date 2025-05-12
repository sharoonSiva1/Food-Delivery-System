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
        public RestaurantUI()
        {
            InitializeComponent();
        }

        private void ManageProfileButton_Click(object sender, EventArgs e)
        {            
            RestaurantManageProfileUI restaurantManageProfileUI = new RestaurantManageProfileUI();
            restaurantManageProfileUI.Show();
            this.Hide();
        }

        private void ManageMenuButton_Click(object sender, EventArgs e)
        {
            RestaurantManageMenuUI restaurantManageMenuUI = new RestaurantManageMenuUI();
            restaurantManageMenuUI.Show();
            this.Hide();
        }
    }
}
