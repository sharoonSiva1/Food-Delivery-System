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
    public partial class CardPayment : Form
    {
        int orderId;
        public CardPayment(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }


        private void CardPayment_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void CardNumbertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpireDatetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardHoldertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cvvtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPaymentBtn_Click(object sender, EventArgs e)
        {
            string cardNumber = CardNumbertxtbox.Text.Trim();
            string expiry = ExpireDatetxtbox.Text.Trim();
            string holder = CardHoldertxtbox.Text.Trim();
            string cvv = Cvvtxtbox.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(expiry) ||
                string.IsNullOrEmpty(holder) || string.IsNullOrEmpty(cvv))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (cardNumber.Length < 12 || cvv.Length != 3)
            {
                MessageBox.Show("Invalid card details.");
                return;
            }

            // Update payment method
            FMS.Model___Controller.OrderController.UpdatePaymentMethod(orderId, "Card");

            MessageBox.Show("Payment successful!");

            this.Hide();
            PickaDriver driverForm = new PickaDriver(orderId);
            driverForm.Show();
        }

=======
>>>>>>> c5019d217a9aabaad3ea5b91650c94a1de16a8d9
    }
}
