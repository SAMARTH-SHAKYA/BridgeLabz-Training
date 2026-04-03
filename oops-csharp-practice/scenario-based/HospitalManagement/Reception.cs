using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    internal class Reception
    {
        public Reception() 
        {
            Console.WriteLine("Welcome to reception");  
        }

        public void GenerateRoomNumber(object person)
        {
            if (person is InPatient inpatient) 
            {
                inpatient.RoomNumber = 10;
                Console.WriteLine("Given Room Number 10");
            }
            else
            {
                Console.WriteLine("This person is not an inpatient.");
            }
        }


        public void GenerateNumberOfDaysAdmitted(object person)
        {
            if (person is InPatient inpatient)
            {
                inpatient.DaysAdmitted = 10;
                Console.WriteLine("Number of Days admitted is 10");
            }
            else
            {
                Console.WriteLine("This person is not an inpatient.");
            }
        }
        public void GenerateBill(object person, object doctor)
        {
            // Cast doctor object
            if (!(doctor is Doctor doc))
            {
                Console.WriteLine("Invalid doctor object");
                return;
            }

            // Cast patient object
            if (!(person is Patient patient))
            {
                Console.WriteLine("Invalid patient object");
                return;
            }

            Console.WriteLine("-------- BILL --------");
            Console.WriteLine($"Patient Name: {patient.Name}");
            Console.WriteLine($"Age: {patient.Age}");
            Console.WriteLine($"Disease: {patient.Disease}");

            // Print symptoms
            Console.WriteLine("Symptoms:");
            foreach (var symptom in patient.PatientSymptoms)
            {
                Console.WriteLine($"- {symptom}");
            }

            // Print medications
            if (patient.Medications != null)
            {
                Console.WriteLine("Medications:");
                foreach (var med in patient.Medications)
                {
                    Console.WriteLine($"- {med}");
                }
            }

            // Print room & days if inpatient
            if (patient is InPatient inpatient)
            {
                Console.WriteLine($"Room Number: {inpatient.RoomNumber}");
                Console.WriteLine($"Days Admitted: {inpatient.DaysAdmitted}");
            }

            // Access doctor fees
            Console.WriteLine($"Medical Fee: ₹{doc.MedicalFee}");
            Console.WriteLine($"Doctor Fee: ₹{doc.DoctorFee}");
            double total = doc.MedicalFee + doc.DoctorFee;
            Console.WriteLine($"Total Bill: ₹{total}");

            Console.WriteLine("---------------------");
        }

    }
}
