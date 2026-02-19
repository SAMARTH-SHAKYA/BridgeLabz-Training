using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces;

public interface IDoctorService
{
    Task<List<Doctor>> GetAllDoctorsAsync();
    Task<Doctor?> GetDoctorByIdAsync(int doctorId);
    Task<List<Doctor>> GetDoctorsBySpecialtyAsync(int specialtyId);
    Task<List<Specialty>> GetAllSpecialtiesAsync();
}

