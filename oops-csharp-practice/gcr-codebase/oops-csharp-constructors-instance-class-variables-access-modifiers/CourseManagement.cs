using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class CourseManagement
    {
        //instance variables
        public string courseName;
        public int duration; // in months
        public double fee;

        //class variable
        public static string instituteName = "ABC Institute";

        //calling the constructor
        public CourseManagement(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        //method to display course details
        public void DisplayCourse()
        {
            Console.WriteLine($"Institute Name: {instituteName}");
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Duration: {duration} months");
            Console.WriteLine($"Fee: {fee}");
            Console.WriteLine("---------------------------");
        }

        // method to update instite name
        public static void UpdateName(string newName)
        {
            instituteName = newName;
        }
    }
}
