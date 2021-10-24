using System;
using System.Collections.Generic;
using System.Text;

namespace Oef1
{
    class Dog : Animal
    {
        protected bool hasLongHair;

        private static int numDogs = 0;

        public Dog(bool newHasLongHair, int newNumLegs)
        {
            hasLongHair = newHasLongHair;
            numLegs = newNumLegs;
            hasLungs = true;
            numDogs++;
        }
        public Dog()
        {
            hasLongHair = false;
            numDogs++;
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

        public static int NumDogs
        {
            get
            {
                return numDogs;
            }
        }
    }
}
