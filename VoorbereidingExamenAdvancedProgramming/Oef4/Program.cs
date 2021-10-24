using System;

namespace Oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.AddElement("Boek");
            Inventory.AddElement("Schoen");
            Inventory.AddElement("Tafel");
            Inventory.AddElement("Stoel");
            Inventory.AddElement("Bank");

            Inventory.ElementCount();

            Inventory.ShowAll();

            Inventory.RemoveElement("Boek");

            Inventory.ShowAll();

            Inventory.ShowElementByIndex(2);
            Inventory.ShowElementByIndex(8);

            Inventory.ElementExist("Stoel");
            Inventory.ElementExist("Boek");

            Inventory.RemoveAll();

            Inventory.ShowAll();

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
