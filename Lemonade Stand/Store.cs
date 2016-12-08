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
        decimal quantity;
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
                    break;
                default:
                    Console.WriteLine("Please enter a valid store item.");
                    TakeBreak();
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
                quantity = Convert.ToDecimal(lemonInput);
                CheckForPositiveAmount(player);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(lemonPrice, quantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(lemonPrice, quantity);
                    playerInventory.AddLemons(quantity);
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
                TakeBreak();
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
                quantity = Convert.ToDecimal(sugarInput);
                CheckForPositiveAmount(player);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(sugarPrice, quantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(sugarPrice, quantity);
                    playerInventory.AddSugar(quantity);
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
                TakeBreak();
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
                quantity = Convert.ToDecimal(iceInput);
                CheckForPositiveAmount(player);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(icePrice, quantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(icePrice, quantity);
                    playerInventory.AddIce(quantity);
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
                TakeBreak();
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
                quantity = Convert.ToDecimal(cupInput);
                CheckForPositiveAmount(player);
                if (player.playerWallet.CheckForSufficentFunds(Decimal.Multiply(cupsPrice, quantity)))
                {
                    player.playerWallet.assets -= Decimal.Multiply(cupsPrice, quantity);
                    playerInventory.AddCups(quantity);
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
                TakeBreak();
                Console.Clear();
                DisplayStoreScreen(player, playerInventory);
            }
        }
        private void ShowSuccesfulPurchase(Player player, Inventory playerInventory)
        {
            Console.WriteLine("PURCHASE SUCCESSFUL!");
            TakeBreak();
            Console.Clear();
            DisplayStoreScreen(player, playerInventory);
        }
        private void ShowUnsuccesfulPurchase(Player player, Inventory playerInventory)
        {
            Console.WriteLine("INSUFFICENT FUNDS.");
            TakeBreak();
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
            Console.WriteLine(" 1.LEMONS >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.04\n");
            Console.WriteLine(" 2.SUGAR  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.03\n");
            Console.WriteLine(" 3.ICE    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.01\n");
            Console.WriteLine(" 4.CUPS   >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$0.02\n");
            Console.WriteLine(" 5.EXIT STORE\n\n");
        }
        private void CheckForPositiveAmount(Player player)
        {
            if (quantity < 0)
            {
                Console.Clear();
                Console.WriteLine(" Please enter a positive number.");
                TakeBreak();
                Console.Clear();
                DisplayStoreScreen(player, player.playerInventory);
            }
        }
        private void TakeBreak()
        {
            System.Threading.Thread.Sleep(800);
        }
    }
}
