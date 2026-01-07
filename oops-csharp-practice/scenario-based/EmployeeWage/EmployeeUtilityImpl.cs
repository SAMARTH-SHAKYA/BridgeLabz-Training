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
            Random random = new Random();
            int attendance = random.Next(0, 2);
            
            if(attendance == 0)
            {
                
                return "Present";
            }
            return "Absent";
        }

        // UC 2 --- method to calculate daily wage
        public double EmployeeWage(Employee employee, string checkAttendace)
        {
            if (checkAttendace == "Absent")
            {
                return 0;
            }
            return 20 * 8;
        }

        // UC 3 --- method to check part time employee or full time employee

        public string PartTimeEmployee(Employee employee)
        {
            Random random = new Random();
            int partTimer = random.Next(0, 2);

            if (partTimer == 0)
            {

                return "Part Time Employee";
            }
            return "Full Time Employee";
        }

        // UC 5 --- method to calculate monthly wage of a employee

        public double CalculateMonthWage(Employee employee)
        {
            Random random = new Random();
            int days = random.Next(1, 21);
            Console.WriteLine($"Employee worked for {days} days");
            return days * 160;
        }


    }
}
