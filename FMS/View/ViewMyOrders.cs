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
    public partial class ViewMyOrders : Form
    {
        int customerId;

        public ViewMyOrders(int id)
        {
            InitializeComponent();
            customerId = id;
        }

        private void LoadOrders()
        {
            DataGridViewMyOrders.DataSource = FMS.Model___Controller.OrderController.GetOrdersByCustomers(customerId);
            DataGridViewMyOrders.Columns["CustomerID"].Visible = false;
            DataGridViewMyOrders.Columns["ID"].Visible = false;
        }


        private void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            if (DataGridViewMyOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(DataGridViewMyOrders.SelectedRows[0].Cells["ID"].Value);
                string updatedItems = DataGridViewMyOrders.SelectedRows[0].Cells["Items"].Value.ToString();
                string updatedQty = DataGridViewMyOrders.SelectedRows[0].Cells["Quantity"].Value.ToString();
                decimal updatedCost = Convert.ToDecimal(DataGridViewMyOrders.SelectedRows[0].Cells["TotalCost"].Value);

                FMS.Model___Controller.OrderController.UpdateOrderItems(orderId, updatedItems, updatedQty, updatedCost);
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }


        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (DataGridViewMyOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(DataGridViewMyOrders.SelectedRows[0].Cells["ID"].Value);
                FMS.Model___Controller.OrderController.CancelOrder(orderId);
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select an order to cancel.");
            }
        }

        private void DataGridViewMyOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerUI back = new CustomerUI(customerId);
            back.Show();
        }

        private void ViewMyOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
