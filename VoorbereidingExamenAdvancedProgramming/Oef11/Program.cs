using System;
using System.Collections.Generic;

namespace Oef11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dot> dots = new List<Dot>();

            Dot dot1 = new Dot(4.5, 5,5);
            Dot dot2 = new Dot(3,4,3);
            Dot dot3 = new Dot(2, 1, 4);

            dots.Add(dot1);
            dots.Add(dot2);
            dots.Add(dot3);

            foreach (var dot in dots)
            {
                Console.WriteLine(dot.getPoint());
            }

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
