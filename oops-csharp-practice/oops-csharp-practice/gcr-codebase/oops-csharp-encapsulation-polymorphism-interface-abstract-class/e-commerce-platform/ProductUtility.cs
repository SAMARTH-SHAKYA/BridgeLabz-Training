using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.e_commerce_platform
{
    internal class ProductUtility : ITaxable
    {
        public double CalculateTax(Clothing clothes)
        {
            double tax = clothes.ProductPrice * 0.10;
            return tax;
        }
        public double CalculateTax(Electronics electronics)
        {
            double tax = electronics.ProductPrice * 0.15;
            return tax;
        }

        public double CalculateTax(Groceries groceries)
        {
            double tax = groceries.ProductPrice * 0.11;
            return tax;
        }
        public void GetTaxDetails(Clothing clothes)
        {
            Console.WriteLine($"Tax on clothing item is 10%");
            double tax = clothes.ProductPrice * 0.10;
            Console.WriteLine($"Price of cloth is {clothes.ProductPrice} tax on this cloth is {tax}");
        }

        public void GetTaxDetails(Electronics electronics)
        {
            Console.WriteLine($"Tax on electronics item is 15%");
            double tax = electronics.ProductPrice * 0.10;
            Console.WriteLine($"Price of electronic item is {electronics.ProductPrice} tax on this electonice item is {tax}");
        }

        public void GetTaxDetails(Groceries groceries)
        {
            Console.WriteLine($"Tax on groceries item is 11%");
            double tax = groceries.ProductPrice * 0.10;
            Console.WriteLine($"Price of grocery is {groceries.ProductPrice} tax on this grocery item is {tax}");
        }
    }
}
