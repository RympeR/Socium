using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    abstract class VisualObject
    {
        protected const int sizeX = 50;
        protected const int sizeY = 20;
        protected const int scale = 1;//?
        protected char[,] display = new char[sizeX, sizeY];
        protected bool[,] space = new bool[sizeX, sizeY];
        
        public abstract void Show();
        public abstract void Show(int scale);

        protected char[,] Copy(char[,] a, int x, int y)
        {
            char[,] b = new char[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    b[i,j] = a[i, j];
                }
            }
            return b;
        }
    }
}
