using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sealed
{
    using System;

    class Employee
    {
        //static global variables
        public static string CompanyName = "Tech Corp";
        private static int totalEmployees = 0;

        //non static global varaiables and use get set
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        //calling the constructor
        public Employee(int id, string name, string designation)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            totalEmployees++;
        }

        //method to display total emmployees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }

        //checking instance of the object
        public void Display(object obj)
        {
            if (obj is Employee)
            {
                Console.WriteLine($"ID: {Id}, Name: {Name}, Designation: {Designation}");
            }
        }
    }

}
