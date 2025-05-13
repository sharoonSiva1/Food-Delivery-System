using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FMS.Model___Controller;

namespace FMS.View
{
    public partial class DriverUI : Form
    {
        int driverId;

        public DriverUI(int id)
        {
            InitializeComponent();
            driverId = id;
            LoadAssignedOrder();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewDriverOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void LoadAssignedOrder()
        {
            string query = $"SELECT ID, CustomerID, Items, TotalCost, Status FROM orders WHERE DriverID = {driverId}";
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                db.CloseConnection();
            }

            dataGridViewDriverOrders.DataSource = table;
            dataGridViewDriverOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MarkDeliveredBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewDriverOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridViewDriverOrders.SelectedRows[0].Cells["ID"].Value);

                string updateOrder = $"UPDATE orders SET Status = 'Delivered' WHERE ID = {orderId}";
                string updateDriver = $"UPDATE drivers SET Availability = 1 WHERE ID = {driverId}";

                DBConnection db = new DBConnection();
                db.ExecuteQuery(updateOrder);
                db.ExecuteQuery(updateDriver);

                MessageBox.Show("Order marked as delivered.");
                LoadAssignedOrder(); // Refresh the grid
            }
            else
            {
                MessageBox.Show("Please select an order first.");
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
