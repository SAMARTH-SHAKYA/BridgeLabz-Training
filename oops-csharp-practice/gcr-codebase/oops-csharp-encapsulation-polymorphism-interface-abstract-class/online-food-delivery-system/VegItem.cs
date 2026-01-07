using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.online_food_delivery_system
{
    internal class VegItem : FoodItem
    {
        public VegItem(string name, double price, int qty)
            : base(name, price, qty)
        {
        }

        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }
    }
}
