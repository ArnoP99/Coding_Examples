using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaces
{
    class Square : IShape
    {
        private double z;

        protected Square() { }
        public Square(double newZijde)
        {
            z = newZijde;
        }

        virtual public double Circumference
        {
            get
            {
                return Math.Round((z*4), 2);
            }
        }

        virtual public double Area
        {
            get
            {
                return Math.Round((z*z), 2);
            }
        }
    }
}
