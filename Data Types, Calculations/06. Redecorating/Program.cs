namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double nylonAmount = (nylon + 2) * 1.50;
            double paintAmount = (paint * 1.1) * 14.50;
            double thinnerAmount = thinner * 5.00;
            double totalSumMaterials = nylonAmount + paintAmount + thinnerAmount + 0.40;
            double amauntWorkHours = (totalSumMaterials * 0.30) * workHours;
            


            Console.WriteLine(totalSumMaterials + amauntWorkHours);

        }
    }
}