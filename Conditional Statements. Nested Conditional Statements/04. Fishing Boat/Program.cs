namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMan = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Spring": price = 3000; break;
                case "Summer": 
                case "Autumn": price = 4200; break;
                case "Winter": price = 2600; break;
            }
            if (fisherMan <= 6)
                price = price * 0.9;
            else if (fisherMan >= 7 && fisherMan <= 11)
                price = price * 0.85;
            else if (fisherMan >= 12)
                price = price * 0.75;


            if (fisherMan % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;

            }
            if (price <= budget)
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");

        }
    }
}