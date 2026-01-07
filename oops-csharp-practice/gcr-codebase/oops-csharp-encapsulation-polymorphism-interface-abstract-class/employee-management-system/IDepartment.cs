using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.employee_management_system
{
    internal interface IDepartment
    {
        public void AssignDepartment(string department);

        public string  GetDepartmentDetails();
    }
}
