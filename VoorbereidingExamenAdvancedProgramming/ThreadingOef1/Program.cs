using System;
using System.Threading;

namespace ThreadingOef1
{
    class Program
    {
        static void Main(string[] args)
        {
            Object consoleLock = new Object();
            Thread t1 = new Thread(new ThreadStart(WriteA));
            Thread t2 = new Thread(new ThreadStart(WriteB));
            void WriteA()
            {
                for (int i = 1; i <= 1000; i++)
                {
                    lock (consoleLock)
                    {
                        Console.Write("A");
                        Console.Write("-");
                        Console.Write(i);
                        Console.WriteLine();
                    }
                }
            }

            void WriteB()
            {


                for (int i = 1; i <= 1000; i++)
                {
                    lock (consoleLock)
                    {
                        Console.Write("B");
                        Console.Write("-");
                        Console.Write(i);
                        Console.WriteLine();
                    }
                }

            }


            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
