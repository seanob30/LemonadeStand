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
        Customer dailyCustomer;
        int currentDay = 0;
        int dailyPitcherAmount;
        decimal dailyLemonCost;
        decimal dailySugarCost;
        decimal dailyIceCost;
        decimal dailyCupCost;
        decimal totalDailyCost;
        decimal lemonPrice = .04m;
        decimal sugarPrice = .03m;
        decimal icePrice = .01m;
        decimal cupsPrice = .02m;

        public void BeginDay(Player player, Random rnd)
        {
            currentDay++;
            outside = new Weather();
            dailyCustomer = new Customer();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Day " + currentDay + "\n");
            Console.ResetColor();
            outside.ChooseWeather(rnd);
            player.playerInventory.CreatePitchers(player);
            dailyPitcherAmount = player.playerInventory.pitchers.Count();
            player.SetPrice();
            dailyCustomer.CreateCustomerPool(outside.chosenTemp, outside, player);
            dailyCustomer.BuyCupOfLemonade(player.cupPrice, player);
            DisplayProfitScreen(player);
        }
        private void DisplayProfitScreen(Player player)
        {
            Console.WindowWidth = 43;
            player.InsertMoneySymbols();
            DetermineDailyCosts(player);
            Console.WriteLine("           Gross Profit:  $" + dailyCustomer.GetDailyProfit());
            Console.WriteLine("\n                         +\n");
            Console.WriteLine("           Daily Expense: $" + totalDailyCost);
            Console.WriteLine("         __________________________\n");
            Console.WriteLine("           Net Profit:    $" + (dailyCustomer.GetDailyProfit() - totalDailyCost));
            Console.ReadKey();
            Console.Clear();
        }
        private void DetermineDailyCosts(Player player)
        {
            dailyLemonCost = (lemonPrice * player.playerRecipe.ingredientLemon) * dailyPitcherAmount;
            dailySugarCost = (sugarPrice * player.playerRecipe.ingredientSugar) * dailyPitcherAmount;
            dailyIceCost = (icePrice * player.playerRecipe.ingredientIce) * dailyPitcherAmount;
            dailyCupCost = (cupsPrice * 10) * dailyPitcherAmount;
            totalDailyCost = dailyLemonCost += dailySugarCost += dailyIceCost += dailyCupCost;
        }
    }
}
