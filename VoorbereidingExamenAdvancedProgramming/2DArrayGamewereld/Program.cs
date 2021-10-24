using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayGamewereld
{
    class Program
    {
        enum WereldVakjes
        {
            Berg, Water, Gras, Bos
        }
        static void Main(string[] args)
        {
            int height, width;
            Random rand = new Random();

            Console.WriteLine("Hoe groot moet je gamewereld zijn?");
            Console.WriteLine("Geef de breedte: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de hoogte: ");
            height = Convert.ToInt32(Console.ReadLine());

            WereldVakjes[,] gameWereld = new WereldVakjes[height, width];

            string input;
            FillWorld();
            ShowWorld();

            do
            {
                Console.WriteLine("Ben je tevreden met je wereld? (ja of nee) :");
                input = Console.ReadLine();

                if(input.ToUpper() == "JA")
                {
                    break;
                }else if(input.ToUpper() == "NEE")
                {
                    FillWorld();
                    ShowWorld();
                }
                else
                {
                    Console.WriteLine("Ongeldige input ...");
                }


            } while (input != "JA");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();


            void FillWorld()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (i == 0)
                        {
                            gameWereld[i, j] = WereldVakjes.Berg;
                        }
                        else if (i == height - 1)
                        {
                            gameWereld[i, j] = WereldVakjes.Berg;
                        }
                        else if (j == 0)
                        {
                            gameWereld[i, j] = WereldVakjes.Berg;
                        }
                        else if (j == width - 1)
                        {
                            gameWereld[i, j] = WereldVakjes.Berg;
                        }
                        else
                        {
                            gameWereld[i, j] = (WereldVakjes)rand.Next(4);
                        }
                    }
                }
            }

            void ShowWorld()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        switch (gameWereld[i, j])
                        {
                            case WereldVakjes.Berg: Console.Write("B ");
                                break;

                            case WereldVakjes.Water: Console.Write("~ ");
                                break;

                            case WereldVakjes.Gras: Console.Write("i ");
                                break;

                            case WereldVakjes.Bos: Console.Write("F ");
                                break;
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
