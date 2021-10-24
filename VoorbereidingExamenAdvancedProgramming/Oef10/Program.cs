using System;
using System.Diagnostics;

namespace Oef10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Animal[,] animals = new Animal[5, 5];
            Random randomNum = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int num = randomNum.Next(0, 3);

                    switch (num)
                    {
                        case 0:
                            animals[i, j] = new Animal();
                            break;

                        case 1:
                            animals[i, j] = new Fish();
                            break;

                        case 2:
                            animals[i, j] = new Dog();
                            break;

                        default:
                            Console.WriteLine("Wrong input!!");
                            break;
                    }

                }
            }

            foreach (Animal item in animals)
            {
                Console.WriteLine(item.GetText());
            }

            long sum = 0;
            for (int i = 0; i < 200000; i++)
            {
                 sum += i;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
