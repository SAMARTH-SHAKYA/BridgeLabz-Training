using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Databse DB = new Databse();
            DB.DataSymptomDisease();
            DB.DataFeeDisease();
            DB.DataMedicationDisease();


            Doctor D1 = new Doctor("Samarth", "AAC009", "Dematologist");
            InPatient P1 = new InPatient("Sambhav", 23, "HG985");
            Reception R = new Reception();


            string[,] toBill = DB.FeeDisease;
            string[,] toDoctorDisease = DB.FeeDisease;
            string[,] toDoctorMedication = DB.MedicationDisease;


            string[] PatientSymptomsToDoctor = P1.GiveSymptoms();
            string diagnosedDisease = D1.DiagnosDisease(PatientSymptomsToDoctor, toDoctorDisease);
            P1.GetDiseaseForUser(diagnosedDisease);


            string[] medicationsToPatient = D1.GiveMedications(diagnosedDisease,toDoctorMedication);
            P1.GetMedicationForUser(medicationsToPatient);

            R.GenerateRoomNumber(P1);
            R.GenerateNumberOfDaysAdmitted(P1);
            R.GenerateBill(P1, D1);
            

        }
    }
}
