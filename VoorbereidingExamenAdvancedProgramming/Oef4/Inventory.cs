using System;
using System.Collections.Generic;
using System.Text;

namespace Oef4
{
    class Inventory
    {
        private static List<String> stringList = new List<String>();

        public static void AddElement(string s)
        {
            stringList.Add(s);
        }

        public static void RemoveElement(string s)
        {
            stringList.Remove(s);
        }

        public static void ElementCount()
        {
            Console.WriteLine("Aantal elementen in lijst: " + stringList.Count);
        }

        public static void RemoveAll()
        {
            stringList.Clear();
        }

        public static void ShowElementByIndex(int i)
        {
            try
            {
                if (stringList[i] != null)
                {
                    Console.WriteLine("Element at index " + i + ": " + stringList[i]);
                }
            }
            catch 
            {
                Console.WriteLine("Element at index " + i + " doesn't exist: -1");
            }
        }

        public static void ShowAll()
        {
            Console.WriteLine("Alle elementen in lijst: ");
            foreach (var s in stringList)
            {
                Console.WriteLine(s);
            }
        }

        public static void ElementExist(string s)
        {
            Console.WriteLine("Index of element: " + stringList.IndexOf(s));
        }
    }
}
