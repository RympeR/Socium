using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game.BuildingTypes
{
    class Playground : Resources, IBuild
    {
        int cost_m,
            cost_w,
            cost_r,
            mood;
        
        public Playground(int p)
        {
            this.cost_m = p;
        }
        public void Build()
        {

        }

    }
}
