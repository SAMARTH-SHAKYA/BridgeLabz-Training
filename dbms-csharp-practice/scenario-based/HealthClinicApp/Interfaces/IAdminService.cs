using HealthClinicApp.DTOs;

namespace HealthClinicApp.Interfaces;

public interface IAdminService
{
    Task<decimal> GetRevenueReportAsync(DateTime startDate, DateTime endDate);
    Task<List<OutstandingBillDTO>> GetOutstandingBillsReportAsync();
}

