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
        
        public void ChooseWeather(Random rnd)
        {
            RandomizeWeather(rnd);
            switch (index)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("THE CURRENT WEATHER IS RAINY..\n\n");
                    RandomizeRainyTemperature(rnd);
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("THE CURRENT WEATHER IS CLOUDY..\n\n");
                    RandomizeCloudyTemperature(rnd);
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("THE CURRENT WEATHER IS CLEAR..\n\n");
                    RandomizeClearTemperature(rnd);
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("THE CURRENT WEATHER IS SUNNY..\n\n");
                    RandomizeSunnyTemperature(rnd);
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("THE CURRENT WEATHER IS HOT & HUMID\n\n");
                    RandomizeHumidTemperature(rnd);
                    Console.WriteLine("THE TEMPERATURE IS " + chosenTemp + " DEGREES");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
            TakeLongBreak();
            Console.Clear();
        }
        private void RandomizeWeather(Random rnd)
        {
            var motherNature = new List<string> { "rainy", "cloudy", "clear", "sunny", "humid" };
            index = rnd.Next(motherNature.Count);
        }
        private void RandomizeRainyTemperature(Random rnd)
        {
            minTemp = 33;
            maxTemp = 55;
            chosenTemp = rnd.Next(minTemp, maxTemp);
        }
        private void RandomizeCloudyTemperature(Random rnd)
        {
            minTemp = 40;
            maxTemp = 59;
            chosenTemp = rnd.Next(minTemp, maxTemp);
        }
        private void RandomizeClearTemperature(Random rnd)
        {
            minTemp = 43;
            maxTemp = 67;
            chosenTemp = rnd.Next(minTemp, maxTemp);
        }
        private void RandomizeSunnyTemperature(Random rnd)
        {
            minTemp = 69;
            maxTemp = 89;
            chosenTemp = rnd.Next(minTemp, maxTemp);

        }
        private void RandomizeHumidTemperature(Random rnd)
        {
            minTemp = 82;
            maxTemp = 103;
            chosenTemp = rnd.Next(minTemp, maxTemp);

        }

        private void TakeLongBreak()
        {
            System.Threading.Thread.Sleep(2200);
        }
    }
}
