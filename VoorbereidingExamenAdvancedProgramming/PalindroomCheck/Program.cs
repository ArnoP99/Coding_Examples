using System;

namespace PalindroomCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomString;

            Console.WriteLine("Geef een willekeurige string in die gecontroleerd moet worden of het een palindroom is: ");
            randomString = Console.ReadLine();

            string IsPalindroom(string s)
            {
                if (s.Length > 1)
                {
                    if (s[0] == s[s.Length - 1])
                    {
                        return IsPalindroom(s.Substring(1, s.Length - 2));
                    }
                    else
                    {
                        return "Ingegeven string is GEEN palindroom.";
                    }
                }
                else
                {
                    return "Ingegeven string is WEL een palindroom.";
                }
            }

            Console.WriteLine(IsPalindroom(randomString));

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
