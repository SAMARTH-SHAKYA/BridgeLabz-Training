using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    //main class
    class Course
    {
        public string CourseName { get; set; }
        public int Duration { get; set; }
    }

    //demostrating multi level inheritance
    class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public bool IsRecorded { get; set; }
    }

    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee { get; set; }
        public double Discount { get; set; }
    }

}
