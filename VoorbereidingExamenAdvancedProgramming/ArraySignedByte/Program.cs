using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySignedByte
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] byteValues = new short[sbyte.MaxValue * 2 + 2];

            for (int i = sbyte.MinValue, j = 0; i <= sbyte.MaxValue; i++, j++) // waarom int i???
            {
                byteValues[j] = (sbyte)i;
            }

            for (int i = 0; i < byteValues.GetLength(0); i++) // waarom int i???
            {
                Console.Write(byteValues[i] + "  ");
            }
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
