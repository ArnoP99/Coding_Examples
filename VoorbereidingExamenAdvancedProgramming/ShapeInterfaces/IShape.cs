using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaces
{
    interface IShape
    {
        double Circumference { get; }

        double Area { get; }
    }
}
