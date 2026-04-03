using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.vehicle_rental_system
{
    internal class InsuranceUtility : IInsurable
    {
        private string PolicyNumber = "INS-45879";

        public double CalculateInsurance(Vehicle vehicle)
        {
            return vehicle.RentalRate * 0.05;
        }

        public void GetInsuranceDetails(Vehicle vehicle)
        {
            Console.WriteLine($"Insurance applied on {vehicle.VehicleType}");
            Console.WriteLine($"Policy Number: {PolicyNumber}");
            Console.WriteLine($"Insurance Amount: {CalculateInsurance(vehicle)}");
        }
    }
}
