using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.hospital_patient_management
{
    internal class MedicalRecordUtility : IMedicalRecord
    {
        private object medicalRecord;

        public object AddRecord()
        {
            Console.WriteLine("Enter Diagnosis:");
            string diagnosis = Console.ReadLine();

            Console.WriteLine("Enter Medical History:");
            string history = Console.ReadLine();

            medicalRecord = new
            {
                Diagnosis = diagnosis,
                History = history
            };

            Console.WriteLine("Medical record added");
            return medicalRecord;
        }

        public void ViewRecords()
        {
            if (medicalRecord != null)
            {
                Console.WriteLine(medicalRecord);
            }
            else
            {
                Console.WriteLine("No medical record found");
            }
        }

        public void DeleteRecord()
        {
            medicalRecord = null;
            Console.WriteLine("Medical record deleted");
        }
    }
}
