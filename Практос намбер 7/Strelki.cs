using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практос_намбер_7
{
    internal class Strelki
    {
        
        public static int Strelkii(int min, int max)
        {
            int position = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position != min)
                {
                    position--;
                    if (position == min)
                        position = max - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow && position != max)
                {
                    position++;
                    if (position == max)
                        position = min + 1;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return -99;
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    return -100;
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    return -200;
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    return -300;
                }
                else if (key.Key == ConsoleKey.F4)
                {
                    return -400;
                }
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }
    }
}
