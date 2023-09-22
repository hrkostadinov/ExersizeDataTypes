using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string holidayType = "";
            double holidayCost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    holidayCost = budget * 0.3;
                    holidayType = "Camp";
                }

                else
                {
                    holidayCost = budget * 0.7;
                    holidayType = "Hotel";
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    holidayCost = budget * 0.4;
                    holidayType = "Camp";
                }

                else
                {
                    holidayCost = budget * 0.8;
                    holidayType = "Hotel";
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                holidayCost = budget * 0.9;
                holidayType = "Hotel";
            }


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {holidayCost:f2}");

            
        }
    }
}