using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaces
{
    class Triangle : IShape
    {
        private double h;
        private double w;

        public Triangle(double newHeight, double newWidth)
        {
            h = newHeight;
            w = newWidth;
        }
        public double Circumference
        {
            get
            {
                return Math.Round(((Math.Sqrt(Math.Pow(h, 2) + Math.Pow(w / 2, 2))) * 2 + w), 2);
            }
        }

        public double Area
        {
            get
            {
                return Math.Round(((w * h) / 2), 2);
            }
        }
    }
}
