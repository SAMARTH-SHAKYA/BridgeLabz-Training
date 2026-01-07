using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.online_food_delivery_system
{
    internal interface IDiscountable
    {
        double ApplyDiscount(FoodItem item);
        void GetDiscountDetails(FoodItem item);
    }
}
