using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Menu;

public class AppointmentMenu
{
    private readonly IAppointmentService _appointmentService;
    private readonly IPatientService _patientService;
    private readonly IDoctorService _doctorService;

    public AppointmentMenu(
        IAppointmentService appointmentService,
        IPatientService patientService,
        IDoctorService doctorService)
    {
        _appointmentService = appointmentService;
        _patientService = patientService;
        _doctorService = doctorService;
    }

    public async Task ShowAppointmentMenuAsync()
    {
        while (true)
        {
            ConsoleHelper.PrintHeader("Appointment Management");
            Console.WriteLine("1. Book Appointment");
            Console.WriteLine("2. Cancel Appointment");
            Console.WriteLine("3. View All Appointments");
            Console.WriteLine("4. View Appointments by Patient");
            Console.WriteLine("5. View Appointments by Doctor");
            Console.WriteLine("6. View Appointment by ID");
            Console.WriteLine("0. Back to Main Menu");
            ConsoleHelper.PrintSeparator();

            var choice = ConsoleHelper.ReadLine("Enter your choice");

            try
            {
                switch (choice)
                {
                    case "1":
                        await BookAppointmentAsync();
                        break;
                    case "2":
                        await CancelAppointmentAsync();
                        break;
                    case "3":
                        await ViewAllAppointmentsAsync();
                        break;
                    case "4":
                        await ViewAppointmentsByPatientAsync();
                        break;
                    case "5":
                        await ViewAppointmentsByDoctorAsync();
                        break;
                    case "6":
                        await ViewAppointmentByIdAsync();
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

    private async Task BookAppointmentAsync()
    {
        ConsoleHelper.PrintHeader("Book Appointment");

        var patientId = ConsoleHelper.ReadInt("Enter Patient ID");
        var patient = await _patientService.GetPatientByIdAsync(patientId);
        if (patient == null)
        {
            Logger.LogWarning("Patient not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        var doctorId = ConsoleHelper.ReadInt("Enter Doctor ID");
        var doctor = await _doctorService.GetDoctorByIdAsync(doctorId);
        if (doctor == null)
        {
            Logger.LogWarning("Doctor not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        var date = ConsoleHelper.ReadDate("Enter Appointment Date");
        var time = ConsoleHelper.ReadTime("Enter Appointment Time");

        var appointmentId = await _appointmentService.BookAppointmentAsync(patientId, doctorId, date, time);
        Logger.LogSuccess($"Appointment booked successfully with ID: {appointmentId}");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task CancelAppointmentAsync()
    {
        ConsoleHelper.PrintHeader("Cancel Appointment");
        var appointmentId = ConsoleHelper.ReadInt("Enter Appointment ID");

        var appointment = await _appointmentService.GetAppointmentByIdAsync(appointmentId);
        if (appointment == null)
        {
            Logger.LogWarning("Appointment not found.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        Console.Write($"Are you sure you want to cancel this appointment? (y/n): ");
        var confirm = Console.ReadLine();
        if (confirm?.ToLower() != "y")
        {
            Logger.LogInfo("Cancellation cancelled.");
            ConsoleHelper.PressAnyKeyToContinue();
            return;
        }

        var success = await _appointmentService.CancelAppointmentAsync(appointmentId);
        if (success)
            Logger.LogSuccess("Appointment cancelled successfully.");
        else
            Logger.LogWarning("Failed to cancel appointment.");
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewAllAppointmentsAsync()
    {
        ConsoleHelper.PrintHeader("All Appointments");
        var appointments = await _appointmentService.GetAllAppointmentsAsync();

        if (appointments.Count == 0)
        {
            Logger.LogInfo("No appointments found.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Patient",-20} {"Doctor",-20} {"Date",-12} {"Time",-10} {"Status",-15}");
            ConsoleHelper.PrintSeparator();
            foreach (var appointment in appointments)
            {
                Console.WriteLine($"{appointment.AppointmentId,-5} {appointment.Patient?.Name ?? "N/A",-20} {appointment.Doctor?.Name ?? "N/A",-20} {appointment.AppointmentDate:yyyy-MM-dd,-12} {appointment.AppointmentTime:hh\\:mm,-10} {appointment.Status,-15}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewAppointmentsByPatientAsync()
    {
        ConsoleHelper.PrintHeader("Appointments by Patient");
        var patientId = ConsoleHelper.ReadInt("Enter Patient ID");

        var appointments = await _appointmentService.GetAppointmentsByPatientAsync(patientId);
        if (appointments.Count == 0)
        {
            Logger.LogInfo("No appointments found for this patient.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Doctor",-20} {"Date",-12} {"Time",-10} {"Status",-15}");
            ConsoleHelper.PrintSeparator();
            foreach (var appointment in appointments)
            {
                Console.WriteLine($"{appointment.AppointmentId,-5} {appointment.Doctor?.Name ?? "N/A",-20} {appointment.AppointmentDate:yyyy-MM-dd,-12} {appointment.AppointmentTime:hh\\:mm,-10} {appointment.Status,-15}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewAppointmentsByDoctorAsync()
    {
        ConsoleHelper.PrintHeader("Appointments by Doctor");
        var doctorId = ConsoleHelper.ReadInt("Enter Doctor ID");

        var appointments = await _appointmentService.GetAppointmentsByDoctorAsync(doctorId);
        if (appointments.Count == 0)
        {
            Logger.LogInfo("No appointments found for this doctor.");
        }
        else
        {
            Console.WriteLine($"{"ID",-5} {"Patient",-20} {"Date",-12} {"Time",-10} {"Status",-15}");
            ConsoleHelper.PrintSeparator();
            foreach (var appointment in appointments)
            {
                Console.WriteLine($"{appointment.AppointmentId,-5} {appointment.Patient?.Name ?? "N/A",-20} {appointment.AppointmentDate:yyyy-MM-dd,-12} {appointment.AppointmentTime:hh\\:mm,-10} {appointment.Status,-15}");
            }
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }

    private async Task ViewAppointmentByIdAsync()
    {
        ConsoleHelper.PrintHeader("View Appointment by ID");
        var appointmentId = ConsoleHelper.ReadInt("Enter Appointment ID");

        var appointment = await _appointmentService.GetAppointmentByIdAsync(appointmentId);
        if (appointment == null)
        {
            Logger.LogWarning("Appointment not found.");
        }
        else
        {
            Console.WriteLine($"ID: {appointment.AppointmentId}");
            Console.WriteLine($"Patient: {appointment.Patient?.Name ?? "N/A"}");
            Console.WriteLine($"Doctor: {appointment.Doctor?.Name ?? "N/A"}");
            Console.WriteLine($"Date: {appointment.AppointmentDate:yyyy-MM-dd}");
            Console.WriteLine($"Time: {appointment.AppointmentTime:hh\\:mm}");
            Console.WriteLine($"Status: {appointment.Status}");
            Console.WriteLine($"Created At: {appointment.CreatedAt:yyyy-MM-dd HH:mm:ss}");
        }
        ConsoleHelper.PressAnyKeyToContinue();
    }
}

