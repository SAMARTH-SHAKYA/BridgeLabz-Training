using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.e_commerce_platform
{
    
    internal class EcommerceMenu
    {
        private ITaxable taxableUtility;

        public void Menu()
        {
            taxableUtility = new ProductUtility();

            Electronics Laptop = new Electronics("CS001", "DEll x 700", 50000);

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : To Display tax");
                Console.WriteLine("Press 2 : To Display tax details");
                Console.WriteLine("Press 3 : To show discount");
                Console.WriteLine("Press 4 : To show final price");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        double tax = taxableUtility.CalculateTax(Laptop);
                        Console.WriteLine($"{tax}");
                        break;
                    case 2:
                        taxableUtility.GetTaxDetails(Laptop);
                        break;
                    case 3:
                        double discount =  Laptop.CalculateDiscount();
                        Console.WriteLine(discount);
                        break;
                    case 4:
                        double finalPrice = Laptop.ProductPrice - taxableUtility.CalculateTax(Laptop) + Laptop.CalculateDiscount();
                        Console.WriteLine(finalPrice);
                        break;
                    case 5:
                        isTrue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
        }
    }
}
