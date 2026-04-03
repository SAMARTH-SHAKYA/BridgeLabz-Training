using HealthClinicApp.Interfaces;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Menu;

public class MainMenu
{
    private readonly IPatientService _patientService;
    private readonly IDoctorService _doctorService;
    private readonly IAppointmentService _appointmentService;
    private readonly IVisitService _visitService;
    private readonly IBillingService _billingService;
    private readonly IAdminService _adminService;

    public MainMenu(
        IPatientService patientService,
        IDoctorService doctorService,
        IAppointmentService appointmentService,
        IVisitService visitService,
        IBillingService billingService,
        IAdminService adminService)
    {
        _patientService = patientService;
        _doctorService = doctorService;
        _appointmentService = appointmentService;
        _visitService = visitService;
        _billingService = billingService;
        _adminService = adminService;
    }

    public async Task ShowMainMenuAsync()
    {
        while (true)
        {
            ConsoleHelper.PrintHeader("Health Clinic Management System");
            Console.WriteLine("1. Patient Management");
            Console.WriteLine("2. Doctor Management");
            Console.WriteLine("3. Appointment Management");
            Console.WriteLine("4. Visit Management");
            Console.WriteLine("5. Billing Management");
            Console.WriteLine("6. Admin Reports");
            Console.WriteLine("0. Exit");
            ConsoleHelper.PrintSeparator();

            var choice = ConsoleHelper.ReadLine("Enter your choice");

            try
            {
                switch (choice)
                {
                    case "1":
                        var patientMenu = new PatientMenu(_patientService);
                        await patientMenu.ShowPatientMenuAsync();
                        break;
                    case "2":
                        var doctorMenu = new DoctorMenu(_doctorService);
                        await doctorMenu.ShowDoctorMenuAsync();
                        break;
                    case "3":
                        var appointmentMenu = new AppointmentMenu(_appointmentService, _patientService, _doctorService);
                        await appointmentMenu.ShowAppointmentMenuAsync();
                        break;
                    case "4":
                        var visitMenu = new VisitMenu(_visitService, _appointmentService);
                        await visitMenu.ShowVisitMenuAsync();
                        break;
                    case "5":
                        var billingMenu = new BillingMenu(_billingService, _visitService);
                        await billingMenu.ShowBillingMenuAsync();
                        break;
                    case "6":
                        var adminMenu = new AdminMenu(_adminService);
                        await adminMenu.ShowAdminMenuAsync();
                        break;
                    case "0":
                        Logger.LogInfo("Thank you for using Health Clinic Management System!");
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
}

