using System;
using System.Collections.Generic;
using System.Text;

namespace Oef11
{
    class Dot : Point
    {
        protected double radius;

        public Dot() : base(1,1)
        {
            radius = 5;
        }

        public Dot(double newRadius, int newX, int newY) : base(newX, newY)
        {
            radius = newRadius;
        }

        public string getArea()
        {
            string output;

            double area = radius * radius * Math.PI;

            output = "De oppervlakte van dit punt = " + Math.Round(area, 2);

            return output;
        }

        public override string getPoint()
        {
            return base.getPoint() + getArea();
        }
    }
}
