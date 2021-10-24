using System;
using System.Collections.Generic;

namespace Oef12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            DVD dvd1 = new DVD("Lord of The Rings: The Two Towers", 24.95);
            DVD dvd2 = new DVD("UP", 19.95);

            CD cd1 = new CD("Willy Somers: Top Hits", 9.99, 15);
            CD cd2 = new CD("Bob Marley: Greatest Hits", 14.99, 20);

            Game game1 = new Game("For Honor", 14.99, PEGIrating.PEGI16);
            Game game2 = new Game("Borderlands 3", 9.99, PEGIrating.PEGI12);

            articles.Add(dvd1);
            articles.Add(dvd2);
            articles.Add(cd1);
            articles.Add(cd2);
            articles.Add(game1);
            articles.Add(game2);

            Console.WriteLine(getStock());
            Console.WriteLine(getSaleValue(articles));
            PrintAll(articles);

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();

            string getStock()
            {
                string output;

                output = "Totale voorraad: " + Article.numStock + ".\nAantal DVD's in voorraad: " + DVD.numAvailableDVD +
                    ".\nAantal CD's in voorraad: " + CD.numAvailableCD + ".\nAantal games in voorraad: " + Game.numAvailableGames + ".";

                return output;

            }

            string getSaleValue(List<Article> articleList)
            {
                string output;

                double totalSellValue = 0;

                foreach (var article in articleList)
                {
                    totalSellValue += article.Price;
                }

                output = "De totale verkoopwaarde van de voorraad = " + Math.Round(totalSellValue, 2) + ".";

                return output;
            }

            void PrintAll(List<Article> articleList)
            {
                foreach (var article in articleList)
                {
                    Console.WriteLine(article.GetText());
                }
            }
        }
    }
}
