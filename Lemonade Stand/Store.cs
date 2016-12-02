using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        string lemons;
        string sugar;
        string ice;
        string cups;


        public void PurchaseItems()
        {
            Console.WindowWidth = 55;
            InsertStoreSign();
            DisplayStoreItems();
            Console.Write(" What would you like to buy?: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "lemons":
                    //assets -= .18m;
                    lemons += 25;
                    break;
                case "sugar":
                    //assets -= .13m;
                    sugar += 20;
                    break;
                case "ice":
                    //assets -= .08;
                    ice += 100;
                    break;
                case "cups":
                    //assets -= .07;
                    cups += 30;
                    break;
                default:
                    Console.WriteLine("Please enter a valid store item.");
                    TakeShortBreak();
                    Console.Clear();
                    PurchaseItems();
                    break;
            }
            Console.Clear();
            PromptAnotherTransaction();    
        }

        private void InsertStoreSign()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  _____ _   _  _____   _____ _____ ___________ _____ ");
            Console.WriteLine(" |_   _| | | ||  ___| /  ___|_   _|  _  | ___ \\  ___|");
            Console.WriteLine("   | | | |_| || |__   \\ `--.  | | | | | | |_/ / |__  ");
            Console.WriteLine("   | | |  _  ||  __|   `--. \\ | | | | | |    /|  __|");
            Console.WriteLine("   | | | | | || |___  /\\__/ / | | \\ \\_/ / |\\ \\| |___ ");
            Console.WriteLine("   \\_/ \\_| |_/\\____/  \\____/  \\_/  \\___/\\_| \\_\\____/ \n\n\n\n");
            Console.ResetColor();
        }
        private void DisplayStoreItems()
        {
            Console.WriteLine("LEMONS x25>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.18\n");
            Console.WriteLine("SUGAR  x20>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.13\n");
            Console.WriteLine("ICE    x100>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.08\n");
            Console.WriteLine("CUPS   x30>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.07\n\n");

        }
        private void PromptAnotherTransaction()
        {
            Console.Write("Would you like to purchase another item?: ");
            string input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "y")
            {
                Console.Clear();
                PurchaseItems();
            }
            else if (input == "no" || input == "n")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Please enter yes or no.");
                TakeShortBreak();
                Console.Clear();
                PromptAnotherTransaction();
            }
        }
        private void TakeShortBreak()
        {
            System.Threading.Thread.Sleep(800);
        }
    }
}
