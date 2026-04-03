using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.ride_hailing_application
{
    internal class Auto : Vehicle
    {
        public Auto(string id, string driver)
            : base(id, driver, 10)
        {
        }

        public override double CalculateFare(double distance)
        {
            return (distance * RatePerKm) + 20;
        }
    }
}
