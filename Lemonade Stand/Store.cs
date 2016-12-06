using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        decimal lemonPrice = .04m;
        decimal sugarPrice = .03m;
        decimal icePrice = .01m;
        decimal cupsPrice = .02m;

        public void DisplayStoreScreen(Player player, Inventory playerInventory)
        {
            Console.WindowWidth = 55;
            InsertStoreSign(player, playerInventory);
            DisplayStoreItems();
            Console.Write(" What would you like to buy? Enter 1-5: ");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    PurchaseLemons(player, playerInventory);
                    break;
                case "2":
                    Console.Clear();
                    PurchaseSugar(player, playerInventory);
                    break;
                case "3":
                    Console.Clear();
                    PurchaseIce(player, playerInventory);
                    break;
                case "4":
                    Console.Clear();
                    PurchaseCups(player, playerInventory);
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
                    DisplayStoreScreen(player, playerInventory);
                    break;
            } 
        }
        private void PurchaseLemons(Player player, Inventory playerInventory)
        {
            Console.WriteLine("How many lemons would you like to purchase?: ");
            try
            {
                string lemonInput = Console.ReadLine();
                decimal lemonQuantity = Convert.ToDecimal(lemonInput);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(lemonPrice, lemonQuantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(lemonPrice, lemonQuantity);
                    playerInventory.AddLemons(lemonQuantity);
                    ShowSuccesfulPurchase(player, playerInventory);
                }
                else
                {
                    ShowUnsuccesfulPurchase(player, playerInventory);
                }
            }
            catch
            {
                Console.WriteLine("Error..Please enter a number.");
                TakeShortBreak();
                Console.Clear();
                DisplayStoreScreen(player, playerInventory);
            }
        }
        private void PurchaseSugar(Player player, Inventory playerInventory)
        {
            Console.WriteLine("How much sugar would you like to purchase?: ");
            try
            {
                string sugarInput = Console.ReadLine();
                decimal sugarQuantity = Convert.ToDecimal(sugarInput);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(sugarPrice, sugarQuantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(sugarPrice, sugarQuantity);
                    playerInventory.AddSugar(sugarQuantity);
                    ShowSuccesfulPurchase(player, playerInventory);
                }
                else
                {
                    ShowUnsuccesfulPurchase(player, playerInventory);
                }
            }
            catch
            {
                Console.WriteLine("Error..Please enter a number.");
                TakeShortBreak();
                Console.Clear();
                DisplayStoreScreen(player, playerInventory);
            }
        }
        private void PurchaseIce(Player player, Inventory playerInventory)
        {
            Console.WriteLine("How much ice would you like to purchase?: ");
            try
            {
                string iceInput = Console.ReadLine();
                decimal iceQuantity = Convert.ToDecimal(iceInput);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(icePrice, iceQuantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(icePrice, iceQuantity);
                    playerInventory.AddIce(iceQuantity);
                    ShowSuccesfulPurchase(player, playerInventory);
                }
                else
                {
                    ShowUnsuccesfulPurchase(player, playerInventory);
                }
            }
            catch
            {
                Console.WriteLine("Error..Please enter a number.");
                TakeShortBreak();
                Console.Clear();
                DisplayStoreScreen(player, playerInventory);
            }
        }
        private void PurchaseCups(Player player, Inventory playerInventory)
        {
            Console.WriteLine("How many cups would you like to purchase?: ");
            try
            {
                string cupInput = Console.ReadLine();
                decimal cupQuantity = Convert.ToDecimal(cupInput);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(cupsPrice, cupQuantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(cupsPrice, cupQuantity);
                    playerInventory.AddCups(cupQuantity);
                    ShowSuccesfulPurchase(player, playerInventory);
                }
                else
                {
                    ShowUnsuccesfulPurchase(player, playerInventory);
                }
            }
            catch
            {
                Console.WriteLine("Error..Please enter a number.");
                TakeShortBreak();
                Console.Clear();
                DisplayStoreScreen(player, playerInventory);
            }
        }
        private void ShowSuccesfulPurchase(Player player, Inventory playerInventory)
        {
            Console.WriteLine("PURCHASE SUCCESSFUL!");
            TakeShortBreak();
            Console.Clear();
            DisplayStoreScreen(player, playerInventory);
        }
        private void ShowUnsuccesfulPurchase(Player player, Inventory playerInventory)
        {
            Console.WriteLine("INSUFFICENT FUNDS.");
            TakeShortBreak();
            Console.Clear();
            DisplayStoreScreen(player, playerInventory);
        }
        private void InsertStoreSign(Player player, Inventory playerInventory)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  _____ _   _  _____   _____ _____ ___________ _____ ");
            Console.WriteLine(" |_   _| | | ||  ___| /  ___|_   _|  _  | ___ \\  ___|");
            Console.WriteLine("   | | | |_| || |__   \\ `--.  | | | | | | |_/ / |__  ");
            Console.WriteLine("   | | |  _  ||  __|   `--. \\ | | | | | |    /|  __|");
            Console.WriteLine("   | | | | | || |___  /\\__/ / | | \\ \\_/ / |\\ \\| |___ ");
            Console.WriteLine("   \\_/ \\_| |_/\\____/  \\____/  \\_/  \\___/\\_| \\_\\____/ \n\n");
            Console.ResetColor();
            Console.WriteLine(" Lemons: " + playerInventory.GetLemons() + "     Sugar: " + playerInventory.GetSugar() + "     Ice: " + playerInventory.GetIce() + "     Cups: " + playerInventory.GetCups() + "\n");
            Console.WriteLine("                 " + player.GetName() +"'s Assets: " + player.playerWallet.assets + "\n\n");
        }
        private void DisplayStoreItems()
        {
            Console.WriteLine("1.LEMONS >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.04\n");
            Console.WriteLine("2.SUGAR  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.03\n");
            Console.WriteLine("3.ICE    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.01\n");
            Console.WriteLine("4.CUPS   >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.02\n");
            Console.WriteLine("5.EXIT STORE\n\n");

        }
        private void TakeShortBreak()
        {
            System.Threading.Thread.Sleep(1000);
        }
    }
}
