using System;
using System.Collections.Generic;
using System.Text;

namespace Oef12
{
    class CD : Article
    {
        protected int numSongs;
        public static int numAvailableCD = 0;

        public CD(string newTitle, double newPrice, int newNumSongs) : base(newTitle, newPrice)
        {
            numAvailableCD++;
            numSongs = newNumSongs;
        }

        public override string GetText()
        {
            return "Type: CD, aantal nummers: " + numSongs + ", " + base.GetText();
        }

    }
}
