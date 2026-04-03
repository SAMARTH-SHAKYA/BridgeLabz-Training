using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.customer_service_call_log_manager
{
    class Caller
    {
        public static void Main(string[] args)
        {
            CallLogManager manager = new CallLogManager(20);
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== CUSTOMER SERVICE CALL LOG MANAGER =====");
                Console.WriteLine("1. Add Call Log");
                Console.WriteLine("2. Search Call Logs by Keyword");
                Console.WriteLine("3. Filter Call Logs by Time Range");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddCallLog();
                        break;

                    case 2:
                        Console.Write("Enter keyword to search: ");
                        string keyword = Console.ReadLine();
                        manager.SearchByKeyword(keyword);
                        break;

                    case 3:
                        Console.Write("Enter start date & time (yyyy-MM-dd HH:mm): ");
                        DateTime start;

                        if (!DateTime.TryParse(Console.ReadLine(), out start))
                        {
                            Console.WriteLine("Invalid start date/time.");
                            break;
                        }

                        Console.Write("Enter end date & time (yyyy-MM-dd HH:mm): ");
                        DateTime end;

                        if (!DateTime.TryParse(Console.ReadLine(), out end))
                        {
                            Console.WriteLine("Invalid end date/time.");
                            break;
                        }

                        manager.FilterByTime(start, end);
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
