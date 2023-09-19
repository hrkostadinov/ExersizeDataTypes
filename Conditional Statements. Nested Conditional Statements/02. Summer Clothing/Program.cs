namespace _02._Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string clothing = "";
            string shoes = "";

            if (10 <= temperature && temperature <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            if (18 < temperature && temperature <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            if (temperature >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");

        }
    }
}