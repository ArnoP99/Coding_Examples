using System;
using System.Collections.Generic;
using System.Text;

namespace Oef2
{
    class Math
    {

        public static void TelOp(int a, int b)
        {
            int c = a + b;

            Console.WriteLine("Uitkomst Telop: " + c);
        }

        public static void TrekAf(int a, int b)
        {
            int c = 0;
            if (a > b)
            {
                c = a - b;
                Console.WriteLine("Uitkomst TrekAf: " + c);
            }
            else
            {
                c = b - a;
                Console.WriteLine("Uitkomst TrekAf: " + c);
            }
        }

        public static void VermenigVuldig(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Uitkomst Vermenigvuldig: " + c);
        }

        public static void Delen(int a, int b)
        {
            int c = 0;
            if (a > b)
            {
                c = a / b;
                Console.WriteLine("Uitkomst TrekAf: " + c);
            }
            else
            {
                c = b / a;
                Console.WriteLine("Uitkomst TrekAf: " + c);
            }
        }

        public static void RestBijDeling(int a, int b)
        {
            int c = a % b;
            Console.WriteLine("Uitkomst RestBijDeling: " + c);
        }
    }
}
