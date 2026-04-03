using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.ride_hailing_application
{
    internal class Car : Vehicle
    {
        public Car(string id, string driver)
            : base(id, driver, 15)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }
    }
}
