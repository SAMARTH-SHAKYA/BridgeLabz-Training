using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    
        public class VehicleUtility : IVehicleUtility
        {
            private List<Vehicle> fleet = new List<Vehicle>();

            public void AddVehicle(Vehicle vehicle)
            {
                fleet.Add(vehicle);
                Console.WriteLine($"[Success] Added {vehicle.Brand} {vehicle.Model} to fleet.");
            }

            public void DisplayInventory()
            {
                Console.WriteLine("\n--- Current Inventory ---");
                if (fleet.Count == 0)
                {
                    Console.WriteLine("No vehicles available.");
                    return;
                }

                int index = 1;
                foreach (var v in fleet)
                {
                    Console.WriteLine($"{index}. {v.ToString()}");
                    index++;
                }
            }

            public void RentVehicle()
            {
                DisplayInventory();
                if (fleet.Count == 0) return;

                Console.Write("\nEnter the ID number of the vehicle to rent: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= fleet.Count)
                {
                    var selectedVehicle = fleet[choice - 1];

                    Console.Write("Enter Customer Name: ");
                    string name = Console.ReadLine();
                    Customer customer = new Customer(name, "N/A");

                    Console.Write("Enter number of days to rent: ");
                    if (int.TryParse(Console.ReadLine(), out int days))
                    {
                        decimal totalCost = selectedVehicle.CalculateRent(days);

                        Console.WriteLine("\n--- Rental Invoice ---");
                        Console.WriteLine($"Customer: {customer.Name}");
                        Console.WriteLine($"Vehicle: {selectedVehicle.Brand} {selectedVehicle.Model}");
                        Console.WriteLine($"Duration: {days} days");
                        Console.WriteLine($"Total Cost: {totalCost:C}");
                        Console.WriteLine("----------------------");
                    }
                    else
                    {
                        Console.WriteLine("Invalid days entered.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid vehicle selection.");
                }

            }
        }
    }

