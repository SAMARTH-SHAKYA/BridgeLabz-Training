using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.EmployeeWage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;

        // crreating a temporary employee
        public Employee AddEmployee()
        {
            employee = new Employee("SC001","Samarth","DOT NET");
            return employee;

        }
        // UC 1 ---- method to check attendance for an employee
        public string CheckAttendance(Employee employee)
        {
            Random rand = new Random();
            int attendance = rand.Next(0, 2);
            
            if(attendance == 0)
            {
                
                return "Present";
            }
            return "Absent";
        }

        // UC 2 --- method to calculate daily wage
        public double EmployeeWage(Employee employee, string checkAttendace)
        {
            if (checkAttendace == "absent")
            {
                return 0;
            }
            return 20 * 8;
        }
    }
}
