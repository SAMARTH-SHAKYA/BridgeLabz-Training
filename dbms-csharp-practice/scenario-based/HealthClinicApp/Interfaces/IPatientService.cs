using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces;

public interface IPatientService
{
    Task<int> RegisterPatientAsync(Patient patient);
    Task<bool> UpdatePatientAsync(Patient patient);
    Task<Patient?> GetPatientByIdAsync(int patientId);
    Task<List<Patient>> GetAllPatientsAsync();
    Task<bool> DeletePatientAsync(int patientId);
}

