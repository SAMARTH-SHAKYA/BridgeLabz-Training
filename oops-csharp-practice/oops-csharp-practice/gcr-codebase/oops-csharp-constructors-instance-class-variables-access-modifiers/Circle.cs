using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class Circle
    {
        double Radius;

        // contructor chaining
        public Circle() : this(1.0)
        {

        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
    }
}
