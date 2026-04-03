using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.ClassAndObject
{
    //making class circle
    internal class Circle
    {
        //intilizing field radius 
        private double Radius;

        //calling contructor
        public Circle(double radius)
        {
            this.Radius = radius;
            Console.WriteLine($"Circle with radius {Radius}");
        }

        //method to calculate area
        public double CalculateArea(double radius) 
        {
            double area =Math.PI*radius*radius;
            return area;
        }

        //method to calcuate circumference
        public double CalculateCircumference(double radius)
        {
            double circumference = Math.PI * radius * 2;
            return circumference;
        }

    }
}
