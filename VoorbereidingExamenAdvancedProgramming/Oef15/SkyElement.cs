using System;
using System.Collections.Generic;
using System.Text;

namespace Oef15
{
    class SkyElement
    {
        public virtual void Print()
        {
            ConsoleColor tempbg = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" ");
            Console.BackgroundColor = tempbg;
        }
    }
}
