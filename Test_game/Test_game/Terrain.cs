using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    static class Terrain
    {
        static readonly char[] ground = {'r', 'g', 's', 'w', 'd' };
        public static char getGround(byte num)
        {
            if (num > 4)
                num = 4;
            return ground[num];
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
