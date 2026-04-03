using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.ride_hailing_application
{
    internal class RideMenu
    {
        private IGPS gpsUtility;

        public void Menu()
        {
            gpsUtility = new GPSUtility();

            Vehicle vehicle =
                new Car("CAR101", "Amit");

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Show vehicle details");
                Console.WriteLine("Press 2 : Update location");
                Console.WriteLine("Press 3 : Get current location");
                Console.WriteLine("Press 4 : Calculate fare");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        vehicle.GetVehicleDetails();
                        break;

                    case 2:
                        gpsUtility.UpdateLocation();
                        break;

                    case 3:
                        Console.WriteLine(gpsUtility.GetCurrentLocation());
                        break;

                    case 4:
                        Console.WriteLine(vehicle.CalculateFare(12));
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
