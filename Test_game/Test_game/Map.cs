using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Map : VisualObject
    {

        int width = 20;
        int height = 50;

        public Map()
        {
            generateRandomMap();
        }

        public Map(startConditions start)
        {

            if (start == startConditions.random)
            {
                generateRandomMap();
            }
        }

        public Map(startConditions start, int mapWidth, int mapHeight)
        {
            width = mapWidth;
            height = mapHeight;
            if (start == startConditions.random)
            {
                generateRandomMap();
            }
        }

        void generateRandomMap()
        {
            Random r = new Random();
            display = new char[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    display[i, j] = Terrain.getGround((byte)r.Next(0, 6));
                }
            }
        }

        public override void Show()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    char symb = display[i, j];
                    ChooseColor(symb);
                    Console.Write(" ");
                }
                ChooseColor('1');
                Console.WriteLine();
            }
        }

        public override void Show(int scale)
        {
            for (int i = 0; i < width*scale; i++)
            {
                for (int j = 0; j < height* scale; j+= scale)
                {
                    char symb = display[i/scale, j/scale];
                    for (int x = 0; x < scale; x++)
                    {
                        ChooseColor(symb);
                        Console.Write(" ");
                    }
                }
                ChooseColor('1');
                Console.WriteLine();
            }
        }

        void ChooseColor(char c)
        {
            switch (c)
            {
                case 'r': Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 'w': Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 'g': Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 'd': Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 's': Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }

    enum startConditions
    {
        Default,
        random
    }
}
