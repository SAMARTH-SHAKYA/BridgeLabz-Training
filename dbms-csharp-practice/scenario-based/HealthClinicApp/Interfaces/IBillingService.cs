using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces;

public interface IBillingService
{
    Task<int> GenerateBillAsync(int visitId, decimal totalAmount);
    Task<bool> RecordPaymentAsync(int billId, decimal amount, string paymentMode);
    Task<List<Bill>> GetBillsByVisitAsync(int visitId);
    Task<Bill?> GetBillByIdAsync(int billId);
    Task<List<Bill>> GetOutstandingBillsAsync();
}

