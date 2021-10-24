using System;
using System.Collections.Generic;
using System.Text;

namespace Oef11
{
    class Point
    {
        protected int coordX;
        protected int coordY;

        public Point() {
            coordX = 0;
            coordY = 0;
        }

        public Point(int newX, int newY)
        {
            coordX = newX;
            coordY = newY;
        }

        public virtual string getPoint()
        {
            string output = " ( x , y ) = ( " + coordX + " , " + coordY + " ). ";
            
            return output;
        }
    }
}
