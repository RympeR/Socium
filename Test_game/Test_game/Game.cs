using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Game
    {
        Map m = new Map(startConditions.random);

        public void GameLoop()
        {
            int scale = 1;
            m.Show(scale);
            while (true)
            {
                Console.WriteLine("\n\r\n\r");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.U)
                {
                    m.Show();
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    if (scale < 3)
                    {
                        scale++;
                    }
                    else
                        Console.WriteLine("Max scale already");

                    m.Show(scale);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    if (scale > 1)
                    {
                        scale--;
                    }
                    else
                        Console.WriteLine("Min scale already");
                    m.Show(scale);
                }
            }
        }

        public void Start()
        {
            Console.WriteLine("Game is started");
            GameLoop();
        }

    }
}
