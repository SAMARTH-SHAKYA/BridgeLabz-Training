using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class EuclideanDistance
    {
        public static double CalEucDistance(int x1,int y1,int x2,int y2)
        {
            int x = x2 - x1;
            int y = y2 - y1;
            double distance = Math.Sqrt(x*x + y*y);
            return distance;
        }

        public static double[] Equation(int x1, int y1, int x2, int y2)
        {
            double x = x2 - x1;
            double y = y2 - y1;
            double m = y / x;
            double b = y1 - m * x1;

            double[] parameters = new double[2];
            parameters[0] = m;
            parameters[1] = b;
            Console.WriteLine($"slope of the points {parameters[0]}");
            Console.WriteLine($"intercept of the points {parameters[1]}");
            return parameters;
        }
        public static void main()
        {
            Console.WriteLine("Input coordinates for point1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input coordinates for point2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double distance = CalEucDistance(x1,y1,x2,y2);
            Console.WriteLine("the distance between the points are: ");
            Console.WriteLine(distance);

            double[] slopeIntercept = Equation(x1,y1,x2,y2);



        }
    }
}
