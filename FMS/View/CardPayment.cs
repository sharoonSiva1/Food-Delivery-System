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
    }
}
