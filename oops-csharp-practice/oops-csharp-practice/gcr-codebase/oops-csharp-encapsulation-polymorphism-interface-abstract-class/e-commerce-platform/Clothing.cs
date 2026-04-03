using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.e_commerce_platform
{
    //child class of prodcut
    internal class Clothing : Product
    {
        //setting clothing fields
        public double Discount { get; private set; }

        public string ProductType { get; private set; }

        //constructor of clothing
        public Clothing(string productId, string productName, double productPrice) : base(productId, productName, productPrice)
        {
            this.ProductType = "Clothing";
        }


        // overriding the abstract method of product
        public override double CalculateDiscount()
        {
            double discount = ProductPrice * 0.20;
            this.Discount = discount;
            return discount;
        }
    }
}
