using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                String fileName = args[0];
                String original = args[1];
                String toReplace = args[2];

                StreamReader reader = null;
                StreamWriter writer = null;

                reader = File.OpenText(fileName);
                string text = reader.ReadToEnd();

                Console.WriteLine(text);
                text = text.Replace(original, toReplace);
                File.WriteAllText("orignalFileREPLACED.txt", text);


                Console.WriteLine("Aantal elementen dat vervangen werdt {0:X}", (Regex.Matches(text, toReplace).Count));
                Console.WriteLine("Druk op een toets om door te gaan.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Niet genoeg of te veel argumenten meegegeven.");
            }
        }
    }
}
