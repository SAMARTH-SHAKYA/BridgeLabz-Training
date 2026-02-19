using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Menu;

public class BillingMenu
{
    private readonly IBillingService _billingService;
    private readonly IVisitService _visitService;

    public BillingMenu(IBillingService billingService, IVisitService visitService)
    {
        _billingService = billingService;
        _visitService = visitService;
    }

    public async Task ShowBillingMenuAsync()
    {
        while (true)
        {
            ConsoleHelper.PrintHeader("Billing Management");
            Console.WriteLine("1. Generate Bill");
            Console.WriteLine("2. Record Payment");
            Console.WriteLine("3. View Bills by Visit");
            Console.WriteLine("4. View Bill by ID");
            Console.WriteLine("5. View Outstanding Bills");
            Console.WriteLine("0. Back to Main Menu");
            ConsoleHelper.PrintSeparator();

            var choice = ConsoleHelper.ReadLine("Enter your choice");

            try
            {
                switch (choice)
                {
                    case "1":
                        await GenerateBillAsync();
                        break;
                    case "2":
                        await RecordPaymentAsync();
                        break;
                    case "3":
                        await ViewBillsByVisitAsync();
                        break;
                    case "4":
                        await ViewBillByIdAsync();
                        break;
                    case "5":
                        await ViewOutstandingBillsAsync();
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

    private async Task GenerateBillAsync()
    {
        ConsoleHelper.PrintHeader("Generate Bill");
        var visitId = ConsoleHelper.ReadInt("Enter Visit ID");

        var visit = await _visitService.GetVisitByIdAsync(visitId);
        if (visit == null)
        {
            Logger.LogWarning("Visit not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        var totalAmount = ConsoleHelper.ReadDecimal("Enter Total Amount");

        var billId = await _billingService.GenerateBillAsync(visitId, totalAmount);
        Logger.LogSuccess($"Bill generated successfully with ID: {billId}");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task RecordPaymentAsync()
    {
        ConsoleHelper.PrintHeader("Record Payment");
        var billId = ConsoleHelper.ReadInt("Enter Bill ID");

        var bill = await _billingService.GetBillByIdAsync(billId);
        if (bill == null)
        {
            Logger.LogWarning("Bill not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        if (bill.PaymentStatus == "PAID")
        {
            Logger.LogWarning("This bill has already been paid.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        Console.WriteLine($"Bill Amount: {bill.TotalAmount:C}");
        var amount = ConsoleHelper.ReadDecimal("Enter Payment Amount");
        Console.WriteLine("Payment Modes: CASH, CARD, ONLINE");
        var paymentMode = ConsoleHelper.ReadLine("Enter Payment Mode");

        var success = await _billingService.RecordPaymentAsync(billId, amount, paymentMode);
        if (success)
            Logger.LogSuccess("Payment recorded successfully.");
        else
            Logger.LogWarning("Failed to record payment.");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewBillsByVisitAsync()
    {
        ConsoleHelper.PrintHeader("Bills by Visit");
        var visitId = ConsoleHelper.ReadInt("Enter Visit ID");

        var bills = await _billingService.GetBillsByVisitAsync(visitId);
        if (bills.Count == 0)
        {
            Logger.LogInfo("No bills found for this visit.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Amount",-15} {"Status",-15} {"Payment Date",-20} {"Payment Mode",-15}");
            ConsoleHelper.PrintSeparator();
            foreach (var bill in bills)
            {
                Console.WriteLine($"{bill.BillId,-5} {bill.TotalAmount,-15:C} {bill.PaymentStatus,-15} {(bill.PaymentDate?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A"),-20} {bill.PaymentMode ?? "N/A",-15}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewBillByIdAsync()
    {
        ConsoleHelper.PrintHeader("View Bill by ID");
        var billId = ConsoleHelper.ReadInt("Enter Bill ID");

        var bill = await _billingService.GetBillByIdAsync(billId);
        if (bill == null)
        {
            Logger.LogWarning("Bill not found.");
        }
        else
        {
            Console.WriteLine($"ID: {bill.BillId}");
            Console.WriteLine($"Visit ID: {bill.VisitId}");
            Console.WriteLine($"Total Amount: {bill.TotalAmount:C}");
            Console.WriteLine($"Payment Status: {bill.PaymentStatus}");
            Console.WriteLine($"Payment Date: {(bill.PaymentDate?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A")}");
            Console.WriteLine($"Payment Mode: {bill.PaymentMode ?? "N/A"}");
            Console.WriteLine($"Created At: {bill.CreatedAt:yyyy-MM-dd HH:mm:ss}");
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewOutstandingBillsAsync()
    {
        ConsoleHelper.PrintHeader("Outstanding Bills");
        var bills = await _billingService.GetOutstandingBillsAsync();

        if (bills.Count == 0)
        {
            Logger.LogInfo("No outstanding bills found.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Visit ID",-10} {"Amount",-15} {"Created At",-20}");
            ConsoleHelper.PrintSeparator();
            foreach (var bill in bills)
            {
                Console.WriteLine($"{bill.BillId,-5} {bill.VisitId,-10} {bill.TotalAmount,-15:C} {bill.CreatedAt:yyyy-MM-dd HH:mm:ss,-20}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }
}

