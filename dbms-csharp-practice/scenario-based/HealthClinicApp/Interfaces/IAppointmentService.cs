using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces;

public interface IAppointmentService
{
    Task<int> BookAppointmentAsync(int patientId, int doctorId, DateTime date, TimeSpan time);
    Task<bool> CancelAppointmentAsync(int appointmentId);
    Task<List<Appointment>> GetAppointmentsByPatientAsync(int patientId);
    Task<List<Appointment>> GetAppointmentsByDoctorAsync(int doctorId);
    Task<Appointment?> GetAppointmentByIdAsync(int appointmentId);
    Task<List<Appointment>> GetAllAppointmentsAsync();
}

