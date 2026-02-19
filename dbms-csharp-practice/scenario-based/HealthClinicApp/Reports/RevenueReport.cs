using HealthClinicApp.Interfaces;

namespace HealthClinicApp.Reports;

public class RevenueReport
{
    private readonly IAdminService _adminService;

    public RevenueReport(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public async Task<decimal> GenerateRevenueReportAsync(DateTime startDate, DateTime endDate)
    {
        return await _adminService.GetRevenueReportAsync(startDate, endDate);
    }
}

