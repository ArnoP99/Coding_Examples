using System;

namespace Oef15
{
    class Program
    {
        static void Main(string[] args)
        {
            NightSky nightSky = new NightSky(30);

            nightSky.Print();

            while (true)
            {
                nightSky.Move();
                Console.Clear();
                nightSky.Print();
                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

    }
}
