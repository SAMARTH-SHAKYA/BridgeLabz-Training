using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.Constructor
{
    internal class UniversityManagement
    {
        //global variables
        public int rollNumber;
        protected string name;
        private double CGPA;

        //calling the constructor
        public UniversityManagement(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.CGPA = cgpa;
        }

        //method to get CGPA
        public double GetCGPA()
        {
            return CGPA;
        }


        //Method to set CGPA
        public void SetCGPA(double cgpa)
        {
            CGPA = cgpa;
        }
    }

    //making subclass
    class PostgraduateStudent : UniversityManagement
    {
        public PostgraduateStudent(int rollNumber, string name, double cgpa)
            : base(rollNumber, name, cgpa) { }

        public void Display()
        {
            Console.WriteLine($"Roll: {rollNumber}, Name: {name}");
        }
    }
}
