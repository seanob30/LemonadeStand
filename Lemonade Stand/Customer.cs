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
        int totalCupsSold;
        decimal dailyProfit;
        public void CreateCustomerPool(int pool, Weather outside, Recipe playerRecipe)
        {
            for (int i = 0; i < (pool); i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
            FactorInWeather(outside);
            GetLemonFactor(playerRecipe);
            GetSugarFactor(playerRecipe);
            GetIceFactor(playerRecipe);
        }
        public void BuyCupOfLemonade(decimal price)
        {
            totalCupsSold = customers.Count();
            dailyProfit = totalCupsSold * price;
            Console.WriteLine("You made " + dailyProfit + " today!");
            Console.ReadKey();
            Console.Clear();
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
