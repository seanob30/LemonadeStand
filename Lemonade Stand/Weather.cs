using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public int index;
        int minTemp;
        int maxTemp;
        public int chosenTemp;
        public Customer dailyCustomer;

        public Weather()
        {
            dailyCustomer = new Customer();
        }
        public void ChooseWeather()
        {
            RandomizeWeather();
            switch (index)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("THE CURRENT WEATHER IS RAINY..\n\n");
                    RandomizeRainyTemperature();
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("THE CURRENT WEATHER IS CLOUDY..\n\n");
                    RandomizeCloudyTemperature();
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("THE CURRENT WEATHER IS CLEAR..\n\n");
                    RandomizeClearTemperature();
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("THE CURRENT WEATHER IS SUNNY..\n\n");
                    RandomizeSunnyTemperature();
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("THE CURRENT WEATHER IS HOT & HUMID\n\n");
                    RandomizeHumidTemperature();
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
            TakeThreeSecondBreak();
            Console.Clear();

        }
        private void RandomizeWeather()
        {
            var motherNature = new List<string> { "rainy", "cloudy", "clear", "sunny", "humid" };
            Random rnd = new Random();
            index = rnd.Next(motherNature.Count);
        }
        private void RandomizeRainyTemperature()
        {
            minTemp = 33;
            maxTemp = 55;
            Random rnd = new Random();
            chosenTemp = rnd.Next(minTemp, maxTemp);
        }
        private void RandomizeCloudyTemperature()
        {
            minTemp = 40;
            maxTemp = 59;
            Random rnd = new Random();
            chosenTemp = rnd.Next(minTemp, maxTemp);
        }
        private void RandomizeClearTemperature()
        {
            minTemp = 43;
            maxTemp = 67;
            Random rnd = new Random();
            chosenTemp = rnd.Next(minTemp, maxTemp);
        }
        private void RandomizeSunnyTemperature()
        {
            minTemp = 69;
            maxTemp = 89;
            Random rnd = new Random();
            chosenTemp = rnd.Next(minTemp, maxTemp);

        }
        private void RandomizeHumidTemperature()
        {
            minTemp = 82;
            maxTemp = 103;
            Random rnd = new Random();
            chosenTemp = rnd.Next(minTemp, maxTemp);

        }

        private void TakeThreeSecondBreak()
        {
            System.Threading.Thread.Sleep(3000);
        }


    }
}
