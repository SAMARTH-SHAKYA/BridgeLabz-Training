using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.e_commerce_platform
{
    //creating an abstract class 
    internal abstract class Product
    {
        //setting fields
        public string ProductID { get; private set; }
        public string ProductName { get; private set; }

        public double ProductPrice { get; private set; }

        //creating constructor
        public Product(string productID, string productName, double productPrice)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }

        //abstract method
        public abstract double CalculateDiscount();
    }
}
