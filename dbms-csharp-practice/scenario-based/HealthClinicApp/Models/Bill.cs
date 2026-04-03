namespace HealthClinicApp.Models;

public class Bill
{
    public int BillId { get; set; }
    public int VisitId { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentStatus { get; set; } = "UNPAID";
    public DateTime? PaymentDate { get; set; }
    public string? PaymentMode { get; set; }
    public DateTime CreatedAt { get; set; }
    public Visit? Visit { get; set; }
}

