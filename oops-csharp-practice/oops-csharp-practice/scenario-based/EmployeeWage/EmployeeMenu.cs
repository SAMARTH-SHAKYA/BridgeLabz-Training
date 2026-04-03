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

            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //checking functionality of checkattendance
            employeeUtility = new EmployeeUtilityImpl();
            Employee E1 = employeeUtility.AddEmployee();
            //string checkAttendance = employeeUtility.CheckAttendance(E1);
            //Console.WriteLine(checkAttendance);

            //checking functionality of calculate dailywage
            //double dailyWage = employeeUtility.EmployeeWage(E1, checkAttendance);
            //Console.WriteLine(dailyWage);

            //checking functionality for part time employee 
            //string employeeContract = employeeUtility.PartTimeEmployee(E1);
            //Console.WriteLine(employeeContract);

            bool isTure = true;


            // UC 4 Added switch case 
            while (isTure) 
            {
                Console.WriteLine("Press 1 : Check Employee is Present or Absent");
                Console.WriteLine("Press 2 : Check Daily Wage of employee");
                Console.WriteLine("Press 3 : Check Employee is full time or part time");
                Console.WriteLine("Press 4 : Check employee monthly wage");
                Console.WriteLine("Press 5 : Check employee wage till now");
                Console.WriteLine("Press 6 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        string checkAttendance = employeeUtility.CheckAttendance(E1);
                        Console.Write($"{E1.ToString()}, Attendance : ");
                        Console.WriteLine(checkAttendance);
                        break;

                    case 2:
                        string checkAttendance1 = employeeUtility.CheckAttendance(E1);
                        double dailyWage = employeeUtility.EmployeeWage(E1, checkAttendance1);
                        Console.Write($"{E1.ToString()}, Salary : ");
                        Console.WriteLine(dailyWage);
                        break;

                    case 3:
                        string employeeContract = employeeUtility.PartTimeEmployee(E1);
                        Console.Write($"{E1.ToString()}, Contract : ");
                        Console.WriteLine(employeeContract);
                        break;

                    case 4:
                        double wage = employeeUtility.CalculateMonthWage(E1);
                        Console.Write($"{E1.ToString()}, Monthly wage : ");
                        Console.WriteLine(wage);
                        break;

                    case 5:
                        double wageTillNow = employeeUtility.CalculateWageTillNow(E1);
                        Console.WriteLine($"{E1.ToString()}");
                        Console.WriteLine(wageTillNow);
                        break;

                    case 6:
                        isTure = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }

        }
    }
}
