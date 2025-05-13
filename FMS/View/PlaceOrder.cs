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
            CartGrid.AllowUserToAddRows = false;
        }

        private void LoadMenuItems()
        {
            string query = $"SELECT ItemID, Name, Price FROM menuitems WHERE RestaurantID = {restaurantId} AND Availability = 1";
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                db.CloseConnection();
            }

            AvailableFoodItemGrid.DataSource = table;

            AvailableFoodItemGrid.Columns["ItemID"].HeaderText = "Item ID";
            AvailableFoodItemGrid.Columns["Name"].HeaderText = "Item Name";
            AvailableFoodItemGrid.Columns["Price"].HeaderText = "Price (Rs.)";
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (AvailableFoodItemGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to add.");
                return;
            }

            DataGridViewRow selectedRow = AvailableFoodItemGrid.SelectedRows[0]; // e.g. "1 - Burger - Rs.500"
            
            int itemId = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);
            string itemName = selectedRow.Cells["Name"].Value.ToString();
            decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

            DataTable table;
            if (CartGrid.DataSource == null)
            {
                table = new DataTable();
                table.Columns.Add("ItemID", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Price", typeof(decimal));
                table.Columns.Add("Quantity", typeof(int));
            }
            else
            {
                table = (DataTable)CartGrid.DataSource;
            }

            DataRow row = table.NewRow();
            row["ItemID"] = itemId;
            row["Name"] = itemName;
            row["Price"] = price;
            row["Quantity"] = 1;

            table.Rows.Add(row);
            CartGrid.DataSource = table;
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (CartGrid.SelectedRows.Count > 0)
            {
                CartGrid.Rows.RemoveAt(CartGrid.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void UpdateGridBtn_Click(object sender, EventArgs e) // Go Back Btn
        {
            new CustomerUI(customerId).Show();
            this.Hide();
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            if (CartGrid.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            string items = "";
            decimal totalCost = 0;

            foreach (DataGridViewRow row in CartGrid.Rows)
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

            int driverId = new Driver().AssignDriver();

            if (driverId == -1) // returns early in case of no available drivers
            {
                MessageBox.Show("There are no Driver available. Please try again later.");
                return;
            }

            FMS.Model___Controller.Order order = new FMS.Model___Controller.Order
            {
                CustomerID = customerId,
                Items = items,
                TotalCost = totalCost,
                DeliveryAddress = "Default address",
                DriverID = driverId,
                RestID = restaurantId,
            };

            FMS.Model___Controller.OrderController.PlaceOrder(order);

            MessageBox.Show("Order placed!");
            this.Hide();
            new CustomerUI(customerId).Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }
    }
}
