using Microsoft.Extensions.Configuration;
using HealthClinicApp.DBHelper;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Menu;
using HealthClinicApp.Services;
using HealthClinicApp.Utilities;

namespace HealthClinicApp;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            // Load configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Initialize database connection factory
            var connectionFactory = new DbConnectionFactory(configuration);

            // Initialize services
            IPatientService patientService = new PatientService(connectionFactory);
            IDoctorService doctorService = new DoctorService(connectionFactory);
            IAppointmentService appointmentService = new AppointmentService(connectionFactory);
            IVisitService visitService = new VisitService(connectionFactory);
            IBillingService billingService = new BillingService(connectionFactory);
            IAdminService adminService = new AdminService(connectionFactory);

            // Initialize main menu
            var mainMenu = new MainMenu(
                patientService,
                doctorService,
                appointmentService,
                visitService,
                billingService,
                adminService);

            // Start the application
            await mainMenu.ShowMainMenuAsync();
        }
        catch (Exception ex)
        {
            Logger.LogError("Fatal error occurred", ex);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

