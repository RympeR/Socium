using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Game
    {
        Display disp = new Display(10, 10);


        public void GameLoop()
        {
            while (true)
            {
                disp.Output();
            }
        }

        public void Start()
        {
            Console.WriteLine("Game is started");
        }

    }
}
