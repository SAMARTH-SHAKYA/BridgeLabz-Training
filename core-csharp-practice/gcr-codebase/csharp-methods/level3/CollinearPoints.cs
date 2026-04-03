using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class CollinearPoints
    {
        public static void CollineraityCheck(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double slope1 = ((y2 - y1) / (x2 - x1));
            double slope2 = ((y3 - y2) / (x3 - x2));
            double slope3 = ((y3 - y1) / (x3 - x1));

            if (slope1 == slope2 && slope1 == slope3) 
            {
                Console.WriteLine("points are collinear");
                return;
            }

            Console.WriteLine("points are not collinear");
        }

        public static void CollineraityCheckTri(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double temp = y1 - y2;
            double a = x1​ * (y2​ - y3​);
            double b = x2​ * (y3 - y1​);
            double c = x3 * temp;

            double area = 0.5 * (a + b + c);

            if(area == 0)
            {
                Console.WriteLine("points are collinear");
                return;
            }
            Console.WriteLine("Points are non collinear");

            
            
        }
        
        public static void main()
        {
            Console.WriteLine("Enter x and y coordinate of a point");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x and y coordinate of a point");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x and y coordinate of a point");
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());

            CollineraityCheck(x1,y1, x2, y2, x3, y3);
            CollineraityCheckTri(x1, y1, x2, y2, x3, y3);
        }
    }
}
