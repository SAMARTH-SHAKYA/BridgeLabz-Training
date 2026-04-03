namespace HealthClinicApp.Models;

public class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Dob { get; set; }
    public string Contact { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? BloodGroup { get; set; }
    public DateTime CreatedAt { get; set; }
}

