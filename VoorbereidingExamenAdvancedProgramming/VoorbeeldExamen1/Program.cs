using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoorbeeldExamen1DLL;
using System.IO;
using System.Threading;

namespace VoorbeeldExamen1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0].ElementAt(0) + args[1];
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName;

            ushort numberOfPlayers = Convert.ToUInt16(args[0].Length + args[1].Length);

            Thread thread2 = new Thread(() => GenerateRandomScene(args[0].Length, args[1].Length, filePath));
            thread2.Start();
            thread2.Join();

            GameSettings game = new GameSettings(numberOfPlayers, filePath);

            game.Show();

            Thread thread1 = new Thread(() => IsPrimeNumber(numberOfPlayers, numberOfPlayers / 2));
            thread1.Start();

            Console.WriteLine();
            if (game.CheckScene())
            {
                Console.WriteLine("The scene contains every tiletype that exists");
            }
            else
            {
                Console.WriteLine("The scene does not contain every tiletype that exists");
            }

            thread1.Join();
            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();

            void IsPrimeNumber(int numberToCheck, int halfOfNumberToCheck)
            {
                if (halfOfNumberToCheck == 1)
                {
                    Console.WriteLine("PriemCheck: " + numberToCheck + " % " + halfOfNumberToCheck + " = " + numberToCheck % halfOfNumberToCheck);
                    Console.WriteLine(numberToCheck + " IS A PRIME");
                }
                else
                {
                    if (numberToCheck % halfOfNumberToCheck == 0)
                    {
                        Console.WriteLine("PriemCheck: " + numberToCheck + " % " + halfOfNumberToCheck + " = " + numberToCheck % halfOfNumberToCheck);
                        Console.WriteLine(numberToCheck + " IS NOT A PRIME");
                    }
                    else
                    {
                        Console.WriteLine("PriemCheck: " + numberToCheck + " % " + halfOfNumberToCheck + " = " + numberToCheck % halfOfNumberToCheck);
                        IsPrimeNumber(numberToCheck, halfOfNumberToCheck - 1);
                    }
                }
            }

            void GenerateRandomScene(int newWidth, int newHeight, string newFilePath)
            {
                TileTypes[,] newScene = new TileTypes[newHeight, newWidth];
                Random random = new Random();

                for (int i = 0; i < newHeight; i++)
                {
                    for (int j = 0; j < newWidth; j++)
                    {
                        int temp = random.Next(1, 4);

                        switch (temp)
                        {
                            case 1:
                                newScene[i, j] = TileTypes.Grass;
                                break;

                            case 2:
                                newScene[i, j] = TileTypes.Water;
                                break;

                            case 3:
                                newScene[i, j] = TileTypes.Road;
                                break;
                        }
                    }
                }
                GameSettings.SaveScene(newScene, newFilePath);
            }
        }
    }
}
