using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    static class Display
    {
        /*
        int selectedX = 1,
            selectedY = 1;

        int x = 0, 
            y = 0;

        char [,] map;
        bool [,] place;

        public Display()
        {
            map = new char[x + 2, y + 2];
            place = new bool[x + 2, y + 2];
        }

        public Display(int x1, int y1)
        {
            x = x1;
            y = y1;

            map[selectedX, selectedY] = '+';
            for (int i = 0; i <= x + 1; i++)
            {
                for (int j = 0; j <= y + 1; j++)
                {
                    if ((i == 0 && j == 0) || (i == x + 1 && j == y + 1))
                    {
                        place[i, j] = true;
                        map[i, j] = '*';
                    }
                    else
                        place[i, j] = true;
                }
            }
        }*/

        public static void Show(List<VisualObject> vo)
        {
            foreach (VisualObject visualObject in vo)
            {
                visualObject.Show();
            }
        }

    }
}
