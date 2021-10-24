using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLambdaExpression
{
    class Program
    {
        static Object consoleLock = new Object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => Print("A", ConsoleColor.Red));
            Thread t2 = new Thread(() => Print("B", ConsoleColor.Green));
            Thread t3 = new Thread(() => Print("C", ConsoleColor.Blue));
            Thread t4 = new Thread(() => Print("D", ConsoleColor.Yellow));
            Thread t5 = new Thread(() => Print("E", ConsoleColor.Magenta));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }

        static void Print(string letter, ConsoleColor color)
        {

            for (int i = 1; i <= 100; i++)
            {
                lock (consoleLock)
                {
                    Console.ForegroundColor = color;
                    Console.Write(letter);
                    Console.Write(i);
                    Console.WriteLine();
                }
            }
        }
    }
}
