using System;
using System.Collections.Generic;
using System.Text;

namespace Oef13
{
    class CapsPrinter : Printer
    {
        private bool isCaps;

        public CapsPrinter(bool isItCaps)
        {
            isCaps = isItCaps;
        }

        public override void Print(string eenString)
        {
            if(isCaps == true)
            {
                base.Print(eenString.ToUpper());
            }
            else
            {
                base.Print(eenString.ToLower());
            }
            
        }
    }
}
