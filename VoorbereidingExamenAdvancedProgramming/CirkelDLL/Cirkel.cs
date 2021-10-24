using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkelDLL
{
    public class Cirkel
    {
        private int position;

        private double radius;

        private static int numCirkels = 0;

        public Cirkel(int newPosition, int newRadius)
        {
            position = newPosition;
            radius = newRadius;
            numCirkels++;
        }

        public static void BerekenOmtrek(double radius)
        {
            double temp = Math.PI * 2 * radius;
            Console.WriteLine("De omtrek van de cirkel is: " + temp);
        }

        public static void BerekenOppervlakte(double radius)
        {
            double temp = Math.PI * radius * radius;
            Console.WriteLine("De oppervlakte van de cirkel is: " + temp);
        }

        public double Omtrek
        {
            get
            {
                return Math.PI * 2 * radius;
            }
        }

        public double Oppervlakte
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }
    }
}
