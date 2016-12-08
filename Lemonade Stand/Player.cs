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
        public decimal cupPrice;
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
        public void SetPrice()
        {
            Console.Write(" What would you like to charge a cup?: ");
            string input = Console.ReadLine();
            cupPrice = Convert.ToDecimal(input);
            Console.Clear();
            Console.WriteLine("Price is set at " + cupPrice);
            Console.ReadKey();
            Console.Clear();
        }
        public string GetName()
        {
            return name;
        }
        public decimal GetCupPrice()
        {
            return cupPrice;
        }
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(2000);
        }
    }

}
