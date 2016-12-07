using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        Weather outside;
        int currentDay = 0;
        decimal cupPrice;
        public void BeginDay(Player player)
        {
            currentDay++;
            outside = new Weather();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Day " + currentDay + "\n");
            Console.ResetColor();
            outside.ChooseWeather();
            outside.dailyCustomer.CreateCustomerPool(outside.chosenTemp, outside, player.playerRecipe);
            player.playerInventory.CreatePitchers(player.playerRecipe);
            SetPrice();
            outside.dailyCustomer.BuyCupOfLemonade(cupPrice);
            AddProfits(player);

        }
        private void SetPrice()
        {
            Console.Write(" What would you like to charge a cup?: ");
            string input = Console.ReadLine();
            cupPrice = Convert.ToDecimal(input);
            Console.Clear();
            Console.WriteLine("Price is set at " + cupPrice);
            Console.ReadKey();
            Console.Clear();
        }
        private void AddProfits(Player player)
        {
            player.playerWallet.assets += outside.dailyCustomer.GetDailyProfit();
        }
    }
}
