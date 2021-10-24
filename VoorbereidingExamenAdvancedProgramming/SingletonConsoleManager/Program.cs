using System;
using System.Threading;

namespace SingletonConsoleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            ThreadStarter1 ts1 = new ThreadStarter1();
            ThreadStarter2 ts2 = new ThreadStarter2(100);
            ts1.Start();
            ts2.Start();

            bool stopLoop = false;
            while (!stopLoop)
            {
                Thread.Sleep(20);
                switch (Console.ReadKey().KeyChar)
                {
                    case 'n':
                        {
                            ts2.FlipPause();
                            break;
                        }
                    case 'a':
                        {
                            ts1.FlipPause();
                            break;
                        }
                    case 'p':
                        {
                            ts1.FlipPause();
                            ts2.FlipPause();
                            break;
                        }
                    case 's':
                        {
                            ts2.Stop();
                            ts1.Stop();
                            stopLoop = true;
                            break;
                        }
                }

            }
            Console.WriteLine("Press any key to quit..");
            Console.ReadKey();
        }
    }
}
