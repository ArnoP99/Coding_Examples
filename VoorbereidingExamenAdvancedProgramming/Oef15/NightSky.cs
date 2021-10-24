using System;
using System.Collections.Generic;
using System.Text;

namespace Oef15
{
    class NightSky
    {
        private SkyElement[,] nightSky;
        private int size;
        bool tempBool = false;

        public NightSky(int newSize)
        {
            size = newSize;
            nightSky = new SkyElement[newSize, newSize];
            SkyElement skyElement = new SkyElement();
            Random random = new Random();

            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < newSize; j++)
                {
                    nightSky[i, j] = skyElement;
                }
            }

            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Star();
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Star();
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Star();
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Star();
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Star();

            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Planet(ConsoleColor.Red);
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Planet(ConsoleColor.Cyan);
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Planet(ConsoleColor.Green);
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Planet(ConsoleColor.Red);

            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Comet(CometDirection.Vertical);
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Comet(CometDirection.LeftDown);
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Comet(CometDirection.RightDown);
            nightSky[random.Next(0, newSize), random.Next(0, newSize)] = new Comet(CometDirection.Vertical);

            while (tempBool == false)
            {
                tempBool = CreateBlackHole();
            }

            bool CreateBlackHole()
            {
                int tempX = random.Next(3, newSize - 4);
                int tempY = random.Next(3, newSize - 4);
                tempBool = true;
                for (int i = -3; i < 4; i++)
                {
                    for (int j = -3; j < 4; j++)
                    {
                        if (Convert.ToString(nightSky[tempX + i, tempY + j]) != "Oef15.SkyElement")
                        {
                            tempBool = false;
                            break;
                        }
                    }
                }
                if (tempBool == true)
                {
                    nightSky[tempX, tempY] = new BlackHole();
                }
                return tempBool;
            }
        }

        public void Print()
        {
            for (int i = 0; i < nightSky.GetLength(0); i++)
            {
                for (int j = 0; j < nightSky.GetLength(1); j++)
                {
                    nightSky[i, j].Print();
                }
                Console.WriteLine();
            }
        }

        public void Move()
        {
            SkyElement temp2;
            SkyElement temp3;
            for (int j = 0; j < size; j++)
            {
                temp3 = nightSky[j, 0];
                SkyElement temp1 = nightSky[j, size - 1];
                temp2 = nightSky[j, size - 2];
                nightSky[j, size - 1] = temp2;
                nightSky[j, 0] = temp1;

                for (int i = 0; i < size - 1; i++)
                {
                    {
                        temp2 = nightSky[j, i + 1];
                        nightSky[j, i + 1] = temp3;
                        temp3 = temp2;
                    }
                }
            }
        }
    }
}

