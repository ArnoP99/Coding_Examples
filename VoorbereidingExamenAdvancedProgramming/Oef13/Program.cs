using System;
using System.Collections.Generic;

namespace Oef13
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Printer> printers = new List<Printer>();

            TabPrinter tabPrinter1 = new TabPrinter(8);
            TabPrinter tabPrinter2 = new TabPrinter(12);
            TabPrinter tabPrinter3 = new TabPrinter(3);
            TabPrinter tabPrinter4 = new TabPrinter(7);

            CapsPrinter capsPrinter1 = new CapsPrinter(true);
            CapsPrinter capsPrinter2 = new CapsPrinter(false);

            ColorPrinter colorPrinter1 = new ColorPrinter(ConsoleColor.Red, ConsoleColor.Green);
            ColorPrinter colorPrinter2 = new ColorPrinter(ConsoleColor.Blue, ConsoleColor.Yellow);

            CapsColorPrinter capsColorPrinter = new CapsColorPrinter(ConsoleColor.Cyan, ConsoleColor.Red);

            printers.Add(tabPrinter1);
            printers.Add(tabPrinter2);
            printers.Add(tabPrinter3);

            printers.Add(capsPrinter1);
            printers.Add(capsPrinter2);

            printers.Add(colorPrinter1);
            printers.Add(colorPrinter2);

            printers.Add(capsColorPrinter);

            printers.Add(tabPrinter4);

            foreach (var printer in printers)
            {
                printer.Print("Test test");
            }
            Console.ReadKey();
        }
    }
}
