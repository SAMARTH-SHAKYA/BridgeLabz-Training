using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sealed
{
    using System;

    class Product
    {

        //global static variable
        public static double Discount = 10;

        //global non static variables and using getter and setter
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        //calling the constructor
        public Product(int productId, string name, double price, int quantity)
        {
            this.ProductID = productId;
            this.ProductName = name;
            this.Price = price;
            this.Quantity = quantity;
        }


        //method to update the discount
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        //method to check the instance of the current 
        public void Display(object obj)
        {
            if (obj is Product)
            {
                Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Qty: {Quantity}, Discount: {Discount}%");
            }
        }
    }

}
