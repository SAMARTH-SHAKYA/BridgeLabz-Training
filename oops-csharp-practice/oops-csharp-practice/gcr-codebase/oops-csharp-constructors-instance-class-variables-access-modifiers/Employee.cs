using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    class Employee
    {
        //global variables
        public int employeeID;
        protected string department;
        private double salary;


        //calling the constructor
        public Employee(int id, string dept, double salary)
        {
            employeeID = id;
            department = dept;
            this.salary = salary;
        }

        //method to set salary
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        //method to get salary
        public double GetSalary()
        {
            return salary;
        }
    }

    //creating subclass manager
    class Manager : Employee
    {
        public Manager(int id, string dept, double salary)
            : base(id, dept, salary) { }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {employeeID}, Department: {department}");
        }
    }
}
