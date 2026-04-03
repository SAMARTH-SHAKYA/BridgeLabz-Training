using BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.EmployeeWage;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.employee_management_system
{
    // menu or utiity class 
    sealed class EmployeeMenu
    {
        //creating a reference for interface
        private IDepartment employeeUtility;
        public void EmployeeShowMenu()
        {
            FullTimeEmployee E1 = new FullTimeEmployee("CS200", "Samarth", 50000, 8023);
            employeeUtility = E1;
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("Press 1 : For assigning department");
                Console.WriteLine("Press 2 : For viewing department");
                Console.WriteLine("Press 3 : For Displaying the salary ");
                Console.WriteLine("Press 4 : For Displaying the details");
                Console.WriteLine("Press 5 : For exit");


                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("Enter department you want to assign");
                        string department = Console.ReadLine();
                        employeeUtility.AssignDepartment(department);
                        break;
                    case 2:
                        Console.WriteLine($"The department of the employee is {employeeUtility.GetDepartmentDetails()}");
                        break;
                    case 3:
                        Console.WriteLine($"Salary of the employee is :{E1.CalculateSalary()}");
                        break;
                    case 4:
                        Console.WriteLine("Displaying detais of the object");
                        Console.WriteLine(E1.ToString());
                        break;
                    case 5:
                        isTrue = false;
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input please try again");
                        break;

                        
                }

            }
            
        }
    }
}
