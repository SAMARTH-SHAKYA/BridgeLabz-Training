using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.hospital_patient_management
{
    internal abstract class Patient
    {
        public string PatientId { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        protected Patient(string patientId, string name, int age)
        {
            this.PatientId = patientId;
            this.Name = name;
            this.Age = age;
        }

        public void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID : {PatientId}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
        }

        public abstract double CalculateBill();
    }
}
