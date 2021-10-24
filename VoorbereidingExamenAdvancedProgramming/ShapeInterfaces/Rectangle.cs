using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaces
{
    class Rectangle : Square
    {
        private double h;
        private double w;

        public Rectangle(double newHeight, double newWidth)
        {
            h = newHeight;
            w = newWidth;
        }

        public override double Circumference
        {
            get
            {
                return Math.Round((h + h + w + w), 2);
            }
        }

        public override double Area
        {
            get
            {
                return Math.Round((w * h), 2);
            }
        }
    }
}
