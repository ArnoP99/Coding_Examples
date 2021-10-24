using System;

namespace StringOmkeren
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomString;

            Console.WriteLine("Geef een willekeurige string in: ");
            randomString = Console.ReadLine();

            string StringOmkeren(string s)
            {
                if(s.Length > 0)
                {
                    return s[s.Length - 1] + StringOmkeren(s.Remove(s.Length-1, 1));
                }
                else
                {
                    return s;
                }
            }

            Console.WriteLine(StringOmkeren(randomString)); 

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
