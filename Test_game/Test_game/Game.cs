using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Game
    {
        Map m = new Map(startConditions.random, 40, 50);
        bool isGame = true;





        public void GameLoop()
        {
            int scale = 1;
            m.Show(scale);
            while (isGame)
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
                if (key.Key == ConsoleKey.Q)
                    isGame = false;
                if (key.Key == ConsoleKey.B)
                {
                    Console.Clear();
                    m.Show(scale);
                    Console.WriteLine("1.Houses");
                    Console.WriteLine("2.Houses");
                    Console.WriteLine("3.Houses");
                    Console.WriteLine("4.Houses");
                    Console.WriteLine("5.Houses");
                    int choice = Console.Read();
                }

            }
        }

        public void Choice(int a)
        {
            switch (a)
            {
                case 1:
                    //BuildHouse();
                    break;
                default:
                    break;
            }
        }
        
        public void Start()
        {
            Console.WriteLine("Game is started");
            GameLoop();
            Console.WriteLine("Game finished!");
        }

    }
}
