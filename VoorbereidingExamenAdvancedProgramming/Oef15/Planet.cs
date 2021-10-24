using System;
using System.Collections.Generic;
using System.Text;

namespace Oef15
{
    class Planet : SkyElement
    {
        private ConsoleColor color;
        public Planet(ConsoleColor newColor)
        {
            color = newColor;
        }

        public override void Print()
        {
            ConsoleColor tempfg = Console.ForegroundColor;
            ConsoleColor tempbg = Console.BackgroundColor;
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("O");
            Console.ForegroundColor = tempfg;
            Console.BackgroundColor = tempbg;
        }
    }
}
