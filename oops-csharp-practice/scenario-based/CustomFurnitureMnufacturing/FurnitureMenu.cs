using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal class FurnitureMenu
    {
        private IFurniture furnitureUtility;

        public void Menu()
        {
            furnitureUtility = new FurnitureUtility();



            bool isTrue = true;

            while (true)
            {
                Console.WriteLine("Press 1 : Maximum profit for 12 ft rod");
                Console.WriteLine("Press 2 : Maximum profit according to fixed waste constraint");
                Console.WriteLine("Press 3 : Maximise revenue and minimal waste");
                Console.WriteLine("Press 4 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        Console.WriteLine($"Maximum profit for 12 ft rod is {furnitureUtility.MaxProfit(12)}");
                        break;
                    case 2:
                        Console.WriteLine("Enter waste");
                        int waste = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Maximum profit for 12 ft rod is {furnitureUtility.MaxProfitWithWaste(12,waste)}");
                        break;
                    case 3:
                        Console.WriteLine("Enter length of rod");
                        int lengthRod = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter waste");
                        int wasteUser = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Maximum profit for 12 ft rod is {furnitureUtility.MaxProfitWithWaste(lengthRod, wasteUser)}");
                        break;
                    case 4:
                        Console.WriteLine("Exit");
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
