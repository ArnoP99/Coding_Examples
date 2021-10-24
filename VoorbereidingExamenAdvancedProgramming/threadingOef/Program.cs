using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadingOef
{
    class Program
    {

        static Object consoleLock = new Object();
        static void Main(string[] args)
        {

           
            Thread tA = new Thread(new ThreadStart(writeA));
            Thread tB = new Thread( () => writeB(tA));

            tA.Start();
           
            tB.Start();

            
            tB.Join();

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }

        static void writeA()
        {

            for (int i = 1; i <= 100; i++)
            {
                lock (consoleLock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("A");
                    Console.Write(".");
                    Console.Write(i);
                    Console.WriteLine();
                }
            }
        }

        static void writeB(Thread waitForMe)
        {
            if(waitForMe != null)
            {
                waitForMe.Join();
            }

            for (int i = 1; i <= 100; i++)
            {
                lock (consoleLock)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("B");
                    Console.Write(".");
                    Console.Write(i);
                    Console.WriteLine();
                }
            }

        }
    }
}
