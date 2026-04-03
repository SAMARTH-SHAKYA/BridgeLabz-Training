using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.hospital_patient_management
{
    internal class HospitalMenu
    {
        private IMedicalRecord medicalUtility;

        public void Menu()
        {
            medicalUtility = new MedicalRecordUtility();

            Patient patient =
                new InPatient("P101", "Rahul", 45, 4);

            object record = null;
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Show patient details");
                Console.WriteLine("Press 2 : Add medical record");
                Console.WriteLine("Press 3 : View medical record");
                Console.WriteLine("Press 4 : Delete medical record");
                Console.WriteLine("Press 5 : Calculate bill");
                Console.WriteLine("Press 6 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        patient.GetPatientDetails();
                        break;

                    case 2:
                        record = medicalUtility.AddRecord();
                        break;

                    case 3:
                        medicalUtility.ViewRecords();
                        break;

                    case 4:
                        medicalUtility.DeleteRecord();
                        record = null;
                        break;

                    case 5:
                        Console.WriteLine(patient.CalculateBill());
                        break;

                    case 6:
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
