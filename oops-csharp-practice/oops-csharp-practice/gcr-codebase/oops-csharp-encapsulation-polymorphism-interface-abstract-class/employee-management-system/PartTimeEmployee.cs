using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.employee_management_system
{
    internal class PartTimeEmployee : Employee , IDepartment
    {
        private double WorkHours { get; set; }
        public PartTimeEmployee(string employeeId, string employeeName, double employeeSalary, double workHours) : base(employeeId, employeeName, employeeSalary)
        {
            this.WorkHours = workHours;
        }

        public override double CalculateSalary()
        {
            double salary =  WorkHours * 400;
            return salary;
        }

        public void AssignDepartment(string depatment)
        {
            this.Department = depatment;
        }

        public string GetDepartmentDetails()
        {
            return this.Department;
        }
    }
}
