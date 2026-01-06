using BridgeLabzTraining.Scenario_oops.HospitalManagement;
using System;
using static BridgeLabzTraining.Scenario_oops.HospitalManagement.DerievedVehicles;

namespace VehicleRentalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleUtility utility = new VehicleUtility();

            // Pre-load data
            utility.AddVehicle(new Car("Toyota", "Camry", 50m));
            utility.AddVehicle(new Bike("Yamaha", "R15", 20m));
            utility.AddVehicle(new Truck("Ford", "F-150", 100m));

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine("   VEHICLE RENTAL SYSTEM");
                Console.WriteLine("==============================");
                Console.WriteLine("1. List All Vehicles");
                Console.WriteLine("2. Rent a Vehicle");
                Console.WriteLine("3. Add New Car");
                Console.WriteLine("4. Add New Bike");
                Console.WriteLine("5. Add New Truck");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        utility.DisplayInventory();
                        break;
                    case "2":
                        utility.RentVehicle();
                        break;
                    case "3":
                        utility.AddVehicle(CreateVehicle("Car"));
                        break;
                    case "4":
                        utility.AddVehicle(CreateVehicle("Bike"));
                        break;
                    case "5":
                        utility.AddVehicle(CreateVehicle("Truck"));
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static Vehicle CreateVehicle(string type)
        {
            Console.Write($"Enter {type} Brand: ");
            string brand = Console.ReadLine();
            Console.Write($"Enter {type} Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Daily Rate: ");
            decimal.TryParse(Console.ReadLine(), out decimal rate);

            switch (type)
            {
                case "Car": return new Car(brand, model, rate);
                case "Bike": return new Bike(brand, model, rate);
                case "Truck": return new Truck(brand, model, rate);
                default: return new Car(brand, model, rate);
            }
        }
    }
}