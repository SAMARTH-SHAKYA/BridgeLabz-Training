using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.employee_management_system
{
    //making the base class abstract 
    internal abstract class Employee
    {
        // making fileds protected and encapsulated
        protected string EmployeeId { get; set; }
        protected string EmployeeName { get; set; }

        protected double EmployeeSalary { get; set; }

        protected string Department { get; set; }
        

        //calling the constructor
        public Employee(string employeeId, string employeeName, double employeeSalary)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.EmployeeSalary = employeeSalary;
            this.Department = null;
        }

        //overriding the toString method
        public override string ToString()
        {
            return $"ID: {EmployeeId}, Name: {EmployeeName}, Salary: {EmployeeSalary}";
        }

        // making sure that calculate salary implemented by child
        public abstract double CalculateSalary();
        
    }

}
