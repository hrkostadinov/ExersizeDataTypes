namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amaunt = double.Parse(Console.ReadLine());
            double term = double.Parse(Console.ReadLine());
            double air = double.Parse(Console.ReadLine());

            double acumInterest = amaunt * (air / 100);
            double interestOfMounth = acumInterest / 12;
            double totalamaunt = amaunt + term * interestOfMounth;

            Console.WriteLine(totalamaunt);
        }
    }
}