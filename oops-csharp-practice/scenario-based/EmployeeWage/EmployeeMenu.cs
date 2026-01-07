using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.EmployeeWage
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeUtility;

        public void EmployeeChoice()
        {
            employeeUtility = new EmployeeUtilityImpl();

            Employee E1 = employeeUtility.AddEmployee();
            
            string checkAttendance = employeeUtility.CheckAttendance(E1);
            Console.WriteLine(checkAttendance);
        }
    }
}
