using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        public void RunGame()
        {
            DisplayTitleScreen();
            DisplayWelcomeScreen();
            DisplayRulesScreen();
            StartGame();
        }
        private void DisplayTitleScreen()
        {
            Console.WindowWidth = 74;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" _                                      _            _                  _ ");
            Console.WriteLine("| |                                    | |          | |                | |");
            Console.WriteLine("| | ___ _ __ ___   ___  _ __   __ _  __| | ___   ___| |_ __ _ _ __   __| |");
            Console.WriteLine("| |/ _ \\ '_ ` _ \\ / _ \\| '_ \\ / _` |/ _` |/ _ \\ / __| __/ _` | '_ \\ / _` |"); 
            Console.WriteLine("| | __ / | | | | | (_) | | | | (_| | (_| |  __/ \\__ \\ || (_| | | | | (_| |");
            Console.WriteLine("|_|\\___|_| |_| |_|\\___/|_| |_|\\__,_|\\__,_|\\___| |___/\\__\\__,_|_| |_|\\__,_|\n");
            Console.Write("                        Press any key to continue...");
            Console.ReadKey();
            Console.Beep();
            Console.Clear();
            Console.ResetColor();
        }
        private void DisplayWelcomeScreen()
        {
            Console.WindowWidth = 43;
            Console.WriteLine(" HI,  WELCOME TO LEMONSVILLE,  WISCONSIN!\n");
            Console.WriteLine(" IN THIS SMALL TOWN, YOU ARE IN CHARGE OF\n");
            Console.WriteLine(" RUNNING YOUR OWN LEMONADE STAND. YOU CAN\n");
            Console.WriteLine(" COMPETE WITH AS MANY OTHER PEOPLE AS YOU\n");
            Console.WriteLine(" WISH, BUT HOW MUCH PROFIT YOU MAKE IS UP\n");
            Console.WriteLine(" TO YOU. IF YOU MAKE THE MOST MONEY YOURE\n");
            Console.WriteLine(" THE WINNER!!\n\n");
            Console.Write(" Press any key to begin your venture!!");
            Console.ReadKey();
            Console.Clear();
        }
        private static void DisplayRulesScreen()
        {
            Console.WindowWidth = 43;
            Console.WriteLine(" TO MANAGE YOUR LEMONADE STAND, YOU WILL\n");
            Console.WriteLine(" NEED TO MAKE THESE DECISIONS EVERY DAY:\n");
            Console.WriteLine(" -HOW MANY LEMONS, SUGAR, AND ICE TO BUY\n");
            Console.WriteLine(" -WHAT YOU WANT THE RECIPE TO BE\n");
            Console.WriteLine(" -WHAT YOU WANT TO CHARGE FOR EACH GLASS\n\n");
            Console.WriteLine(" YOU WILL BEGIN WITH $20 CASH (ASSETS).\n");
            Console.WriteLine(" YOU WILL USE THOSE ASSETS TO BUY THE\n");
            Console.WriteLine(" INGREDIENTS FOR THE LEMONADE. BE AWARE\n");
            Console.WriteLine(" OF THE WEATHER, AS IT WILL AFFECT YOUR\n");
            Console.WriteLine(" OVERALL SALES..AS WILL YOUR RECIPE.\n\n");
            Console.Write(" Press SPACE to continue or ESC to exit... ");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            else if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                DisplayRulesScreen();
            }
        }
        private void StartGame()
        {
            
        }
    }
}
