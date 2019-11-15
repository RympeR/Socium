using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game
{
    class Resources : Map
    {
        int money,
            wood,
            food,
            rock;
        
        List<int> param = new List<int>();
        
        public Resources() { }

        public Resources(int m, int w, int f, int r)
        {
            this.food = f;
            this.money = m;
            this.rock = r;
            this.wood = w;
            this.param.Add(this.food);
            this.param.Add(this.rock);
            this.param.Add(this.wood);
            this.param.Add(this.money);
        }
    }
}
