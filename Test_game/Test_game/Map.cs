using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Map : VisualObject
    {

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
            sizeX = mapWidth;
            sizeY = mapHeight;
            if (start == startConditions.random)
            {
                generateRandomMap();
            }
        }

        void generateRandomMap()
        {
            display = new char[sizeX, sizeY];
            space = new bool[sizeX, sizeY];
            int seed = new Random(DateTime.UtcNow.Minute * DateTime.UtcNow.Second).Next();
            FastNoise myNoise = new FastNoise(seed); // Create a FastNoise object
            myNoise.SetNoiseType(FastNoise.NoiseType.SimplexFractal); // Set the desired noise type
            int noiseFreq = 3;

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("map" + seed + ".smp"))
            {

                Random r = new Random();
                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = 0; j < sizeY; j++)
                    {
                        space[i, j] = true;
                        double curNoiseValue = myNoise.GetNoise(i * noiseFreq, j * noiseFreq);
                        byte value = (byte)Math.Round((((curNoiseValue+1))*3) - 1);
                        display[i, j] = Terrain.getGround(value);
                        writer.Write(value + "  ");
                    }
                    writer.WriteLine();
                }
                writer.Close();

            };
        }

        public override void Show()
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
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
            for (int i = 0; i < sizeX * scale; i++)
            {
                for (int j = 0; j < sizeY * scale; j += scale)
                {
                    char symb = display[i / scale, j / scale];
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
                case 'r':
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 'w':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 'g':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 'd':
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 's':
                    Console.BackgroundColor = ConsoleColor.Yellow;
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
