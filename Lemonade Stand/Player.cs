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
        public void AddLemons(decimal amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Lemon lemon = new Lemon();
                playerInventory.lemons.Add(lemon);
            }
        }
        public void AddSugar(decimal amount)
        {
            for (int i =0; i < amount; i++)
            {
                Sugar sugar = new Sugar();
                playerInventory.sugars.Add(sugar);
            }
        }
        public void AddIce(decimal amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Ice ice = new Ice();
                playerInventory.ices.Add(ice);
            }
        }
        public void AddCups(decimal amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Cup cup = new Cup();
                playerInventory.cups.Add(cup);
            }
        }
        public void SubtractLemons(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                playerInventory.lemons.RemoveAt(0);
            }
        }
        public void SubtractSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                playerInventory.sugars.RemoveAt(0);
            }
        }
        public void SubtractIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                playerInventory.ices.RemoveAt(0);
            }
        }
        public int GetLemons()
        {
            return playerInventory.lemons.Count;
        }
        public int GetSugar()
        {
            return playerInventory.sugars.Count;
        }
        public int GetIce()
        {
            return playerInventory.ices.Count;
        }
        public int GetCups()
        {
            return playerInventory.cups.Count;
        }
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(2000);
        }
    }

}
