using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    //main class person
    class Person
    {
        //using getter an setter for field
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //sub class teacher
    class Teacher : Person
    {
        public string Subject { get; set; }
        public void DisplayRole() => Console.WriteLine("Teacher");
    }

    //sub class student
    class Student : Person
    {
        public string Grade { get; set; }
        public void DisplayRole() => Console.WriteLine("Student");
    }

    //sub class persomn
    class Staff : Person
    {
        public string Department { get; set; }
        public void DisplayRole() => Console.WriteLine("Staff");
    }

}
