using System;

namespace Oef3
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticTest.Sum(1.5, 2.5);
            StaticTest.Sum(5, 6);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
