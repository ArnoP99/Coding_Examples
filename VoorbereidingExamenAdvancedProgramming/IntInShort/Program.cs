using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntInShort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                short testVar = Convert.ToInt16(int.MaxValue);
            }catch(Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.ToString());
            }

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
