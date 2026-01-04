using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops
{
    
        internal class CafeteriaMenu
        {
            //non static array of items
            string[] items =
                                {
                                "Veg Sandwich",
                                "Cheese Burger",
                                "Pasta",
                                "Pizza",
                                "French Fries",
                                "Cold Coffee",
                                "Tea",
                                "Samosa",
                                "Noodles",
                                "Ice Cream"
                            };

            //method to run which will be called by main
            public void Run()
            {
                Console.WriteLine("-------------------- Welcome to Cafeteria Menu --------------------");

                bool isExit = false;
                while (isExit == false)
                {
                    Console.WriteLine("Press 1 : Display Menu");
                    Console.WriteLine("Press 2 : Order Item");
                    Console.WriteLine("Press 3 : Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            DisplayMenu();
                            break;

                        case 2:
                            OrderItem();
                            break;

                        case 3:
                            Console.WriteLine("Exiting Cafeteria Menu...");
                            isExit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
            }

            //method to display menu
            public void DisplayMenu()
            {
                Console.WriteLine("Available Items:");
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine($"{i} : {items[i]}");
                }
            }

            //method to order the items
            public void OrderItem()
            {
                Console.WriteLine("Enter item index to order:");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= items.Length)
                {
                    Console.WriteLine("Invalid item index");
                    return;
                }

                Console.WriteLine($"You ordered : {items[index]}");
            }
        }
    }


