using System;
using System.Collections.Generic;
using System.Text;

namespace Oef12
{
    class DVD : Article
    {
        public static int numAvailableDVD = 0;
        public DVD(string newTitle, double newPrice) : base(newTitle, newPrice)
        {
            numAvailableDVD++;
        }

        public override string GetText()
        {
            return "Type: DVD, " + base.GetText();
        }
    }
}
