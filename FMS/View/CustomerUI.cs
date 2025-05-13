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
    public partial class CustomerUI : Form
    {
        int customerId;

        public CustomerUI(int id)
        {
            InitializeComponent();
            customerId = id;
        }

        //PLACE ORDER BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pick_restaurant pick = new Pick_restaurant(customerId);
            pick.Show();
        }

        //VIEW MY ORDERS BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMyOrders ordersForm = new ViewMyOrders(customerId);
            ordersForm.Show();
        }

        //LOGOUT BUTTON
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

    }
}
