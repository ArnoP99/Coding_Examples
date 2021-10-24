using System;
using System.Collections.Generic;
using System.Text;

namespace Oef15
{
    class Star : SkyElement
    {
        public override void Print()
        {
            ConsoleColor tempfg = Console.ForegroundColor;
            ConsoleColor tempbg = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("*");
            Console.ForegroundColor = tempfg;
            Console.BackgroundColor = tempbg;
        }
    }
}
