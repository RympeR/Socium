using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    static class Terrain
    {
        public char getGround(byte num)
        {
            return Ground.dirt.();
        }
    }

    enum Ground
    {
        rock = 'r',
        sand = 's',
        grass = 'g',
        water = 'w',
        dirt = 'd'
    }
}
