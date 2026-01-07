using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.hospital_patient_management
{
    internal class OutPatient : Patient
    {
        public OutPatient(string id, string name, int age)
            : base(id, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 500;
        }
    }
}
