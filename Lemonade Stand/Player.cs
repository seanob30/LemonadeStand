using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public Wallet playerWallet = new Wallet();
        public Recipe playerRecipe = new Recipe();
        public decimal lemons = 0m;
        public decimal sugar = 0m;
        public decimal ice = 0m;
        public decimal cups = 0m;
        string name;

        public void SetName()
        {
            Console.Write("What is your name?: ");
            name = Console.ReadLine();
            Console.WriteLine("\nWelcome " + name + "!");
            TakeBreak();
            Console.Clear();
        }
        public string GetName()
        {
            return name;
        }
        public decimal GetLemons()
        {
            return lemons;
        }
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(2000);
        }
    }

}
