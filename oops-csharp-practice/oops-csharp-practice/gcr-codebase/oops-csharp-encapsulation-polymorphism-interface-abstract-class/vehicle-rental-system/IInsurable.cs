using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.vehicle_rental_system
{
    internal interface IInsurable
    {
        double CalculateInsurance(Vehicle vehicle);
        void GetInsuranceDetails(Vehicle vehicle);
    }
}
