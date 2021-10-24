using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldExamen2DLL
{
    public struct DoosData
    {
        private string naam;
        private string vanKamer;
        private string naarKamer;
        private byte gewicht;

        public DoosData(string newNaam, string newVanKamer, string newNaarKamer, byte newGewicht)
        {
            naam = newNaam;
            vanKamer = newVanKamer;
            naarKamer = newNaarKamer;
            gewicht = newGewicht;
        }

        public override string ToString()
        {
            string output = naam + "/" + vanKamer + "/" + naarKamer + "/" + gewicht + "//";
            return output;
        }

        public static DoosData operator +(DoosData doos1, DoosData doos2)
        {
            doos1.naam = doos1.naam + "_" + doos2.naam;
            doos1.vanKamer = doos1.vanKamer + "_" + doos2.vanKamer;
            doos1.naarKamer = doos1.naarKamer + "_" + doos2.naarKamer;

            if (doos1.gewicht + doos2.gewicht > 255)
            {
                Console.WriteLine("Gewicht overschrijdt de maximum waarde.");
                doos1.Gewicht = 255;
            }
            else
            {
                doos1.gewicht += doos2.gewicht;
            }

            return doos1;
        }

        public string Naam
        {
            get
            {
                return naam;
            }
            set
            {
                naam = value;
            }
        }

        public string VanKamer
        {
            get
            {
                return vanKamer;
            }
            set
            {
                vanKamer = value;
            }
        }

        public string NaarKamer
        {
            get
            {
                return naarKamer;
            }
            set
            {
                naarKamer = value;
            }
        }

        public byte Gewicht
        {
            get
            {
                return gewicht;
            }
            set
            {
                if (value > 255)
                {
                    Console.WriteLine("Gewicht kan niet groter zijn dan 255");
                }
                else
                {
                    gewicht = value;
                }
            }
        }
    }
    public class Verhuis
    {
        public static DoosData FromString(string doosInput)
        {
            DoosData nieuweDoos = new DoosData();

            try
            {
                nieuweDoos.Naam = doosInput.Substring(0, doosInput.IndexOf("/"));
                nieuweDoos.VanKamer = doosInput.Substring((doosInput.IndexOf("/") +1), 6);
                nieuweDoos.Gewicht = Convert.ToByte(doosInput.Substring(doosInput.IndexOf("/") + 15, ((doosInput.LastIndexOf("/") - 1) - (doosInput.IndexOf("/") + 15))));
                nieuweDoos.NaarKamer = doosInput.Substring(doosInput.IndexOf("/") + 8, 6);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Er ging iets fout bij het omzetten naar een string van de doos.");
                Console.WriteLine("Exception output: " + ex.ToString());
            }
            return nieuweDoos;
        }
    }
}
