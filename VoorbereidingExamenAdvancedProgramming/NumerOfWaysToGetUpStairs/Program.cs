using System;

namespace NumberOfWaysToGetUpStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalTreden = 0;

            Console.WriteLine("Uit hoeveel treden bestaat de trap?: ");
            aantalTreden = Convert.ToInt32(Console.ReadLine());

            int Fibonacci(int n)
            {
                if (n <= 1)
                    return n;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            int AantalManieren(int s)
            {
                return Fibonacci(s + 1);
            }

            Console.WriteLine("Aantal manieren: " + AantalManieren(aantalTreden));

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();

        }
    }
}
