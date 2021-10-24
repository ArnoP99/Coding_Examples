using System;
using System.Collections.Generic;

namespace AnimalTalkInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimalTalk> animals = new List<IAnimalTalk>();
            animals.Add(new Cat());
            animals.Add(new Bird());

            foreach (var anim in animals)
            {
                anim.Speak();
                ((ILeggedAnimal)anim).WriteLegs();
            }

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
