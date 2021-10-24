using System;
using System.Collections.Generic;
using System.Text;

namespace Oef3
{
    class StaticTest
    {
        public static void Sum(double a, double b)
        {
            double c = a + b;

            Console.WriteLine("Uitkomst: " + c);
        }

        public static void Sum(int a, int b)
        {
            int c = a + b;

            Console.WriteLine("Uitkomst: " + c);
        }
    }
}
