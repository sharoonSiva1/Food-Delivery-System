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
<<<<<<< HEAD
        int customerId;

        public CustomerUI(int id)
=======
        public CustomerUI(int customerId)
>>>>>>> c5019d217a9aabaad3ea5b91650c94a1de16a8d9
        {
            InitializeComponent();
            customerId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  //hide current window
            Pick_restaurant pick = new Pick_restaurant(customerId);
            pick.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMyOrders ordersForm = new ViewMyOrders(customerId);
            ordersForm.Show();
        }


        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

    }
}
