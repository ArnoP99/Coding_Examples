using System;
using System.Collections.Generic;
using System.Text;

namespace Oef10
{
    class Animal
    {
        protected int numLegs;

        protected bool hasLungs;

        public Animal()
        {
            numLegs = 4;
            hasLungs = true;
        }
        public Animal(int newNumLegs, bool newHasLungs)
        {
            numLegs = newNumLegs;
            hasLungs = newHasLungs;
        }

        public virtual string GetText()
        {
            string outputText;

            if (hasLungs == true)
            {
                outputText = "Animal with " + numLegs + " paws and lungs.";
            }
            else
            {
                outputText = "Animal with " + numLegs + " paws and no lungs.";
            }

            return outputText;
        }

        public int NumLegs
        {
            get
            {
                return numLegs;
            }
            set
            {
                numLegs = value;
            }
        }

        public bool HasLungs
        {
            get
            {
                return hasLungs;
            }
            set
            {
                hasLungs = value;
            }
        }
    }
}
