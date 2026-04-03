using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.hospital_patient_management
{
    internal class InPatient : Patient
    {
        private int DaysAdmitted;

        public InPatient(string id, string name, int age, int days)
            : base(id, name, age)
        {
            this.DaysAdmitted = days;
        }

        public override double CalculateBill()
        {
            return DaysAdmitted * 3000;
        }
    }
}
