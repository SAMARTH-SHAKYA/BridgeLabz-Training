using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    //main class order
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        //method to get order status
        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }

    //sub class of order
    class ShippedOrder : Order
    {
        public string TrackingNumber { get; set; }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }
    }

    //multi level inhertincae DeliveredOrder sub class of Shipped order
    class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate { get; set; }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }
    }

}
