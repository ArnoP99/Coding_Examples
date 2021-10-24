using System;
using System.Collections.Generic;
using System.Text;

namespace Oef13
{
    class TabPrinter : Printer
    {
        private int numTabs;

        public TabPrinter(int newNumTabs)
        {
            numTabs = newNumTabs;
        }
        public override void Print(string eenString)
        {
            for (int i = 0; i < numTabs; i++)
            {
                Console.Write(" ");
            }
            base.Print(eenString);
        }
    }
}
