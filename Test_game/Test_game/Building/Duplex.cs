using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game.Building
{
    class Duplex : Houses
    {
        Map m = new Map();
        const char symb = 'd';
        const String name = "Дуплекс";

        public Duplex()
        {
            width = 2;
            height = 1;
        }




        public override void Show()
        {
            int x = 0,
                y = 0;
            char[,] cop = Copy(display, x, y);
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Q || key.Key != ConsoleKey.B)
            {
                if(x+height > cop.Length)
                for (int i = x; i < x + height; i++)
                {
                    for (int j = y; j < y + width; j++)
                    {
                        cop[i, j] = 'd';
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    m.Show();
                    y++;
                    for (int i = x; i < height + x; i++)
                    {
                        for (int j = y; j < width + y; j++)
                        {
                            cop[i, j] = '1';
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    m.Show();
                    x++;
                    for (int i = x; i < height + x; i++)
                    {
                        for (int j = y; j < width + y; j++)
                        {
                            cop[i, j] = '1';
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    m.Show();
                    y--;
                    for (int i = x; i < height + x; i++)
                    {
                        for (int j = y; j < width + y; j++)
                        {
                            cop[i, j] = '1';
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    m.Show();
                    x--;
                    for (int i = x; i < height + x; i++)
                    {
                        for (int j = y; j < width + y; j++)
                        {
                            cop[i, j] = '1';
                            foreach (var item in space)
                            {
                                //?
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }

                if (key.Key == ConsoleKey.B)
                {
                    bool isAvailable = true;
                    Console.Clear();
                    m.Show();
                    for (int i = x; i < height + x; i++)
                    {
                        for (int j = y; j < width + y; j++)
                        {
                            foreach (var item in space)
                            {
                                if (item == false)
                                    isAvailable = false;
                                break;
                            }
                            if (isAvailable)
                            {
                                display[i, j] = '1';
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                cop[i, j] = '1';
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }
                    }
                }





            }
        }

        public void Draw(VisualObject visualObject)
        {

        }

        public override void Show(int scale)
        {
            for (int i = 0; i < sizeX * scale; i++)
            {
                for (int j = 0; j < sizeY * scale; j += scale)
                {
                    char symb = display[i / scale, j / scale];
                    for (int x = 0; x < scale; x++)
                    {
                        //m.ChooseColor(symb);
                        Console.Write(" ");
                    }
                }
                //m.ChooseColor('1');
                Console.WriteLine();
            }
        }
    }
}
