using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        public void PurchaseItems(Player playerOne)
        {
            Console.WindowWidth = 55;
            InsertStoreSign(playerOne);
            DisplayStoreItems();
            Console.Write(" What would you like to buy? Enter 1-5: ");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "1":
                    playerOne.assets -= .18m;
                    playerOne.lemons += 25;
                    ShowSuccesfulPurchase(playerOne);
                    break;
                case "2":
                    playerOne.assets -= .13m;
                    playerOne.sugar += 20;
                    ShowSuccesfulPurchase(playerOne);
                    break;
                case "3":
                    playerOne.assets -= .08m;
                    playerOne.ice += 100;
                    ShowSuccesfulPurchase(playerOne);
                    break;
                case "4":
                    playerOne.assets -= .07m;
                    playerOne.cups += 30;
                    ShowSuccesfulPurchase(playerOne);
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Okay, exiting the store..");
                    TakeShortBreak();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please enter a valid store item.");
                    TakeShortBreak();
                    Console.Clear();
                    PurchaseItems(playerOne);
                    break;
            } 
        }

        private void InsertStoreSign(Player playerOne)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  _____ _   _  _____   _____ _____ ___________ _____ ");
            Console.WriteLine(" |_   _| | | ||  ___| /  ___|_   _|  _  | ___ \\  ___|");
            Console.WriteLine("   | | | |_| || |__   \\ `--.  | | | | | | |_/ / |__  ");
            Console.WriteLine("   | | |  _  ||  __|   `--. \\ | | | | | |    /|  __|");
            Console.WriteLine("   | | | | | || |___  /\\__/ / | | \\ \\_/ / |\\ \\| |___ ");
            Console.WriteLine("   \\_/ \\_| |_/\\____/  \\____/  \\_/  \\___/\\_| \\_\\____/ \n\n");
            Console.ResetColor();
            Console.WriteLine("  Lemons: " + playerOne.lemons + "     Sugar: " + playerOne.sugar + "     Ice: " + playerOne.ice + "     Cups: " + playerOne.cups + "\n");
            Console.WriteLine("                 Player Assets: " + playerOne.assets + "\n\n");
        }
        private void DisplayStoreItems()
        {
            Console.WriteLine("1.LEMONS x25>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.18\n");
            Console.WriteLine("2.SUGAR  x20>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.13\n");
            Console.WriteLine("3.ICE    x100>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.08\n");
            Console.WriteLine("4.CUPS   x30>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.07\n");
            Console.WriteLine("5.EXIT STORE\n\n");

        }
        private void ShowSuccesfulPurchase(Player playerOne)
        {
            Console.Clear();
            Console.WriteLine("PURCHASE SUCCESSFUL!");
            TakeShortBreak();
            Console.Clear();
            PurchaseItems(playerOne);
            
        }
        private void TakeShortBreak()
        {
            System.Threading.Thread.Sleep(1000);
        }
    }
}
