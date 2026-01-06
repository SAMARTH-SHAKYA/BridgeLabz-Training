using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    internal class Databse
    {
        public string[,] FeeDisease {  get; private set; }
        public void DataFeeDisease()
        {
            FeeDisease = new string[,]
            {
                { "Diabetes", "500" },
                { "Tuberculosis", "700" },
                { "Malaria", "400" },
                { "Dengue", "600" },
                { "Hypertension", "450" },
                { "Asthma", "350" },
                { "Typhoid", "550" },
                { "Pneumonia", "800" },
                { "Migraine", "300" },
                { "Arthritis", "650" }
            };
        }


        public string[,] SymptomDisease { get; private set; }

        public void DataSymptomDisease()
        {
            SymptomDisease = new string[,]
                        {
                    { "Frequent urination", "Excessive thirst", "Increased hunger", "Fatigue", "Slow healing", "Diabetes" },
                    { "Persistent cough", "Fever", "Night sweats", "Weight loss", "Chest pain", "Tuberculosis" },
                    { "High fever", "Chills", "Headache", "Vomiting", "Muscle pain", "Malaria" },
                    { "High fever", "Severe headache", "Joint pain", "Rash", "Bleeding", "Dengue" },
                    { "Headache", "Dizziness", "Blurred vision", "Chest pain", "Nosebleed", "Hypertension" },
                    { "Shortness of breath", "Wheezing", "Chest tightness", "Coughing", "Fatigue", "Asthma" },
                    { "Prolonged fever", "Weakness", "Abdominal pain", "Headache", "Loss of appetite", "Typhoid" },
                    { "Cough", "Fever", "Chest pain", "Short breath", "Fatigue", "Pneumonia" },
                    { "Throbbing headache", "Nausea", "Vomiting", "Sensitivity to light", "Blurred vision", "Migraine" },
                    { "Joint pain", "Stiffness", "Swelling", "Redness", "Reduced movement", "Arthritis" }
                        };
                    }




        public string[,] MedicationDisease { get; private set; }

        public void DataMedicationDisease()
        {
            MedicationDisease = new string[,]
            {
        { "Diabetes", "Metformin", "Insulin", "Glipizide", "Sitagliptin", "Acarbose" },
        { "Tuberculosis", "Isoniazid", "Rifampicin", "Ethambutol", "Pyrazinamide", "Streptomycin" },
        { "Malaria", "Chloroquine", "Artemether", "Quinine", "Primaquine", "Doxycycline" },
        { "Dengue", "Paracetamol", "Ibuprofen", "ORS", "IV Fluids", "Platelet transfusion" },
        { "Hypertension", "Amlodipine", "Losartan", "Atenolol", "Hydrochlorothiazide", "Enalapril" },
        { "Asthma", "Salbutamol", "Budesonide", "Montelukast", "Theophylline", "Ipratropium" },
        { "Typhoid", "Cefixime", "Azithromycin", "Ciprofloxacin", "Chloramphenicol", "Amoxicillin" },
        { "Pneumonia", "Amoxicillin", "Azithromycin", "Levofloxacin", "Ceftriaxone", "Doxycycline" },
        { "Migraine", "Sumatriptan", "Topiramate", "Propranolol", "Amitriptyline", "Naproxen" },
        { "Arthritis", "Methotrexate", "Sulfasalazine", "Leflunomide", "Ibuprofen", "Diclofenac" }
            };
        }

    }
}
