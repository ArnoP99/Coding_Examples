using System;
using System.Collections.Generic;
using System.Text;

namespace Oef10
{
    class Fish : Animal
    {
        protected ConsoleColor colorFish;

        public Fish()
        {
            numLegs = 0;
            hasLungs = false;
            colorFish = ConsoleColor.Black;
        }
        public Fish(ConsoleColor newColorFish)
        {
            numLegs = 0;
            hasLungs = false;
            colorFish = newColorFish;
        }

        public override string GetText()
        {
            string outputText;

            outputText = "Fish with no paws and no lungs. Its color is " + colorFish + ".";

            return outputText;
        }
    }
}
