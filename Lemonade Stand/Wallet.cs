using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Wallet
    {
        public decimal assets = 15.00m;
        public bool CheckForSufficentFunds(decimal amount)
        {
            if (amount <= assets)
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }
        }
    }
}
