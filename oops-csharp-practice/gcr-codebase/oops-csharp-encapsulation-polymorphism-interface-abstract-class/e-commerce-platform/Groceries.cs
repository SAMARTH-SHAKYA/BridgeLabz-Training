using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.e_commerce_platform
{
    internal class Groceries : Product
    {
        public double Discount { get; private set; }

        public string ProductType { get; private set; }

        public Groceries(string productId, string productName, double productPrice) : base(productId, productName, productPrice)
        {
            this.ProductType = "Groceries";
        }


        public override double CalculateDiscount()
        {
            double discount = ProductPrice * 0.30;
            this.Discount = discount;
            return discount;
        }
    }
}
