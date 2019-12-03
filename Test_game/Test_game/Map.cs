using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Map : VisualObject
    {

        int x = 20;
        int y = 50;

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
            x = mapWidth;
            y = mapHeight;
            if (start == startConditions.random)
            {

            }
        }

        void generateRandomMap()
        {
            display = new char[x, y];

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
