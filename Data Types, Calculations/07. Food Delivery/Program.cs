namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vege = int.Parse(Console.ReadLine());

            double priceChcken = chicken * 10.35;
            double priceFish = fish * 12.40;
            double priceVege = vege * 8.15;
            double totalCoast = priceChcken + priceFish + priceVege;
            double desert = totalCoast * 0.2;

            double totalPrice = totalCoast + desert + 2.5;

            Console.WriteLine(totalPrice);


        }
    }
}