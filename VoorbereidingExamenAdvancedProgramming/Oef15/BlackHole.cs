using System;
using System.Collections.Generic;
using System.Text;

namespace Oef15
{
    class BlackHole : SkyElement
    {
        public override void Print()
        {
            ConsoleColor tempbg = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = tempbg;
        }
    }
}
