using System;
using System.Collections.Generic;
using System.Text;

namespace Oef13
{
    class CapsColorPrinter : ColorPrinter
    {
        public CapsColorPrinter(ConsoleColor newFgColor, ConsoleColor newBgColor) : base(newFgColor, newBgColor)
        {

        }

        public override void Print(string eenString)
        {
            base.Print(eenString.ToUpper());  
        }
    }
}
