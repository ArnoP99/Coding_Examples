using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTalkInterface
{
    class Cat : IAnimalTalk, ILeggedAnimal
    {
        public string Text
        {
            get
            {
                return "Miauw";
            }
        }

        public int NumLegs
        {
            get
            {
                return 4;
            }
        }

        public void WriteLegs()
        {
            Console.WriteLine("Cat has " + NumLegs + " legs.");
        }

        public void Speak()
        {
            Console.WriteLine("Cat says " + Text);
        }
    }
}
