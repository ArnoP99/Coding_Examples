using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VoorbeeldExamen2DLL;

namespace VoorbeeldExamen2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3 || Convert.ToInt32(args[2]) < 0)
            {
                Console.WriteLine("\"Verkeerd aantal commando argumenten meegegeven of 3de argument is geen positief getal.\"");
            }
            else
            {
                object safetyLock = new object();

                Thread thread = new Thread(() => PrintStarLine(Convert.ToByte(args[2])));
                thread.Priority = ThreadPriority.Highest;
                thread.Start();

                List<DoosData> verhuisDozen = new List<DoosData>();
                List<DoosData> verhuisDozen2 = new List<DoosData>();

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + args[0] + ".txt";

                GenereerDozenRec(Convert.ToByte(args[2]), verhuisDozen);

                SchrijfDoosLijst(verhuisDozen);

                if ((writeListToFile(verhuisDozen, filePath) == verhuisDozen.Count))
                {
                    Console.WriteLine("Het wegschrijven van de data is geslaagd.");
                }
                else
                {
                    Console.WriteLine("Aantal dozen dat is weggeschreven komt niet overeen met het aantal dozen in de lijst!");
                }

                if (ReadListFromFile(verhuisDozen2, filePath) == verhuisDozen.Count)
                {
                    Console.WriteLine("Het inlezen van de data is geslaagd.");
                    SchrijfDoosLijst(verhuisDozen2);
                }
                else
                {
                    Console.WriteLine("Aantal dozen dat is ingelezen komt niet overeen met het aantal dozen in de lijst!");
                }

                thread.Abort();

                LaadDozen(verhuisDozen);


                int ReadListFromFile(List<DoosData> dozenLijst, string fileName)
                {
                    lock (safetyLock)
                    {
                        StreamReader reader = null;
                        int numberOfElements = 0;

                        try
                        {
                            reader = File.OpenText(fileName);

                            numberOfElements = 0;

                            string line;

                            reader.ReadLine();
                            line = reader.ReadLine();

                            while (line != null)
                            {
                                DoosData tempDoos = Verhuis.FromString(line);
                                dozenLijst.Add(tempDoos);
                                line = reader.ReadLine();
                                numberOfElements++;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Something went wrong while trying to read input.");
                            Console.WriteLine("Exception output: " + ex.ToString());
                        }
                        return numberOfElements;
                    }
                }

                DoosData LaadDozen(List<DoosData> dozenLijst)
                {
                    DoosData groteDoos = new DoosData("GroteDoos", null, null, 0);

                    foreach (var doos in dozenLijst)
                    {
                        groteDoos += doos;
                    }

                    Console.WriteLine("Dit is de lading van de vrachtwagen:");
                    Console.WriteLine("Dozen: " + groteDoos.Naam);
                    Console.WriteLine("Gewicht: " + groteDoos.Gewicht);

                    return groteDoos;
                }

                void PrintStarLine(byte aantalSterren)
                {
                    while (true)
                    {
                        lock (safetyLock)
                        {
                            for (int i = 0; i < aantalSterren; i++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                            Thread.Sleep(5);
                        }
                    }
                }

                void SchrijfDoosLijst(List<DoosData> dozenLijst)
                {
                    foreach (var doos in dozenLijst)
                    {
                        Console.WriteLine(doos.ToString());
                    }
                }

                int writeListToFile(List<DoosData> dozenlijst, string fileName)
                {
                    lock (safetyLock)
                    {
                        int counter = 0;
                        try
                        {
                            StreamWriter writer = null;

                            writer = File.CreateText(fileName);

                            writer.Write(dozenlijst.Count + "\n");
                            foreach (var doos in dozenlijst)
                            {
                                writer.WriteLine(doos.ToString());
                                counter++;
                            }
                            writer.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Something went wrong when trying to write list to file.");
                            Console.WriteLine("Exception output: " + ex);
                        }

                        return counter;
                    }
                }

                void GenereerDozenRec(byte aantalDozen, List<DoosData> dozenLijst)
                {
                    if (aantalDozen == 0)
                    {
                        verhuisDozen.OrderByDescending(x => x.Naam).ToList();
                        verhuisDozen.Reverse();
                    }
                    else if (aantalDozen % 2 == 0)
                    {
                        DoosData newDoos = new DoosData("Doos" + aantalDozen, "kamer1", "nieuw1", Convert.ToByte(20 - aantalDozen));
                        verhuisDozen.Add(newDoos);
                        GenereerDozenRec(Convert.ToByte(aantalDozen - 1), dozenLijst);
                    }
                    else if (aantalDozen % 2 == 1)
                    {
                        DoosData newDoos = new DoosData("Doos" + aantalDozen, "kamer2", "nieuw2", Convert.ToByte(5 * aantalDozen));
                        verhuisDozen.Add(newDoos);
                        GenereerDozenRec(Convert.ToByte(aantalDozen - 1), dozenLijst);
                    }
                }
            }

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
