using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_game.BuildingTypes
{
    class Building
    {
        private IBuild Ib;

        public Building() { }

        public Building(IBuild i)
        {
            this.Ib = i;
        }

        public void setBuid(IBuild i)
        {
            this.Ib = i;
        }

        public void Build()
        {
            Console.WriteLine("Type of building is:");
            Ib.Build();
        }
    }
}
