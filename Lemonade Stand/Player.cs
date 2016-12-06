using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public Wallet playerWallet;
        public Recipe playerRecipe;
        public Inventory playerInventory;
        string name;

        public Player()
        {
            playerWallet = new Wallet();
            playerInventory = new Inventory();
            playerRecipe = new Recipe();
        }
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
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(2000);
        }
    }

}
