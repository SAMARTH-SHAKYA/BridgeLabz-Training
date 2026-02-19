namespace HealthClinicApp.Models;

public class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int SpecialtyId { get; set; }
    public string? Contact { get; set; }
    public decimal ConsultationFee { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public Specialty? Specialty { get; set; }
}

