using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            void AddupTo(int aantal)
            {
          
                int result = 0;
                Stopwatch sw = new Stopwatch();
                long swTemp = 0;
                double[] tempTimes = new double[aantal];
                sw.Start();
                for (int i = 0; i < aantal; i++)
                {                              
                    result = result + i;
                    Console.Write(result);
                    tempTimes[i] = Math.Round(Convert.ToDouble((Convert.ToDouble(sw.ElapsedTicks) - Convert.ToDouble(swTemp)) / 10000), 10);
                    swTemp = sw.ElapsedTicks;
                    Console.WriteLine(" //ms per berekening: " + tempTimes[i].ToString());
                    

                }
                Console.WriteLine("Totale tijd: " + Convert.ToDouble(Convert.ToDouble(sw.ElapsedTicks) / 10000));
                double totaleTijd = 0;
                for (int i = 0; i < aantal; i++)
                {
                    totaleTijd += tempTimes[i];
                }
                Console.WriteLine("Totale tijd volgens array: " + totaleTijd);
                sw.Stop();
            }

            AddupTo(100);

            Console.WriteLine("Press any key to continue ..." );
            Console.ReadKey();
        }
    }
}
