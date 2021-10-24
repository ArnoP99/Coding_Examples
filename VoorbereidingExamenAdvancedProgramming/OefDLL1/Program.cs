using System;
using CirkelDLL;

namespace OefDLL1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Cirkel cirkel = new Cirkel(i, i);
                Console.WriteLine("Omtrek cirkel: " + cirkel.Omtrek); 
                Console.WriteLine("Oppervlakte cirkel: " + cirkel.Oppervlakte); 
            }

            Cirkel.BerekenOmtrek(8);
            Cirkel.BerekenOppervlakte(10);

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
