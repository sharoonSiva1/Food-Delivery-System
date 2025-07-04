﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FMS.Model___Controller;
using MySql.Data.MySqlClient;

namespace FMS.View
{
    public partial class PickaDriver : Form
    {
        int orderId;
        List<(int Id, string Name)> drivers = new List<(int, string)>();

        public PickaDriver(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadDrivers();
        }

        private void LoadDrivers()
        {
            string query = "SELECT ID, Name FROM drivers WHERE available = 1"; // Only available drivers
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                db.CloseConnection();
            }

            AvailableDriversLstbox.Items.Clear();
            drivers.Clear();

            foreach (DataRow row in table.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string name = row["Name"].ToString();
                drivers.Add((id, name));
                AvailableDriversLstbox.Items.Add(name);
            }
        }

        private void AssignDriverBtn_Click(object sender, EventArgs e)
        {
            if (AvailableDriversLstbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a driver first.");
                return;
            }

            int driverId = drivers[AvailableDriversLstbox.SelectedIndex].Id;

            // 1. Assign driver to the order
            string orderQuery = $"UPDATE orders SET DriverID = {driverId}, Status = 'Assigned' WHERE ID = {orderId}";

            // 2. Mark the driver as unavailable
            string driverQuery = $"UPDATE drivers SET available = 0 WHERE ID = {driverId}";

            DBConnection db = new DBConnection();
            db.ExecuteQuery(orderQuery);
            db.ExecuteQuery(driverQuery);

            MessageBox.Show("Driver successfully assigned.");
            this.Close();
        }
    }
}