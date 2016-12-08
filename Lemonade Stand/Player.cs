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
            Console.ReadKey();
            Console.Clear();
        }
        public void SetPrice()
        {
            if (playerInventory.pitchers.Count() > 0)
            {
                InsertMoneySymbols();
                Console.Write(" What would you like to charge a cup?: ");
                string input = Console.ReadLine();
                try
                {
                    cupPrice = Convert.ToDecimal(input);
                    CheckForPositiveAmount();
                    Console.Clear();
                    Console.WriteLine("Price is set at $" + cupPrice);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a price, numbers only.");
                    Console.ReadKey();
                    Console.Clear();
                    SetPrice();
                }
            }
            else
            {
                Console.Clear();
            }
        }
        public string GetName()
        {
            return name;
        }
        public decimal GetCupPrice()
        {
            return cupPrice;
        }
        private void CheckForPositiveAmount()
        {
            if (cupPrice < 0)
            {
                Console.Clear();
                Console.WriteLine(" Please enter a positive number.");
                TakeBreak();
                Console.Clear();
                SetPrice();
            }

        }
        public void InsertMoneySymbols()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n     ▄▄███▄▄·    ▄▄███▄▄·    ▄▄███▄▄·");
            Console.WriteLine("     ██╔════╝    ██╔════╝    ██╔════╝");
            Console.WriteLine("     ███████╗    ███████╗    ███████╗");
            Console.WriteLine("     ╚════██║    ╚════██║    ╚════██║");
            Console.WriteLine("     ███████║    ███████║    ███████║");
            Console.WriteLine("     ╚═▀▀▀══╝    ╚═▀▀▀══╝    ╚═▀▀▀══╝\n");
            Console.ResetColor();
        }
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(800);
        }
    }

}
