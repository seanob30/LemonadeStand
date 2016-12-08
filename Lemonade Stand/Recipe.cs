using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        public int ingredientLemon = 4;
        public int ingredientSugar = 4;
        public int ingredientIce = 6;
        int change;

        public void AlterRecipe()
        {
            InsertRecipeSign();
            Console.WriteLine(" 1. Lemons>> " + ingredientLemon + "\n");
            Console.WriteLine(" 2. Sugar>> " + ingredientSugar + "\n");
            Console.WriteLine(" 3. Ice>> " + ingredientIce + "\n");
            Console.WriteLine(" 4. Exit \n");
            Console.WriteLine(" Which ingredient would you like to alter?");
            Console.Write(" ");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Console.Clear();
                    ChangeAmountOfLemons();
                    break;
                case "2":
                    Console.Clear();
                    ChangeAmountOfSugar();
                    break;
                case "3":
                    Console.Clear();
                    ChangeAmountOfIce();
                    break;
                case "4":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please enter either lemons, sugar, or ice.");
                    TakeBreak();
                    Console.Clear();
                    AlterRecipe();
                    break;
            }
        }
        private void ChangeAmountOfLemons()
        {
            Console.Write("New lemon amount: ");
            string lemonInput = Console.ReadLine();
            try
            {
                change = Convert.ToInt32(lemonInput);
                CheckForPositiveAmount();
                ingredientLemon = change;
                Console.Clear();
                AlterRecipe();
            }
            catch
            {
                Console.WriteLine("?SYNTAX ERROR..");
                TakeBreak();
                Console.Clear();
                ChangeAmountOfLemons();
            }
        }
        private void ChangeAmountOfSugar()
        {
            Console.Write("New sugar amount: ");
            string sugarInput = Console.ReadLine();
            try
            {
                change = Convert.ToInt32(sugarInput);
                CheckForPositiveAmount();
                ingredientSugar = change;
                Console.Clear();
                AlterRecipe();
            }
            catch
            {
                Console.WriteLine("?SYNTAX ERROR..");
                TakeBreak();
                Console.Clear();
                ChangeAmountOfSugar();
            }
        }
        private void ChangeAmountOfIce()
        {
            Console.Write("New ice amount: ");
            string iceInput = Console.ReadLine();
            try
            {
                change = Convert.ToInt32(iceInput);
                CheckForPositiveAmount();
                ingredientIce = change;
                Console.Clear();
                AlterRecipe();
            }
            catch
            {
                Console.WriteLine("?SYNTAX ERROR..");
                TakeBreak();
                Console.Clear();
                ChangeAmountOfIce();
            }
        }
        public int GetLemonRecipe()
        {
            return ingredientLemon;
        }
        public int GetSugarRecipe()
        {
            return ingredientSugar;
        }
        public int GetIceRecipe()
        {
            return ingredientIce;
        }
        private void CheckForPositiveAmount()
        {
            if (change < 0)
            {
                Console.Clear();
                Console.WriteLine(" Please enter a positive number.");
                TakeBreak();
                Console.Clear();
                AlterRecipe();
            }

        }
        private static void InsertRecipeSign()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       ______          _            ");
            Console.WriteLine("       | ___ \\        (_)           ");
            Console.WriteLine("       | |_/ /___  ___ _ _ __   ___ ");
            Console.WriteLine("       |    // _ \\/ __| | '_ \\ / _ \\");
            Console.WriteLine("       | |\\ \\  __/ (__| | |_) |  __/");
            Console.WriteLine("       \\_| \\_\\___|\\___|_| .__/ \\___|");
            Console.WriteLine("                        | |         ");
            Console.WriteLine("                        |_|         \n\n");
            Console.ResetColor();
        }
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(800);
        }

    }
}
