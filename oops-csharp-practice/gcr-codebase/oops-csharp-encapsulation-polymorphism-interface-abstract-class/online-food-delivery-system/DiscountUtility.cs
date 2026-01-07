using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.online_food_delivery_system
{
    internal class DiscountUtility : IDiscountable
    {
        private double DiscountRate = 0.10;

        public double ApplyDiscount(FoodItem item)
        {
            return item.CalculateTotalPrice() * DiscountRate;
        }

        public void GetDiscountDetails(FoodItem item)
        {
            Console.WriteLine($"Discount Rate : 10%");
            Console.WriteLine($"Discount Amount : {ApplyDiscount(item)}");
        }
    }
}
