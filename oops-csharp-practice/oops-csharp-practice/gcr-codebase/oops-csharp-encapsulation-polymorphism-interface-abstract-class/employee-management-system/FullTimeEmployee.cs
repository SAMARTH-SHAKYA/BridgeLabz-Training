using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.employee_management_system
{
    //child class of empoloyee
    internal class FullTimeEmployee : Employee, IDepartment
    {
        private double bonus { get; set; }
        public FullTimeEmployee(string employeeId, string employeeName, double employeeSalary, double bonus) : base(employeeId, employeeName, employeeSalary)
        {
            this.bonus = employeeSalary * 0.10;
        }

        public override double  CalculateSalary()
        {
            double salary = bonus + EmployeeSalary;
            return salary;
        }

        public void AssignDepartment(string department)
        {
            this.Department = department;
        }

        public string GetDepartmentDetails()
        {
            return this.Department;
        }
    }
}
