using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    class ValueCoordinates
    {
        public int X;
        public int Y;

        public ValueCoordinates (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double operator -(ValueCoordinates a, ValueCoordinates b)
        {
            return Math.Sqrt(Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.X - b.X, 2));
        }
    }
}
