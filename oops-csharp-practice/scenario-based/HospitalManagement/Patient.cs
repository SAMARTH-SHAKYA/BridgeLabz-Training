using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    internal class Patient
    {
        public string Name;
        public int Age;
        public string HealthCardNumber {  get; private set; }
        public string[] PatientSymptoms = new string[5];

        public string Disease { get; set; }

        public string[] Medications { get; set; }
        public Patient(string name, int age, string healthCardNumber)
        {
            this.Name = name;
            this.Age = age;
            this.HealthCardNumber = healthCardNumber;
        }

        
        public string[] GiveSymptoms()
        {
            Console.WriteLine("Enter your symptoms");

            for (int i = 0; i < PatientSymptoms.Length; i++) 
            {
                PatientSymptoms[i] = Console.ReadLine();
            }

            return PatientSymptoms;
        }

        public void GetDiseaseForUser(string disease)
        {
            this.Disease = disease;
        }

        public void GetMedicationForUser(string[] medications)
        {
            this.Medications= medications;
        }
    }
}
