using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.EmployeeWage
{
    internal interface IEmployee
    {
        public Employee AddEmployee();

        public string CheckAttendance(Employee employee);

        public double EmployeeWage(Employee employee,string checkAttendace);


        public string PartTimeEmployee(Employee employee);
    }
}
