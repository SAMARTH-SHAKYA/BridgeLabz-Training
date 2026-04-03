using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.vehicle_rental_system
{
    internal class Car : Vehicle
    {
        public Car(string vehicleNumber, double rentalRate) : base(vehicleNumber, rentalRate)
        {
            this.VehicleType = "Car";
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }
    }
}
