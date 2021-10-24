using System;

namespace Machtsverheffing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("Geef een getal x in: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geef een getal y als macht voor x in: ");
            y = Convert.ToInt32(Console.ReadLine());

            int macht(int a, int b)
            {
                if (b == 1)
                {
                    return a;
                }
                else
                {
                    return (a * (macht(a, b-1)));
                }
            }

            Console.WriteLine(macht(x,y));

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
