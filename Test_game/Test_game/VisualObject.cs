using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    abstract class VisualObject
    {
        protected char[,] display;

        public abstract void Show();
    }
}
