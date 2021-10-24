using System;

namespace Oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.TelOp(2, 5);
            Math.TrekAf(10, 4);
            Math.TrekAf(4, 10);
            Math.VermenigVuldig(5, 10);
            Math.Delen(10, 2);
            Math.Delen(2, 10);
            Math.RestBijDeling(15, 7);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
