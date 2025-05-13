using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FMS.Model___Controller;
using Mysqlx.Crud;

namespace FMS.View
{
    public partial class PlaceOrder : Form
    {
        int customerId;
        int restaurantId;
        int orderId;

        public PlaceOrder(int customerId, int restaurantId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.restaurantId = restaurantId;
            LoadMenuItems();

            // Prevents the DataGridView from showing empty row
            dataGridView1.AllowUserToAddRows = false;
        }

        private void LoadMenuItems()
        {
            string query = $"SELECT ItemID, Name, Price FROM menuitems WHERE RestaurantID = {restaurantId}";
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                db.CloseConnection();
            }

            listBox1.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                string itemDisplay = $"{row["ItemID"]} - {row["Name"]} - Rs.{row["Price"]}";
                listBox1.Items.Add(itemDisplay);
            }
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to add.");
                return;
            }

            string selectedItem = listBox1.SelectedItem.ToString(); // e.g. "1 - Burger - Rs.500"
            string[] parts = selectedItem.Split('-');
            if (parts.Length < 3) return;

            int itemId = int.Parse(parts[0].Trim());
            string itemName = parts[1].Trim();
            decimal price = decimal.Parse(parts[2].Replace("Rs.", "").Trim());

            DataTable table;
            if (dataGridView1.DataSource == null)
            {
                table = new DataTable();
                table.Columns.Add("ItemID", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Price", typeof(decimal));
                table.Columns.Add("Quantity", typeof(int));
            }
            else
            {
                table = (DataTable)dataGridView1.DataSource;
            }

            DataRow row = table.NewRow();
            row["ItemID"] = itemId;
            row["Name"] = itemName;
            row["Price"] = price;
            row["Quantity"] = 1;

            table.Rows.Add(row);
            dataGridView1.DataSource = table;
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void UpdateGridBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            MessageBox.Show("Grid updated. Remember to click 'Place Order' to save.");
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            string items = "";
            decimal totalCost = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["Name"].Value?.ToString();
                if (!int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int qty) || qty <= 0)
                {
                    MessageBox.Show("Invalid quantity in cart.");
                    return;
                }

                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                items += $"{qty}x {name}, ";
                totalCost += price * qty;
            }

            items = items.TrimEnd(',', ' ');

            FMS.Model___Controller.Order order = new FMS.Model___Controller.Order
            {
                CustomerID = customerId,
                Items = items,
                TotalCost = totalCost,
                DeliveryAddress = "Default address",
                PaymentMethod = ""
            };

            FMS.Model___Controller.OrderController.PlaceOrder(order);

            MessageBox.Show("Order placed! Proceeding to payment...");
            this.Hide();
            ChoosePayment payment = new ChoosePayment(orderId);
            payment.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
