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
        
        public void BeginDay(Player player)
        {
            currentDay++;
            outside = new Weather();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Day " + currentDay + "\n");
            Console.ResetColor();
            outside.ChooseWeather();
            player.playerInventory.CreatePitchers(player);
            player.SetPrice();
            outside.dailyCustomer.CreateCustomerPool(outside.chosenTemp, outside, player);
            outside.dailyCustomer.BuyCupOfLemonade(player.cupPrice, player);
            DisplayProfitScreen();
        }
       
        private void DisplayProfitScreen()
        {
            Console.WriteLine("You made $" + outside.dailyCustomer.GetDailyProfit() + " today!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
