using System;

namespace Oef1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal anim1 = new Animal();
            Animal anim2 = new Animal();

            Fish fish = new Fish();

            Dog dog = new Dog();

            Console.WriteLine("Number of Animals: " + Animal.NumAnimals);
            Console.WriteLine("Number of Dogs: " + Dog.NumDogs);
            Console.WriteLine("Number of Fish: " + Fish.NumFish);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
