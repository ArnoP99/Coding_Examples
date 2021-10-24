using System;
using System.Collections.Generic;
using System.Text;

namespace Oef1
{
    class Fish : Animal
    {
        protected ConsoleColor colorFish;
        private static int numFish = 0;

        public Fish()
        {
            numLegs = 0;
            hasLungs = false;
            colorFish = ConsoleColor.Black;
            numFish++;
        }
        public Fish(ConsoleColor newColorFish)
        {
            numLegs = 0;
            hasLungs = false;
            colorFish = newColorFish;
            numFish++;
        }

        public override string GetText()
        {
            string outputText;

            outputText = "Fish with no paws and no lungs. Its color is " + colorFish + ".";

            return outputText;
        }

        public static int NumFish
        {
            get
            {
                return numFish;
            }
        }
    }
}
