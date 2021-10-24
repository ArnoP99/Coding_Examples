using System;
using System.Collections.Generic;
using System.Text;

namespace Oef15
{
    enum CometDirection
    {
        Horizontal, Vertical, LeftDown, RightDown
    }
    class Comet : SkyElement
    {
        CometDirection cometDirection;

        public Comet(CometDirection newCometDirection)
        {
            cometDirection = newCometDirection;
        }

        public override void Print()
        {
            ConsoleColor tempfg = Console.ForegroundColor;
            ConsoleColor tempbg = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            if(cometDirection == CometDirection.Horizontal)
            {
                Console.Write("-");
            } else if (cometDirection == CometDirection.Vertical)
            {
                Console.Write("|");
            } else if (cometDirection == CometDirection.LeftDown)
            {
                Console.Write("\\");
            }else if(cometDirection == CometDirection.RightDown)
            {
                Console.Write("/");
            }
            Console.ForegroundColor = tempfg;
            Console.BackgroundColor = tempbg;
        }
    }
}
