using System;
using System.Collections.Generic;
using System.Text;

namespace Oef12
{
    enum PEGIrating {
        none, PEGI12, PEGI16, PEGI18
    }

    class Game : Article
    {
        protected PEGIrating pegiRating;
        public static int numAvailableGames = 0;

        public Game(string newTitle, double newPrice, PEGIrating newPegiRating) : base(newTitle, newPrice)
        {
            numAvailableGames++;
            pegiRating = newPegiRating;
        }

        public override string GetText()
        {
            return "Type: Game, PEGI-Rating: " + pegiRating + ", " +base.GetText();
        }

    }
}
