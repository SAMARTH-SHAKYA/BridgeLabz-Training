using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace BridgeLabzTraining.ClassAndObject
{
    //creating class empployee
    internal class Employee
    {

        //intilizaing field of the class
        public string Name;
        public string Id;
        //making salary private so that outside the class no one can change it
        private double Salary;

        //calling constructor
        public Employee(string name, string id, double salary)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
        }

        //displaying details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name : {Name}, Id : {Id} and Salary {Salary}");
        }
    }
}
