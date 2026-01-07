using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.EmployeeWage
{
    internal class Employee
    {
        public string EmployeeId { get; private set; }
        public string EmployeeName { get; private set; }

        public double EmployeeSalary { get; private  set; }

        public string Department { get; private set; }

        public Employee(string employeeId,string employeeName,string department) 
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.Department = department;

        }
        public override string ToString()
        {
            return $"ID: {EmployeeId}, Name: {EmployeeName}, Salary: {EmployeeSalary}";
        }
    }
}
