using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StructHighscore
{
    enum Geslacht
    {
        man,vrouw
    }
    class Program
    {
        public struct Highscores
        {
            public string name;
            public int score;
            public DateTime date;
            public Geslacht geslacht;

            public Highscores(string newName, int newScore, DateTime newDate, Geslacht newGeslacht)
            {
                name = newName;
                if (newScore <= 54000)
                {
                    score = newScore;
                }
                else
                {
                    score = -1;
                }
                date = newDate;
                geslacht = newGeslacht;
            }

            public static bool operator >(Highscores h1, Highscores h2)
            {
                if(h1.score > h2.score)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator <(Highscores h1, Highscores h2)
            {
                if (h1.score < h2.score)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public override string ToString()
            {
                string s = "Name: " + name + " , Score: " + score.ToString() + " , Date: " + date.ToString() + " , Geslacht: " + geslacht.ToString();
                return s;
            }
        }
        static void Main(string[] args)
        {
            Highscores higscore1 = new Highscores("Arno", 20200, new DateTime(2018,10,21), Geslacht.man);
            Highscores higscore2 = new Highscores("Gilles", 32800, new DateTime(2021,1,12), Geslacht.man);
            Highscores higscore3 = new Highscores("Free", 28500, new DateTime(2019,8,10), Geslacht.man);
            Highscores higscore4 = new Highscores("Sofie", 15100, new DateTime(2018,7,11), Geslacht.vrouw);

            Console.WriteLine("Highscores: ");
            
            Console.WriteLine(higscore1.ToString());
            Console.WriteLine(higscore2.ToString());
            Console.WriteLine(higscore3.ToString());
            Console.WriteLine(higscore4.ToString());

            Console.WriteLine("h1 > h2: " + (higscore1 > higscore2).ToString());
            Console.WriteLine("h1 < h3: " + (higscore1 < higscore3).ToString());

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}
