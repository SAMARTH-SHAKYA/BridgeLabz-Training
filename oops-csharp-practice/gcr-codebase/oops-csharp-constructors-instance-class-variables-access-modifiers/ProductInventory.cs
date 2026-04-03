using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class ProductInventory
    {
        //instance variables
        public string productName;
        public double price;

        //class variable
        public static int totalProducts = 0;

        //calling constructor
        public ProductInventory(string name, double price)
        {
            this.productName = name;
            this.price = price;
            totalProducts++;
        }

        //method to display product
        public void DisplayProduct()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Price: {price}");
        }

        // method to display total products
        public static void DisplayTotal()
        {
            Console.WriteLine($"Total Products Created: {totalProducts}");
        }
    }
}
