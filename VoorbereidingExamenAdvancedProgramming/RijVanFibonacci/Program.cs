using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RijVanFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 2;
            if (args.Length == 1 && Convert.ToInt32(args[0]) > 0)
            {
                int aantalGetallen = Convert.ToInt32(args[0]);
                int a = 0, b = 1, c = 0;

                Console.Write(c + "\t");
                Console.Write(c + 1 + "\t");
                for (int i = 0; i < aantalGetallen - 2; i++)
                {
                    if (counter == 4)
                    {
                        Console.WriteLine();
                        counter = 0;
                    }

                    c = a + b;

                    Console.Write(c + "\t");

                    a = b;
                    b = c;
                    counter++;
                }
                Console.WriteLine();
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("Geen argumenten meegegeven.");
            }
            else
            {
                Console.WriteLine("Argument moet een positieve int zijn en groter zijn dan 0.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
