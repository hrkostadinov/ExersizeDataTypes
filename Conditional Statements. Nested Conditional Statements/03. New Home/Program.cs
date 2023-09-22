namespace _03._New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int countFl = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            
            double cost = 0;

            if (flowers == "Roses")
            {
                cost = countFl * 5.00;
                if (countFl > 80)
                {
                    cost = cost * 0.9;
                }
            }
            else if (flowers == "Dahlias")
            {
                cost = countFl * 3.80;
                if (countFl > 90)
                {
                    cost = cost * 0.85;
                }
            }
            else if (flowers == "Tulips")
            {
                cost = countFl * 2.80;
                if (countFl > 80)
                {
                    cost = cost * 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                cost = countFl * 3.00;
                if (countFl < 120)
                {
                    cost = cost * 1.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                cost = countFl * 2.50;
                if (countFl < 80)
                {
                    cost = cost * 1.20;
                }
            }



            if (budget > cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFl} {flowers} and {(budget - cost):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(cost - budget):f2} leva more.");
            }


        }
    }
}