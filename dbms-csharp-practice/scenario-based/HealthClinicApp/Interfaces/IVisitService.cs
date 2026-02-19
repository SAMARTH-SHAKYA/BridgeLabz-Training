using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces;

public interface IVisitService
{
    Task<int> CompleteVisitAsync(int appointmentId, string diagnosis, string notes);
    Task<bool> AddPrescriptionAsync(int visitId, string medicineName, string dosage, string duration);
    Task<List<Prescription>> GetPrescriptionsByVisitAsync(int visitId);
    Task<Visit?> GetVisitByIdAsync(int visitId);
}

