using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.ride_hailing_application
{
    internal class GPSUtility : IGPS
    {
        private object location;

        public object GetCurrentLocation()
        {
            return location;
        }

        public object UpdateLocation()
        {
            Console.WriteLine("Enter current latitude:");
            string lat = Console.ReadLine();

            Console.WriteLine("Enter current longitude:");
            string lng = Console.ReadLine();

            location = new
            {
                Latitude = lat,
                Longitude = lng
            };

            Console.WriteLine("Location updated");
            return location;
        }
    }
}
