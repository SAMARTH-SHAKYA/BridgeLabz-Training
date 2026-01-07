using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.online_food_delivery_system
{
    internal abstract class FoodItem
    {
        public string ItemName { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        protected FoodItem(string itemName, double price, int quantity)
        {
            this.ItemName = itemName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void GetItemDetails()
        {
            Console.WriteLine($"Item : {ItemName}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Quantity : {Quantity}");
        }

        public abstract double CalculateTotalPrice();
    }
}
