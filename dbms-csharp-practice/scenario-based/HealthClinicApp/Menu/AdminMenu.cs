using HealthClinicApp.DTOs;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Menu;

public class AdminMenu
{
    private readonly IAdminService _adminService;

    public AdminMenu(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public async Task ShowAdminMenuAsync()
    {
        while (true)
        {
            ConsoleHelper.PrintHeader("Admin Reports");
            Console.WriteLine("1. Revenue Report");
            Console.WriteLine("2. Outstanding Bills Report");
            Console.WriteLine("0. Back to Main Menu");
            ConsoleHelper.PrintSeparator();

            var choice = ConsoleHelper.ReadLine("Enter your choice");

            try
            {
                switch (choice)
                {
                    case "1":
                        await ShowRevenueReportAsync();
                        break;
                    case "2":
                        await ShowOutstandingBillsReportAsync();
                        break;
                    case "0":
                        return;
                    default:
                        Logger.LogWarning("Invalid choice. Please try again.");
                        ConsoleHelper.PressAnyKeyToContinue();
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("An error occurred", ex);
                ConsoleHelper.PressAnyKeyToContinue();
            }
        }
    }

    private async Task ShowRevenueReportAsync()
    {
        ConsoleHelper.PrintHeader("Revenue Report");
        var startDate = ConsoleHelper.ReadDate("Enter Start Date");
        var endDate = ConsoleHelper.ReadDate("Enter End Date");

        var revenue = await _adminService.GetRevenueReportAsync(startDate, endDate);
        Console.WriteLine($"\nTotal Revenue from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}: {revenue:C}");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ShowOutstandingBillsReportAsync()
    {
        ConsoleHelper.PrintHeader("Outstanding Bills Report");
        var outstandingBills = await _adminService.GetOutstandingBillsReportAsync();

        if (outstandingBills.Count == 0)
        {
            Logger.LogInfo("No outstanding bills found.");
        }
        else
        {
            Console.WriteLine($"{"Patient Name",-30} {"Total Bills",-15} {"Total Due",-15}");
            ConsoleHelper.PrintSeparator();
            foreach (var bill in outstandingBills)
            {
                Console.WriteLine($"{bill.PatientName,-30} {bill.TotalBills,-15} {bill.TotalDue,-15:C}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }
}

