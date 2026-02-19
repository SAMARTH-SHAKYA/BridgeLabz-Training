using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Menu;

public class VisitMenu
{
    private readonly IVisitService _visitService;
    private readonly IAppointmentService _appointmentService;

    public VisitMenu(IVisitService visitService, IAppointmentService appointmentService)
    {
        _visitService = visitService;
        _appointmentService = appointmentService;
    }

    public async Task ShowVisitMenuAsync()
    {
        while (true)
        {
            ConsoleHelper.PrintHeader("Visit Management");
            Console.WriteLine("1. Complete Visit");
            Console.WriteLine("2. Add Prescription");
            Console.WriteLine("3. View Prescriptions by Visit");
            Console.WriteLine("4. View Visit by ID");
            Console.WriteLine("0. Back to Main Menu");
            ConsoleHelper.PrintSeparator();

            var choice = ConsoleHelper.ReadLine("Enter your choice");

            try
            {
                switch (choice)
                {
                    case "1":
                        await CompleteVisitAsync();
                        break;
                    case "2":
                        await AddPrescriptionAsync();
                        break;
                    case "3":
                        await ViewPrescriptionsByVisitAsync();
                        break;
                    case "4":
                        await ViewVisitByIdAsync();
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

    private async Task CompleteVisitAsync()
    {
        ConsoleHelper.PrintHeader("Complete Visit");
        var appointmentId = ConsoleHelper.ReadInt("Enter Appointment ID");

        var appointment = await _appointmentService.GetAppointmentByIdAsync(appointmentId);
        if (appointment == null)
        {
            Logger.LogWarning("Appointment not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        if (appointment.Status == "COMPLETED")
        {
            Logger.LogWarning("This appointment has already been completed.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        var diagnosis = ConsoleHelper.ReadLine("Enter Diagnosis");
        var notes = ConsoleHelper.ReadLine("Enter Notes (optional)");

        var visitId = await _visitService.CompleteVisitAsync(appointmentId, diagnosis, notes ?? "");
        Logger.LogSuccess($"Visit completed successfully with ID: {visitId}");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task AddPrescriptionAsync()
    {
        ConsoleHelper.PrintHeader("Add Prescription");
        var visitId = ConsoleHelper.ReadInt("Enter Visit ID");

        var visit = await _visitService.GetVisitByIdAsync(visitId);
        if (visit == null)
        {
            Logger.LogWarning("Visit not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        var medicineName = ConsoleHelper.ReadLine("Enter Medicine Name");
        var dosage = ConsoleHelper.ReadLine("Enter Dosage (optional)");
        var duration = ConsoleHelper.ReadLine("Enter Duration (optional)");

        var success = await _visitService.AddPrescriptionAsync(visitId, medicineName, dosage ?? "", duration ?? "");
        if (success)
            Logger.LogSuccess("Prescription added successfully.");
        else
            Logger.LogWarning("Failed to add prescription.");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewPrescriptionsByVisitAsync()
    {
        ConsoleHelper.PrintHeader("Prescriptions by Visit");
        var visitId = ConsoleHelper.ReadInt("Enter Visit ID");

        var prescriptions = await _visitService.GetPrescriptionsByVisitAsync(visitId);
        if (prescriptions.Count == 0)
        {
            Logger.LogInfo("No prescriptions found for this visit.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Medicine Name",-30} {"Dosage",-20} {"Duration",-20}");
            ConsoleHelper.PrintSeparator();
            foreach (var prescription in prescriptions)
            {
                Console.WriteLine($"{prescription.PrescriptionId,-5} {prescription.MedicineName,-30} {prescription.Dosage ?? "N/A",-20} {prescription.Duration ?? "N/A",-20}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewVisitByIdAsync()
    {
        ConsoleHelper.PrintHeader("View Visit by ID");
        var visitId = ConsoleHelper.ReadInt("Enter Visit ID");

        var visit = await _visitService.GetVisitByIdAsync(visitId);
        if (visit == null)
        {
            Logger.LogWarning("Visit not found.");
        }
        else
        {
            Console.WriteLine($"ID: {visit.VisitId}");
            Console.WriteLine($"Appointment ID: {visit.AppointmentId}");
            Console.WriteLine($"Appointment Date: {visit.Appointment?.AppointmentDate:yyyy-MM-dd}");
            Console.WriteLine($"Diagnosis: {visit.Diagnosis ?? "N/A"}");
            Console.WriteLine($"Notes: {visit.Notes ?? "N/A"}");
            Console.WriteLine($"Visit Date: {visit.VisitDate:yyyy-MM-dd HH:mm:ss}");
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }
}

