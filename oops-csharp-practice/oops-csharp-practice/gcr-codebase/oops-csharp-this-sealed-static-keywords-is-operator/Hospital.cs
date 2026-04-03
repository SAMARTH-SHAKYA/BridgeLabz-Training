using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sealed
{
    using System;

    class Patient
    {
        //static global variables
        public static string HospitalName = "City Hospital";
        private static int totalPatients = 0;


        //non static global variables
        public int PatientID { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Ailment { get; set; }

        //calling the construtor
        public Patient(int id, string name, int age, string ailment)
        {
            this.PatientID = id;
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            totalPatients++;
        }

        //method to get total patients
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients: " + totalPatients);
        }

        //method to check the instance of the current obejct
        public void Display(object obj)
        {
            if (obj is Patient)
            {
                Console.WriteLine($"ID: {PatientID}, Name: {Name}, Age: {Age}, Ailment: {Ailment}");
            }
        }
    }

}
