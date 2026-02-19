using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Menu;

public class DoctorMenu
{
    private readonly IDoctorService _doctorService;

    public DoctorMenu(IDoctorService doctorService)
    {
        _doctorService = doctorService;
    }

    public async Task ShowDoctorMenuAsync()
    {
        while (true)
        {
            ConsoleHelper.PrintHeader("Doctor Management");
            Console.WriteLine("1. View All Doctors");
            Console.WriteLine("2. View Doctor by ID");
            Console.WriteLine("3. View Doctors by Specialty");
            Console.WriteLine("4. View All Specialties");
            Console.WriteLine("0. Back to Main Menu");
            ConsoleHelper.PrintSeparator();

            var choice = ConsoleHelper.ReadLine("Enter your choice");

            try
            {
                switch (choice)
                {
                    case "1":
                        await ViewAllDoctorsAsync();
                        break;
                    case "2":
                        await ViewDoctorByIdAsync();
                        break;
                    case "3":
                        await ViewDoctorsBySpecialtyAsync();
                        break;
                    case "4":
                        await ViewAllSpecialtiesAsync();
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

    private async Task ViewAllDoctorsAsync()
    {
        ConsoleHelper.PrintHeader("All Doctors");
        var doctors = await _doctorService.GetAllDoctorsAsync();

        if (doctors.Count == 0)
        {
            Logger.LogInfo("No doctors found.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Name",-25} {"Specialty",-20} {"Fee",-10} {"Contact",-15}");
            ConsoleHelper.PrintSeparator();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.DoctorId,-5} {doctor.Name,-25} {doctor.Specialty?.SpecialtyName ?? "N/A",-20} {doctor.ConsultationFee,-10:C} {doctor.Contact ?? "N/A",-15}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewDoctorByIdAsync()
    {
        ConsoleHelper.PrintHeader("View Doctor by ID");
        var doctorId = ConsoleHelper.ReadInt("Enter Doctor ID");

        var doctor = await _doctorService.GetDoctorByIdAsync(doctorId);
        if (doctor == null)
        {
            Logger.LogWarning("Doctor not found.");
        }
        else
        {
            Console.WriteLine($"ID: {doctor.DoctorId}");
            Console.WriteLine($"Name: {doctor.Name}");
            Console.WriteLine($"Specialty: {doctor.Specialty?.SpecialtyName ?? "N/A"}");
            Console.WriteLine($"Consultation Fee: {doctor.ConsultationFee:C}");
            Console.WriteLine($"Contact: {doctor.Contact ?? "N/A"}");
            Console.WriteLine($"Active: {(doctor.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Created At: {doctor.CreatedAt:yyyy-MM-dd HH:mm:ss}");
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewDoctorsBySpecialtyAsync()
    {
        ConsoleHelper.PrintHeader("Doctors by Specialty");
        var specialties = await _doctorService.GetAllSpecialtiesAsync();

        if (specialties.Count == 0)
        {
            Logger.LogInfo("No specialties found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        Console.WriteLine("Available Specialties:");
        foreach (var specialty in specialties)
        {
            Console.WriteLine($"{specialty.SpecialtyId}. {specialty.SpecialtyName}");
        }

        var specialtyId = ConsoleHelper.ReadInt("Enter Specialty ID");
        var doctors = await _doctorService.GetDoctorsBySpecialtyAsync(specialtyId);

        if (doctors.Count == 0)
        {
            Logger.LogInfo("No doctors found for this specialty.");
        }
        else
        {
            Console.WriteLine($"\n{"ID",-5} {"Name",-25} {"Fee",-10} {"Contact",-15}");
            ConsoleHelper.PrintSeparator();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.DoctorId,-5} {doctor.Name,-25} {doctor.ConsultationFee,-10:C} {doctor.Contact ?? "N/A",-15}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewAllSpecialtiesAsync()
    {
        ConsoleHelper.PrintHeader("All Specialties");
        var specialties = await _doctorService.GetAllSpecialtiesAsync();

        if (specialties.Count == 0)
        {
            Logger.LogInfo("No specialties found.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Specialty Name",-30}");
            ConsoleHelper.PrintSeparator();
            foreach (var specialty in specialties)
            {
                Console.WriteLine($"{specialty.SpecialtyId,-5} {specialty.SpecialtyName,-30}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }
}

