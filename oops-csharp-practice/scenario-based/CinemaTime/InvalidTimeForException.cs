using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CinemaTime
{
    internal class InvalidTimeFormatException : Exception
    {
        public InvalidTimeFormatException(string message) : base(message) { }
    }
}
