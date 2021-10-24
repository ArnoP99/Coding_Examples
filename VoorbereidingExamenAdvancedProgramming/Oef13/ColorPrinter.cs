using System;
using System.Collections.Generic;
using System.Text;

namespace Oef13
{
    class ColorPrinter : Printer
    {
        private ConsoleColor fgColor;
        private ConsoleColor bgColor;

        public ColorPrinter(ConsoleColor newFgColor, ConsoleColor newBgColor)
        {
            fgColor = newFgColor;
            bgColor = newBgColor;
        }

        public override void Print(string eenString)
        {
            ConsoleColor tempFg = Console.ForegroundColor;
            ConsoleColor tempBg = Console.BackgroundColor;
            Console.ForegroundColor = fgColor;
            Console.BackgroundColor = bgColor;

            base.Print(eenString);

            Console.ForegroundColor = tempFg;
            Console.BackgroundColor = tempBg;
        }
    }
}
