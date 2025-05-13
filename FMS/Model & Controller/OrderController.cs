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
            string query = $"INSERT INTO orders (CustomerID, Items, Status, TotalCost, DeliveryAddress, PaymentMethod) " +
                           $"VALUES ({order.CustomerID}, '{order.Items}', 'Pending', {order.TotalCost}, '{order.DeliveryAddress}', '')";

            DBConnection db = new DBConnection();
            db.ExecuteQuery(query); 
        }

        public static void UpdatePaymentMethod(int orderId, string method)
        {
            string query = $"UPDATE orders SET PaymentMethod = '{method}' WHERE ID = {orderId}";
            DBConnection db = new DBConnection();
            db.ExecuteQuery(query);
        }

        public static void CancelOrder(int orderId)
        {
            string query = $"UPDATE orders SET Status = 'Cancelled' WHERE ID = {orderId}";
            DBConnection db = new DBConnection();
            db.ExecuteQuery(query);
        }

        public static DataTable GetOrdersByCustomer(int customerId)
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

        public static void UpdateOrderItems(int orderId, string updatedItems, string quantity, decimal totalCost)
        {
            string query = $"UPDATE orders SET Items = '{updatedItems}', Quantity = '{quantity}', TotalCost = {totalCost} WHERE ID = {orderId}";
            DBConnection db = new DBConnection();
            db.ExecuteQuery(query);
        }

    }
}
