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

        }

        public Map(startConditions start)
        {

            if (start == startConditions.random)
            {

            }
        }

        public Map(startConditions start, int mapWidth, int mapHeight)
        {
            width = mapWidth;
            height = mapHeight;
            if (start == startConditions.random)
            {

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
                    display[i, j] = Ground.dirt;
                }
            }
        }

        public override void Show()
        {

        }
    }

    enum startConditions
    {
        Default,
        random
    }
}
