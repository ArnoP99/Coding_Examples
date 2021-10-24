using System;
using System.Collections.Generic;
using System.Text;

namespace Oef10
{
    class Dog : Animal
    {
        protected bool hasLongHair;

        public Dog(bool newHasLongHair, int newNumLegs)
        {
            hasLongHair = newHasLongHair;
            numLegs = newNumLegs;
            hasLungs = true;
        }
        public Dog()
        {
            hasLongHair = false;
        }
        public override string GetText()
        {
            string outputText;

            if (hasLongHair == true)
            {
                outputText = base.GetText() + " Barking dog with long hair.";
            }
            else
            {
                outputText = base.GetText() + " Barking dog with short hair.";
            }

            return outputText;
        }
    }
}
