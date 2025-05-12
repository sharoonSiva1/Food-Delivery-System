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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            new CustomerSignUp().Show();
            this.Hide();
        }

        private void RestaurantButton_Click(object sender, EventArgs e)
        {
            new RestaurantSignUp().Show();
            this.Hide();
        }

        private void DeliveryDriverButton_Click(object sender, EventArgs e)
        {
            new DriverSignUp().Show();
            this.Hide();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
