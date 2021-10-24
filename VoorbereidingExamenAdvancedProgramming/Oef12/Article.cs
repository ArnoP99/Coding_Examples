using System;
using System.Collections.Generic;
using System.Text;

namespace Oef12
{
    class Article
    {
        protected string title;
        protected double price;

        public static int numStock = 0;

        public Article(string newTitle, double newPrice)
        {
            numStock++;
            title = newTitle;
            price = newPrice;
        }

        public virtual string GetText()
        {
            string output;

            output = "titel: '" + title + "', prijs: " + price + ".";

            return output;
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
