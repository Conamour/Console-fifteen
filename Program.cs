using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new Game2(1, 2, 3, 0, 4, 5, 6, 7, 8);

            var A = new ConsoleGameUI(field);

            A.Write();
            A.Moves();
        }
    }
}
