namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            //int thinner = int.Parse(Console.ReadLine());
            //int workHours = int.Parse(Console.ReadLine());

            //double nilonAmount = (nylon + 2) * 1.5;
            double paintAmount = (paint * 1.1) * 14.50;

            Console.WriteLine(paintAmount);

        }
    }
}