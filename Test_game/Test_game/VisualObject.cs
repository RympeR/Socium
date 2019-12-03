using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    abstract class VisualObject
    {
        protected int sizeX = 20;
        protected int sizeY = 50;
        protected int scale = 1;//?
        protected char[,] display;
        protected bool[,] space;
        
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
