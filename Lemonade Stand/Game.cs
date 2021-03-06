﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Input.Manipulations;

namespace Lemonade_Stand
{
    class Game
    {
        Player player;
        Store store;
        Day newDay;
        Random rnd;
        public void RunGame()
        {
            player = new Player();
            store = new Store();
            rnd = new Random();
            newDay = new Day();
            DisplayTitleScreen();
            DisplayWelcomeScreen();
            player.SetName();
            DisplayUI();
        }
        public void DisplayUI()
        {
            Console.WindowWidth = 43;
            InsertMenuTitle();
            DisplayUIItems();
            Console.Write(" What would you like to do?: ");
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    Console.Clear();
                    newDay.BeginDay(player, rnd);
                    DisplayUI();
                    break;
                case "2":
                    Console.Clear();
                    store.DisplayStoreScreen(player, player.playerInventory);
                    DisplayUI();
                    break;
                case "3":
                    Console.Clear();
                    player.playerRecipe.AlterRecipe();
                    DisplayUI();
                    break;
                case "4":
                    Console.Clear();
                    DisplayRulesScreen();
                    DisplayUI();
                    break;
                case "5":
                    Console.Clear();
                    QuitGame();
                    DisplayUI();
                    break;
                default:
                    Console.WriteLine("Please enter a number 1-5");
                    TakeShortBreak();
                    Console.Clear();
                    DisplayUI();
                    break;
            }
        }
        private void QuitGame()
        {
            Console.WriteLine("Are you sure you would like to quit?");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "yes":
                case "y":
                    Environment.Exit(0);
                    break;
                case "no":
                case "n":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please type in yes or no.");
                    TakeShortBreak();
                    Console.Clear();
                    QuitGame();
                    break;
            }
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
            Console.WriteLine(" RUNNING YOUR OWN LEMONADE STAND. HOW MUCH\n"); 
            Console.WriteLine(" PROFIT YOU MAKE IS UP TO YOU. IF YOU DO \n");
            Console.WriteLine(" NOT GO BANKRUPT, YOU ARE A WINNER!!\n");
            Console.Write("       Press any key to continue!!");
            Console.ReadKey();
            Console.Clear();
        }
        private void InsertMenuTitle()
        {
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ███╗   ███╗███████╗███╗   ██╗██╗   ██╗");
            Console.WriteLine("  ████╗ ████║██╔════╝████╗  ██║██║   ██║");
            Console.WriteLine("  ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║");
            Console.WriteLine("  ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║");
            Console.WriteLine("  ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝");
            Console.WriteLine("  ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ \n\n");
            Console.ResetColor();
        }
        private void DisplayUIItems()
        {
            Console.WriteLine(" >>1. Begin Day\n");
            Console.WriteLine(" >>2. Visit The Store\n");
            Console.WriteLine(" >>3. Alter Recipe\n");
            Console.WriteLine(" >>4. Check Rules\n");
            Console.WriteLine(" >>5. Quit Game\n\n");
        }
        private void DisplayRulesScreen()
        {
            Console.WindowWidth = 43;
            Console.WriteLine(" TO MANAGE YOUR LEMONADE STAND, YOU WILL\n");
            Console.WriteLine(" NEED TO MAKE THESE DECISIONS EVERY DAY:\n");
            Console.WriteLine(" -HOW MANY LEMONS, SUGAR, AND ICE TO BUY\n");
            Console.WriteLine(" -WHAT YOU WANT THE RECIPE TO BE\n");
            Console.WriteLine(" -WHAT YOU WANT TO CHARGE FOR EACH GLASS\n\n");
            Console.WriteLine(" YOU WILL BEGIN WITH $5.00 CASH (ASSETS).\n");
            Console.WriteLine(" YOU WILL USE THOSE ASSETS TO BUY THE\n");
            Console.WriteLine(" INGREDIENTS FOR THE LEMONADE. BE AWARE\n");
            Console.WriteLine(" OF THE WEATHER, AS IT WILL AFFECT YOUR\n");
            Console.WriteLine(" OVERALL SALES..AS WILL YOUR RECIPE...\n");
            Console.WriteLine(" AND YOUR DAILY PRICE TOO. BE MINDFUL..\n\n");
            Console.Write(" Press any key to return to the main menu..");
            Console.ReadKey();
            Console.Clear(); 
        }
        private void TakeShortBreak()
        {
            System.Threading.Thread.Sleep(800);
        }
    }
}
