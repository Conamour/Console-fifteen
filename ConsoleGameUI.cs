using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    class ConsoleGameUI
    {
        public IPlayable Interface;

        public ConsoleGameUI(Game fifteen)
        {
            Interface = (IPlayable)fifteen;
        }

        public void Write()
        {
            var fifteen = (Game2)Interface;
            for (int i = 0; i < fifteen.side; i++)
            {
                for (int j = 0; j < fifteen.side; j++)
                {
                    Console.Write(fifteen.Field[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        public void Moves()
        {
            int value = Convert.ToInt32(Console.ReadLine());

            try
            {
                Interface.Shift(value);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неверное значение");
                Moves();
            }

            Console.Clear();
            Write();
        }

    }
}
