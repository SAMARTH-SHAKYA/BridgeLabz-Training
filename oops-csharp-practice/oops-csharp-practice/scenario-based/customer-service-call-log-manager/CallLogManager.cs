using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.customer_service_call_log_manager
{
    class CallLogManager
    {
        private CallLog[] logs;
        private int logCount;

        public CallLogManager(int size)
        {
            logs = new CallLog[size];
            logCount = 0;
        }

        public void AddCallLog()
        {
            if(logCount >=  logs.Length)
            {
                Console.WriteLine("CallLogs is full.");
                return;
            }
            Console.Write("Enter phone number --> ");
            string phone = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(phone) || phone.Length != 10 || !long.TryParse(phone, out _))
            {
                Console.WriteLine("Invalid phone number.");
                return;
            }

            Console.Write("Enter message --> ");
            string message = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Invalid message.");
                return;
            }
            
            DateTime now = DateTime.Now;

            CallLog log = new CallLog(phone, message, now);
            
            logs[logCount++] = log;
        }

        public void SearchByKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("Invalid keyword.");
                return;
            }
            for(int i=0; i<logCount; i++)
            {
                if (logs[i].GetMessage().Contains(keyword,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Phone Number --> {logs[i].GetPhoneNumber()}");
                    Console.WriteLine($"Message --> {logs[i].GetMessage()}");
                    Console.WriteLine($"Timestamp --> {logs[i].GetTimestamp()}");
                }
            }
        }

        public void FilterByTime(DateTime start, DateTime end)
        {
            for(int i=0; i<logCount; i++)
            {
                if (start > end)
                {
                    Console.WriteLine("Invalid time range. Start time must be before end time.");
                    return;
                }

                if (logs[i].GetTimestamp() >= start && logs[i].GetTimestamp() <= end)
                {
                    Console.WriteLine($"Phone Number --> {logs[i].GetPhoneNumber()}");
                    Console.WriteLine($"Message --> {logs[i].GetMessage()}");
                    Console.WriteLine($"Timestamp --> {logs[i].GetTimestamp()}");
                }
            }
        }

        public void DisplayLog(CallLog log)
        {
            Console.WriteLine($"Phone Number --> {log.GetPhoneNumber()}");
            Console.WriteLine($"Message --> {log.GetMessage()}");
            Console.WriteLine($"Timestamp --> {log.GetTimestamp()}");
        }


    }
}
