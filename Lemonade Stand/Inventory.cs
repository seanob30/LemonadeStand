using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        public List<Lemon> lemons = new List<Lemon>();
        public List<Sugar> sugars = new List<Sugar>();
        public List<Ice> ices = new List<Ice>();
        public List<Cup> cups = new List<Cup>();
        public List<Pitcher> pitchers = new List<Pitcher>();
        public List<LemonadeCup> lemonadeCups = new List<LemonadeCup>();
        int pitcherQuantity;

        public void CreatePitchers(Player player)
        {
            Console.WindowWidth = 50;
            Console.Write(" How many pitchers would you like to make?: ");
            string pitcherInput = Console.ReadLine();
            try
            {
                pitcherQuantity = Convert.ToInt32(pitcherInput);
                for (int i = 0; i < pitcherQuantity; i++)
                {
                    if (CheckForSufficientIngredients(player.playerRecipe.ingredientLemon, player.playerRecipe.ingredientSugar, player.playerRecipe.ingredientIce, GetCups()))
                    {
                        Pitcher pitcher = new Pitcher(player.playerInventory);
                        pitchers.Add(pitcher);
                        RemoveItems(player.playerRecipe);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n Error..Insufficient ingredients.");
                        TakeBreak();
                    }
                }
            }
            catch
            {
                Console.WriteLine("\n Error..Please try again.");
                TakeBreak();
                Console.Clear();
                CreatePitchers(player);
            }
            Console.Clear();
            DisplayPitcherAmount();
        }
        public bool CheckForSufficientIngredients(int lemonAmount, int sugarAmount, int iceAmount, int cupAmount)
        {
            if (GetLemons() >= lemonAmount && GetSugar() >= sugarAmount && GetIce() >= iceAmount && GetCups() >= cupAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveItems(Recipe playerRecipe)
        {
            SubtractLemons(playerRecipe.ingredientLemon);
            SubtractSugar(playerRecipe.ingredientSugar);
            SubtractIce(playerRecipe.ingredientIce);
            SubtractCups(10);
        }
        public void AddLemons(decimal amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }
        public void AddSugar(decimal amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Sugar sugar = new Sugar();
                sugars.Add(sugar);
            }
        }
        public void AddIce(decimal amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Ice ice = new Ice();
                ices.Add(ice);
            }
        }
        public void AddCups(decimal amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
        public void SubtractLemons(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                lemons.RemoveAt(0);
            }
        }
        public void SubtractSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                sugars.RemoveAt(0);
            }
        }
        public void SubtractIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                ices.RemoveAt(0);
            }
        }
        public void SubtractCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                cups.RemoveAt(0);
            }
        }
        public void RemoveLemonadeCupsAndPitchers()
        {
            for (int i = 0; i < lemonadeCups.Count(); i++)
            {
                lemonadeCups.RemoveAt(0);
            }
            for (int i = 0; i < pitchers.Count(); i++)
            {
                pitchers.RemoveAt(0);
            }
        }
        public int GetLemons()
        {
            return lemons.Count;
        }
        public int GetSugar()
        {
            return sugars.Count;
        }
        public int GetIce()
        {
            return ices.Count;
        }
        public int GetCups()
        {
            return cups.Count;
        }
        public int GetPitchers()
        {
            return pitchers.Count;
        }
        private void DisplayPitcherAmount()
        {
            Console.WriteLine("You made " + GetPitchers() + " pitchers.");
            Console.ReadKey();
            Console.Clear();
        }
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(1000);
        }
    }
}
