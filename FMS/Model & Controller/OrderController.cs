using FMS.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Model___Controller
{
    internal class OrderController
    {
        public static void PlaceOrder(Order order)
        {
            string query = $"INSERT INTO orders (CustomerID, Items, Status, TotalCost, DeliveryAddress, DriverID, RestaurantID) " +
                           $"VALUES ({order.CustomerID}, '{order.Items}', 'Pending', {order.TotalCost}, '{order.DeliveryAddress}', '{order.DriverID}', '{order.RestID}')";

            DBConnection db = new DBConnection();
            db.ExecuteQuery(query); 
        }

        public static void CancelOrder(int orderId, int driverId)
        {
            string query = $"DELETE FROM orders WHERE ID = {orderId}";
            string updateDriver = $"UPDATE drivers SET Availability = 1 WHERE ID = {driverId}";
            DBConnection db = new DBConnection();
            db.ExecuteQuery(query);
            db.ExecuteQuery(updateDriver);
        }

        public static DataTable GetOrdersByCustomers(int customerId)
        {
            string query = $"SELECT * FROM orders WHERE CustomerID = {customerId}";
            DBConnection db = new DBConnection();

            DataTable table = new DataTable();

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                db.CloseConnection();
            }

            return table;
        }

        public static DataTable GetOrdersByRestaurant(int restaurantId) 
        {
            string query = $"SELECT * FROM orders WHERE RestaurantID = {restaurantId}";
            DBConnection db = new DBConnection();

            DataTable table = new DataTable();

            if (db.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                db.CloseConnection();
            }

            return table;
        }

        //public static void UpdateOrderItems(int orderId, string updatedItems, decimal totalCost)
        //{
        //    string query = $"UPDATE orders SET Items = '{updatedItems}', TotalCost = {totalCost} WHERE ID = {orderId}";
        //    DBConnection db = new DBConnection();
        //    db.ExecuteQuery(query);
        //}
    }
}
