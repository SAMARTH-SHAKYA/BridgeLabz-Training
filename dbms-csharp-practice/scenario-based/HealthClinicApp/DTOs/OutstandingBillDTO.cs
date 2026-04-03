namespace HealthClinicApp.DTOs;

public class OutstandingBillDTO
{
    public string PatientName { get; set; } = string.Empty;
    public int TotalBills { get; set; }
    public decimal TotalDue { get; set; }
}

