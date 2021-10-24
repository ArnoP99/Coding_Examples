using System;
using System.Collections.Generic;

namespace ShapeInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Rectangle(4, 8));
            shapes.Add(new Rectangle(3, 5));
            shapes.Add(new Triangle(4, 6));
            shapes.Add(new Triangle(7, 3));
            shapes.Add(new Circle(7));
            shapes.Add(new Circle(3));
            shapes.Add(new Square(4));
            shapes.Add(new Square(8));

            foreach (var shape in shapes)
            {
                Console.WriteLine("Opp: " + shape.Area);
                Console.WriteLine("Omtrek: " + shape.Circumference);
            }

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
