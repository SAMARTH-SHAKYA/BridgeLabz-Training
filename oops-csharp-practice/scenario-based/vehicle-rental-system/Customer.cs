using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    internal class Customer
    {
        
            public string Name { get; set; }
            public string LicenseId { get; set; }

            public Customer(string name, string licenseId)
            {
                Name = name;
                LicenseId = licenseId;
            }
        
    }
}
