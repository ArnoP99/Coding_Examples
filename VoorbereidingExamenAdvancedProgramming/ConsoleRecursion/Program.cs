using System;

namespace ConsoleRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Convert.ToInt32(args[0]) > 0 && (Convert.ToInt32(args[0])) % (Convert.ToInt32(args[0])) == 0)
            {
                Faculty();
                void Faculty()
                {
                    int num = Convert.ToInt32(args[0]);
                    int temp = num;
                    int total = num;
                    while (num > 1)
                    {
                        total = total * (num - 1);
                        num--;
                    }
                    Console.WriteLine("Faculteit van " + temp + " is " + total);
                }
            }
            else
            {
                Console.WriteLine("Console argument was geen positief getal!");
            }

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
