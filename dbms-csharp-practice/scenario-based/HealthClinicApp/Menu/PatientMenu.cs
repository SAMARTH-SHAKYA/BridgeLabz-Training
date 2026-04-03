using HealthClinicApp.Interfaces;
using HealthClinicApp.Models;
using HealthClinicApp.Utilities;
using HealthClinicApp.Exceptions;

namespace HealthClinicApp.Menu;

public class PatientMenu
{
    private readonly IPatientService _patientService;

    public PatientMenu(IPatientService patientService)
    {
        _patientService = patientService;
    }

    public async Task ShowPatientMenuAsync()
    {
        while (true)
        {
            ConsoleHelper.PrintHeader("Patient Management");
            Console.WriteLine("1. Register New Patient");
            Console.WriteLine("2. Update Patient");
            Console.WriteLine("3. View All Patients");
            Console.WriteLine("4. View Patient by ID");
            Console.WriteLine("5. Delete Patient");
            Console.WriteLine("0. Back to Main Menu");
            ConsoleHelper.PrintSeparator();

            var choice = ConsoleHelper.ReadLine("Enter your choice");

            try
            {
                switch (choice)
                {
                    case "1":
                        await RegisterPatientAsync();
                        break;
                    case "2":
                        await UpdatePatientAsync();
                        break;
                    case "3":
                        await ViewAllPatientsAsync();
                        break;
                    case "4":
                        await ViewPatientByIdAsync();
                        break;
                    case "5":
                        await DeletePatientAsync();
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

    private async Task RegisterPatientAsync()
    {
        ConsoleHelper.PrintHeader("Register New Patient");

        var patient = new Patient
        {
            Name = ConsoleHelper.ReadLine("Enter Name"),
            Dob = ConsoleHelper.ReadDate("Enter Date of Birth"),
            Contact = ConsoleHelper.ReadLine("Enter Contact"),
            Email = ConsoleHelper.ReadLine("Enter Email (optional)"),
            Address = ConsoleHelper.ReadLine("Enter Address (optional)"),
            BloodGroup = ConsoleHelper.ReadLine("Enter Blood Group (optional, e.g., A+, B-, O+)")
        };

        if (!InputValidator.IsValidPhone(patient.Contact))
            throw new ValidationException("Invalid contact number format.");

        if (!string.IsNullOrWhiteSpace(patient.Email) && !InputValidator.IsValidEmail(patient.Email))
            throw new ValidationException("Invalid email format.");

        if (!string.IsNullOrWhiteSpace(patient.BloodGroup) && !InputValidator.IsValidBloodGroup(patient.BloodGroup))
            throw new ValidationException("Invalid blood group format.");

        var patientId = await _patientService.RegisterPatientAsync(patient);
        Logger.LogSuccess($"Patient registered successfully with ID: {patientId}");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task UpdatePatientAsync()
    {
        ConsoleHelper.PrintHeader("Update Patient");
        var patientId = ConsoleHelper.ReadInt("Enter Patient ID");

        var patient = await _patientService.GetPatientByIdAsync(patientId);
        if (patient == null)
        {
            Logger.LogWarning("Patient not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        patient.Name = ConsoleHelper.ReadLine($"Enter Name (current: {patient.Name})");
        patient.Dob = ConsoleHelper.ReadDate($"Enter Date of Birth (current: {patient.Dob:yyyy-MM-dd})");
        patient.Contact = ConsoleHelper.ReadLine($"Enter Contact (current: {patient.Contact})");
        patient.Email = ConsoleHelper.ReadLine($"Enter Email (current: {patient.Email ?? "N/A"})");
        patient.Address = ConsoleHelper.ReadLine($"Enter Address (current: {patient.Address ?? "N/A"})");
        patient.BloodGroup = ConsoleHelper.ReadLine($"Enter Blood Group (current: {patient.BloodGroup ?? "N/A"})");

        if (!InputValidator.IsValidPhone(patient.Contact))
            throw new ValidationException("Invalid contact number format.");

        if (!string.IsNullOrWhiteSpace(patient.Email) && !InputValidator.IsValidEmail(patient.Email))
            throw new ValidationException("Invalid email format.");

        var success = await _patientService.UpdatePatientAsync(patient);
        if (success)
            Logger.LogSuccess("Patient updated successfully.");
        else
            Logger.LogWarning("Failed to update patient.");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewAllPatientsAsync()
    {
        ConsoleHelper.PrintHeader("All Patients");
        var patients = await _patientService.GetAllPatientsAsync();

        if (patients.Count == 0)
        {
            Logger.LogInfo("No patients found.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Name",-25} {"Contact",-15} {"Email",-25} {"DOB",-12}");
            ConsoleHelper.PrintSeparator();
            foreach (var patient in patients)
            {
                Console.WriteLine($"{patient.PatientId,-5} {patient.Name,-25} {patient.Contact,-15} {patient.Email ?? "N/A",-25} {patient.Dob:yyyy-MM-dd,-12}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewPatientByIdAsync()
    {
        ConsoleHelper.PrintHeader("View Patient by ID");
        var patientId = ConsoleHelper.ReadInt("Enter Patient ID");

        var patient = await _patientService.GetPatientByIdAsync(patientId);
        if (patient == null)
        {
            Logger.LogWarning("Patient not found.");
        }
        else
        {
            Console.WriteLine($"ID: {patient.PatientId}");
            Console.WriteLine($"Name: {patient.Name}");
            Console.WriteLine($"Date of Birth: {patient.Dob:yyyy-MM-dd}");
            Console.WriteLine($"Contact: {patient.Contact}");
            Console.WriteLine($"Email: {patient.Email ?? "N/A"}");
            Console.WriteLine($"Address: {patient.Address ?? "N/A"}");
            Console.WriteLine($"Blood Group: {patient.BloodGroup ?? "N/A"}");
            Console.WriteLine($"Created At: {patient.CreatedAt:yyyy-MM-dd HH:mm:ss}");
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task DeletePatientAsync()
    {
        ConsoleHelper.PrintHeader("Delete Patient");
        var patientId = ConsoleHelper.ReadInt("Enter Patient ID");

        var patient = await _patientService.GetPatientByIdAsync(patientId);
        if (patient == null)
        {
            Logger.LogWarning("Patient not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        Console.Write($"Are you sure you want to delete patient '{patient.Name}'? (y/n): ");
        var confirm = Console.ReadLine();
        if (confirm?.ToLower() != "y")
        {
            Logger.LogInfo("Deletion cancelled.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        var success = await _patientService.DeletePatientAsync(patientId);
        if (success)
            Logger.LogSuccess("Patient deleted successfully.");
        else
            Logger.LogWarning("Failed to delete patient.");
        ConsoleHelper.PressAnyKeyToContinue();
    }
}

