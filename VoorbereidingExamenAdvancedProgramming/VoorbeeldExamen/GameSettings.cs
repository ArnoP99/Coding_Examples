using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldExamen1DLL
{
    public enum TileTypes
    {
        Grass = 1, Water = 2, Road = 3
    }
    public class GameSettings
    {
        protected ushort mNumPlayers;
        TileTypes[,] mScene;

        public GameSettings(ushort newNumPlayers, string newFileName)
        {
            if (newNumPlayers <= 40000)
            {
                mNumPlayers = newNumPlayers;
            }
            else
            {
                Console.WriteLine("Number of players exceed maximum, number of players has been set on max value of 40000");
                mNumPlayers = 40000;
            }
            LoadScene(newFileName);
        }

        public void Show()
        {
            for (int i = 0; i < mScene.GetLength(0); i++)
            {
                for (int j = 0; j < mScene.GetLength(1); j++)
                {
                    switch (mScene[i, j])
                    {
                        case TileTypes.Grass:
                            Console.Write("Grass\t");
                            break;

                        case TileTypes.Water:
                            Console.Write("Water\t");
                            break;

                        case TileTypes.Road:
                            Console.Write("Road\t");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public void LoadScene(string filePath)
        {
            StreamReader inStream = null;
            inStream = File.OpenText(filePath);

            string fileContent = inStream.ReadToEnd();

            try
            {
                short height = Convert.ToInt16(fileContent.Substring(8, (fileContent.IndexOf('W') - 8)));
                short width = Convert.ToInt16(fileContent.Substring((fileContent.IndexOf('W')+6), fileContent.IndexOf('\n') - (fileContent.IndexOf('W') + 6)));
                mScene = new TileTypes[height, width];
                short counter = Convert.ToInt16(fileContent.IndexOf('\n')+1);

                for (int i = 0; i < mScene.GetLength(0); i++)
                {
                    for (int j = 0; j < mScene.GetLength(1); j++)
                    {

                        mScene[i,j] = (TileTypes)Convert.ToInt16(fileContent.Substring(counter, 1));
                        counter++;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Er is iets misgegaan bij het uitlezen van de tiles in de tekstFile.");
                Console.WriteLine("Exception output: " + ex.ToString());
            }
            inStream.Close();
        }

        public static void SaveScene(TileTypes[,] tileTypeArray, string filePath)
        {
            StreamWriter outStream = null;

            try
            {
                Console.WriteLine(filePath);
                outStream = File.CreateText(filePath);

                outStream.Write("Height: " + tileTypeArray.GetLength(0) + " Width: " + tileTypeArray.GetLength(1) + "\n");

                for (int i = 0; i < tileTypeArray.GetLength(0); i++)
                {
                    for (int j = 0; j < tileTypeArray.GetLength(1); j++)
                    {
                        switch (tileTypeArray[i, j])
                        {
                            case TileTypes.Grass:
                                outStream.Write(Convert.ToByte(tileTypeArray[i, j]));
                                break;

                            case TileTypes.Water:
                                outStream.Write(Convert.ToByte(tileTypeArray[i, j]));
                                break;

                            case TileTypes.Road:
                                outStream.Write(Convert.ToByte(tileTypeArray[i, j]));
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Er is iets misgegaan bij het opslaan van de tiles uit de TileType Array in de tekstFile." );
                Console.WriteLine("Exception output: " + ex.ToString());
            }
            outStream.Close();
        }

        public bool CheckScene()
        {
            HashSet<TileTypes> differentTypes = new HashSet<TileTypes>();

            foreach (var tile in mScene)
            {
                differentTypes.Add(tile);
            }

            if(differentTypes.Contains(TileTypes.Grass) && differentTypes.Contains(TileTypes.Road) && differentTypes.Contains(TileTypes.Water))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

