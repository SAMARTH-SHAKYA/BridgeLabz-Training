using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    class Employee
    {
        //global variables
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        //method to display details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
        }
    }

    //child class manager
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }

    //chile class developer
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Language: {ProgrammingLanguage}");
        }
    }

    //child class of employee
    class Intern : Employee
    {
        public string InternshipDuration { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Duration: {InternshipDuration}");
        }
    }

}
