using System;

namespace FibonacciRecursief
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalElementen = 0;
            int temp1 = 0;
            int temp2 = 1;
            int temp3 = 0;

            Console.WriteLine("Geef in hoeveel elementen van de Rij van Fibonacci moeten weergegeven worden: ");
            aantalElementen = Convert.ToInt32(Console.ReadLine());

            string RijVanFibonacci(int n)
            {
                if (aantalElementen >= 1)
                {
                    temp3 = temp1;
                    temp1 += temp2;
                    temp2 = temp3;
                    return temp3 + " " + RijVanFibonacci(aantalElementen--);
                }
                else
                {
                    return "";
                }
            }

            Console.WriteLine(RijVanFibonacci(aantalElementen)); 

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
