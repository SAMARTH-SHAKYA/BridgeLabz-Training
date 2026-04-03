using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sealed
{
    using System;

    class Student
    {

        //static gloabl variables
        public static string UniversityName = "State University";
        private static int totalStudents = 0;


        //non static global varaibles
        public int RollNumber { get; private set; }
        public string Name { get; set; }
        public char Grade { get; set; }

        //calling the construcotr
        public Student(int rollNumber, string name, char grade)
        {
            this.RollNumber = rollNumber;
            this.Name = name;
            this.Grade = grade;
            totalStudents++;
        }

        //method to display total students
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + totalStudents);
        }


        //method to check the current instance of the object
        public void Display(object obj)
        {
            if (obj is Student)
            {
                Console.WriteLine($"Roll: {RollNumber}, Name: {Name}, Grade: {Grade}");
            }
        }
    }

}
