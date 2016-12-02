using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        int index;
        public void ChooseWeather()
        {
            RandomizeWeather();
            switch (index)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("THE CURRENT WEATHER IS RAINY..");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("THE CURRENT WEATHER IS CLOUDY..");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("THE CURRENT WEATHER IS CLEAR..");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("THE CURRENT WEATHER IS SUNNY..");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("THE CURRENT WEATHER IS HOT & HUMID");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
            TakeThreeSecondBreak();
            Console.Clear();

        }
        public void RandomizeWeather()
        {
            var motherNature = new List<string> { "rainy", "cloudy", "clear", "sunny", "humid" };
            Random rnd = new Random();
            index = rnd.Next(motherNature.Count);
        }

        private void TakeThreeSecondBreak()
        {
            System.Threading.Thread.Sleep(3000);
        }


    }
}
