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
                    Console.WriteLine("Okay...exiting.");
                    TakeBreak();
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
                int lemonChange = Convert.ToInt32(lemonInput);
                ingredientLemon = lemonChange;
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
                int sugarChange = Convert.ToInt32(sugarInput);
                ingredientSugar = sugarChange;
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
                int iceChange = Convert.ToInt32(iceInput);
                ingredientIce = iceChange;
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
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(1000);
        }

    }
}
