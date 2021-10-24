using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaces
{
    class Circle : IShape
    {
        private double r;

        public Circle(double newRadius)
        {
            r = newRadius;
        }

        public double Circumference
        {
            get
            {
                return Math.Round((2*r*Math.PI), 2);
            }
        }

        public double Area
        {
            get
            {
                return Math.Round((r*r*Math.PI), 2);
            }
        }
    }
}
