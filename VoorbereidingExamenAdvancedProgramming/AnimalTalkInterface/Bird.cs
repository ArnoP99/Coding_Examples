using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTalkInterface
{
    class Bird : IAnimalTalk, ILeggedAnimal
    {
        public string Text
        {
            get
            {
                return "Tsjirp Tsjirp";
            }
        }

        public void Speak()
        {
            Console.WriteLine("Bird says " + Text);
        }

        public int NumLegs
        {
            get
            {
                return 2;
            }
        }

        public void WriteLegs()
        {
            Console.WriteLine("Bird has " + NumLegs + " legs.");
        }
    }
}
