using HealthClinicApp.DTOs;
using HealthClinicApp.Interfaces;

namespace HealthClinicApp.Reports;

public class OutstandingBillsReport
{
    private readonly IAdminService _adminService;

    public OutstandingBillsReport(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public async Task<List<OutstandingBillDTO>> GenerateOutstandingBillsReportAsync()
    {
        return await _adminService.GetOutstandingBillsReportAsync();
    }
}

