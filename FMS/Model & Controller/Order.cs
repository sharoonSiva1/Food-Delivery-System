using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Model___Controller
{
    internal class Order
    {
        public int OrderID { get; set; }            // Primary key
        public int CustomerID { get; set; }         // Foreign key
        public string Items { get; set; }           // List of items in string format
        public string Quantity { get; set; }        // Quantity for each item (or combined info)
        public string Status { get; set; }          // Pending / Delivered / Cancelled etc.
        public decimal TotalCost { get; set; }      // Order total
        public string DeliveryAddress { get; set; } // Customer-entered address
        public string PaymentMethod { get; set; }
    }
}
