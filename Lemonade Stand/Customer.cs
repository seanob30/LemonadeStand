using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        public List<Customer> customers = new List<Customer>();
        int weatherFactor;
        int positiveFactor;
        int negativeFactor;
        int totalCustomerDemand;
        decimal dailyProfit;
        public void CreateCustomerPool(int pool, Weather outside, Player player)
        {
            for (int i = 0; i < (pool); i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
            FactorInWeather(outside);
            GetLemonFactor(player.playerRecipe);
            GetSugarFactor(player.playerRecipe);
            GetIceFactor(player.playerRecipe);
            GetPriceFactor(player);
        }
        public void BuyCupOfLemonade(decimal price, Player player)
        {
            totalCustomerDemand = customers.Count();
            if (totalCustomerDemand <= player.playerInventory.lemonadeCups.Count())
            {
                dailyProfit = totalCustomerDemand * price;
                player.playerWallet.assets += dailyProfit;
                player.playerInventory.RemoveLemonadeCupsAndPitchers();
            }
            else if (totalCustomerDemand > player.playerInventory.lemonadeCups.Count())
            {
                dailyProfit = player.playerInventory.lemonadeCups.Count() * price;
                player.playerWallet.assets += dailyProfit;
                player.playerInventory.RemoveLemonadeCupsAndPitchers();
            }
        }
        private void FactorInWeather(Weather outside)
        {
            switch (outside.index)
            {
                case 0:
                    GetRainyFactor();
                    break;
                case 1:
                    GetCloudyFactor();
                    break;
                case 2:
                    GetClearFactor();
                    break;
                case 3:
                    GetSunnyFactor();
                    break;
                case 4:
                    GetHumidFactor();
                    break;
                default:
                    break;
            }
        }
        private void GetLemonFactor(Recipe playerRecipe)
        {
            if (playerRecipe.ingredientLemon > 5 && playerRecipe.ingredientLemon < 9)
            {
                positiveFactor = 6;
                for (int i = 0; i < positiveFactor; i++)
                {
                Customer customer = new Customer();
                customers.Add(customer);
                }
            }
            else
            {
                negativeFactor = 5;
                for (int i = 0; i < negativeFactor; i++)
                {
                    customers.RemoveAt(0);
                }
            }
        }
        private void GetSugarFactor(Recipe playerRecipe)
        {
            if (playerRecipe.ingredientSugar > 5 && playerRecipe.ingredientSugar < 9)
            {
                positiveFactor = 5;
                for (int i = 0; i < positiveFactor; i++)
                {
                    Customer customer = new Customer();
                    customers.Add(customer);
                }
            }
            else
            {
                negativeFactor = 4;
                for (int i = 0; i < negativeFactor; i++)
                {
                    customers.RemoveAt(0);
                }
            }
        }
        private void GetIceFactor(Recipe playerRecipe)
        {
            if (playerRecipe.ingredientIce > 9 && playerRecipe.ingredientIce < 15)
            {
                positiveFactor = 3;
                for (int i = 0; i < positiveFactor; i++)
                {
                    Customer customer = new Customer();
                    customers.Add(customer);
                }
            }
            else
            {
                negativeFactor = 2;
                for (int i = 0; i < negativeFactor; i++)
                {
                    customers.RemoveAt(0);
                }
            }
        }
        private void GetPriceFactor(Player player)
        {
            totalCustomerDemand = customers.Count();
            if (player.cupPrice >= 1.00m)
            {
                for (int i = 0; i < totalCustomerDemand * 0.98; i++)
                {
                    customers.RemoveAt(0);
                }
            }
            else if (player.cupPrice > 0.75m)
            {
                for (int i = 0; i < totalCustomerDemand * 0.93; i++)
                {
                    customers.RemoveAt(0);
                }
            }
            else if (player.cupPrice > 0.65m)
            {
                for (int i = 0; i < totalCustomerDemand * 0.85; i++)
                {
                    customers.RemoveAt(0);
                }
            }
            else if (player.cupPrice > 0.50m)
            {
                for (int i = 0; i < totalCustomerDemand * 0.78; i++)
                {
                    customers.RemoveAt(0);
                }
            }
            else if (player.cupPrice > 0.25m)
            {
                for (int i = 0; i < totalCustomerDemand * 0.35; i++)
                {
                    customers.RemoveAt(0);
                }
            }
            else if (player.cupPrice < 0.10m)
            {
                for (int i = 0; i < totalCustomerDemand * 0.40; i++)
                {
                    Customer customer = new Customer();
                    customers.Add(customer);
                }
            }
            else if (player.cupPrice < 0.15m)
            {
                for (int i = 0; i < totalCustomerDemand * 0.30; i++)
                {
                    Customer customer = new Customer();
                    customers.Add(customer);
                }
            }
        }
        private void GetRainyFactor()
        {
            weatherFactor = 11;
            for (int i = 0; i < weatherFactor; i++)
            {
                customers.RemoveAt(0);
            }
        }
        private void GetCloudyFactor()
        {
            weatherFactor = 4;
            for (int i = 0; i < weatherFactor; i++)
            {
                customers.RemoveAt(0);
            }
        }
        private void GetClearFactor()
        {
            weatherFactor = 1;
            for (int i = 0; i < weatherFactor; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        private void GetSunnyFactor()
        {
            weatherFactor = 12;
            for (int i = 0; i < weatherFactor; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        private void GetHumidFactor()
        {
            weatherFactor = 17;
            for (int i = 0; i < weatherFactor; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        public decimal GetDailyProfit()
        {
            return dailyProfit;
        }
    }
}
