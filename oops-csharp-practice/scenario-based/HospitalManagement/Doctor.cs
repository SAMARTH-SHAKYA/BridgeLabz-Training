using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    internal class Doctor
    {
        public string DoctorName;
        public string DoctorId {  get; private set; }

        public string Specialization;

        public int MedicalFee { get; private set; }
        public int DoctorFee { get; private set;  }

        public Doctor(string name, string id, string specialization)
        {
            this.DoctorName = name;
            this.DoctorId = id; 
            this.Specialization = specialization;

            MedicalFee = 300;
            DoctorFee = 500;
        }


        public string DiagnosDisease(string[] symptoms, string[,] symWithDisease)
        {
            int rows = symWithDisease.GetLength(0);
            int cols = symWithDisease.GetLength(1);
            if (cols < 2) return "No disease data";

            int diseaseCol = cols - 1;
            int symptomCols = Math.Min(5, cols - 1);

            string matchedDisease = "No disease found";
            int maxMatchCount = 0;

            for (int i = 0; i < rows; i++)
            {
                int matchCount = 0;
                for (int j = 0; j < symptomCols; j++)
                {
                    for (int k = 0; k < symptoms.Length; k++)
                    {
                        var cell = symWithDisease[i, j];
                        if (string.IsNullOrWhiteSpace(cell)) 
                        { 
                            continue; 
                        }
                        if (cell.Equals(symptoms[k], StringComparison.OrdinalIgnoreCase))
                        {
                            matchCount++;
                            break;
                        }
                    }
                }

                if (matchCount > maxMatchCount)
                {
                    maxMatchCount = matchCount;
                    matchedDisease = symWithDisease[i, diseaseCol];
                }
            }

            return matchedDisease;
        }

        public string[] GiveMedications(string disease, string[,] MedicationsFromDb)
        {

            int idx = 0;
            int found = 1;
            for(int i = 0; i < MedicationsFromDb.GetLength(0);i++)
            {
                if(disease == MedicationsFromDb[i, 0])
                {
                    int count = i;
                    idx = count;
                    break;
                }
                found = 0;
            }
            if(found > 0)
            {
                Console.WriteLine("Not found");
                return new string[0];
            }

            string[] medicationsToPatient = new string[5];
            for(int i = 0; i < 5; i++)
            {
                medicationsToPatient[i] = MedicationsFromDb[idx, i + 1];
            }

            return medicationsToPatient;
        }

    }
}
