using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.e_commerce_platform
{
    internal interface ITaxable
    {
        public double CalculateTax(Clothing clothes);
        public double CalculateTax(Electronics electronics);

        public double CalculateTax(Groceries groceries);
        public void GetTaxDetails(Clothing clothes);

        public void GetTaxDetails(Electronics electronics);

        public void GetTaxDetails(Groceries groceries);
    }
}
