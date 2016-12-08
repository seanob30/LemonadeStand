using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Pitcher
    {
        int numberOfCups = 10;
        public Pitcher(Inventory playerInventory)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                LemonadeCup newCup = new LemonadeCup();
                playerInventory.lemonadeCups.Add(newCup);
            }
        }
    }
}
