using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.employee_management_system
{
    internal class EmployeeMain
    {
        // entry point of the console application
        public static void main(string[] args)
        {
            EmployeeMenu menu = new EmployeeMenu();
            menu.EmployeeShowMenu();
        }
    }
}
