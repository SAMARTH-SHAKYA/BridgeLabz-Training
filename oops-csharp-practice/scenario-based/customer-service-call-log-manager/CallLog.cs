using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.customer_service_call_log_manager
{
    class CallLog
    {
        private string phoneNumber;
        private string message;
        private DateTime timestamp;

        public CallLog(string phoneNumber, string message, DateTime timestamp)
        {
            this.phoneNumber = phoneNumber; 
            this.message = message;
            this.timestamp = timestamp;
        }
        public string GetPhoneNumber()
        {
            return phoneNumber;
        }
        public string GetMessage()
        {
            return message;
        }
        public DateTime GetTimestamp()
        {
            return timestamp;
        }
    }
}
