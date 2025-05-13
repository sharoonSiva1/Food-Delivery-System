using FMS.Model___Controller;
using Mysqlx.Crud;
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
    public partial class ChoosePayment : Form
    {
        int orderId;
        public ChoosePayment(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }


        private void CashOnDeliveryBtn_Click(object sender, EventArgs e)
        {
            // You need to pass the order ID to this form to update it here
            OrderController.UpdatePaymentMethod(orderId, "Cash on Delivery");
            this.Hide();
            PickaDriver driverForm = new PickaDriver(orderId); // assumes you pass orderId
            driverForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CardPaymentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardPayment cardForm = new CardPayment(orderId); // again, pass orderId
            cardForm.Show();
        }

    }
}
