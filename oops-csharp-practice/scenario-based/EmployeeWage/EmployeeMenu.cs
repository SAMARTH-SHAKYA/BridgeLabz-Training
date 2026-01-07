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

            //checking functionality of checkattendance
            employeeUtility = new EmployeeUtilityImpl();
            Employee E1 = employeeUtility.AddEmployee();
            string checkAttendance = employeeUtility.CheckAttendance(E1);
            Console.WriteLine(checkAttendance);

            //checking functionality of calculate dailywage
            double dailyWage = employeeUtility.EmployeeWage(E1, checkAttendance);
            Console.WriteLine(dailyWage);

            //checking functionality for part time employee 
            string employeeContract = employeeUtility.PartTimeEmployee(E1);
            Console.WriteLine(employeeContract);
        }
    }
}
