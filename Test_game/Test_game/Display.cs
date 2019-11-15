using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Display
    {
        int selectedX = 1,
            selectedY = 1;

        static int x,
                   y;
        char [,] map = new char [x + 2,y + 2];
        bool [,] place = new bool[x + 2, y + 2];

        public Display()
        {

        }
        public Display(int x1, int y1)
        {
            x = x1;
            y = y1;

            this.map[this.selectedX, this.selectedY] = '+';
            for (int i = 0; i <= x + 1; i++)
            {
                for (int j = 0; j <= y + 1; j++)
                {
                    if ((i == 0 && j == 0) || (i == x + 1 && j == y + 1))
                    {
                        this.place[i, j] = true;
                        this.map[i, j] = '*';
                    }
                    else
                        this.place[i, j] = true;
                }
            }
        }

        public void Output()
        {
            this.map[this.selectedX, this.selectedY] = '+';
            for (int i = 0; i <= x+1; i++)
            {
                for (int j = 0; j <= y+1;j++)
                {
                    if ((i == 0 && j == 0) || (i == x+1 && j == y+1))
                    {
                        this.map[i, j] = '*';
                    }
                }
            }
        }

    }
}
