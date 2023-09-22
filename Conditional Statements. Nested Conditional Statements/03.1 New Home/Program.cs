﻿namespace _03._1_New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cost = 0;

            switch (flower)
            {
                case "Roses":
                    cost = count * 5;
                    if (count > 80)
                    {
                        cost = cost * 0.9;
                    }
                    break;
                case "Dahlias":
                    cost = count * 3.8;
                    if (count > 90)
                    {
                        cost = cost * 0.85;
                    }
                    break;
                case "Tulips":
                    cost = count * 2.80;
                    if (count > 80)
                    {
                        cost = cost * 0.85;
                    }
                    break;
                case "Narcissus":
                    cost = count * 3.0;
                    if (count < 120)
                    {
                        cost = cost * 1.15;
                    }
                    break;
                case "Gladiolus":
                    cost = count * 2.5;
                    if (count < 120)
                    {
                        cost = cost * 1.20;
                    }
                    break;
            }
            if (budget < cost)
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {(budget - cost):f2} leva left.");

            else
                Console.WriteLine($"Not enough money, you need {(cost - budget):f2} leva more.");
        }
}