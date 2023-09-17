namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cmLength = int.Parse(Console.ReadLine());
            int cmWidth = int.Parse(Console.ReadLine());
            int cmHeight = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeAquarium = cmLength * cmWidth * cmHeight;
            double volumeLiters = volumeAquarium / 1000;
            double space = percentage / 100;
            double liters = volumeLiters * (1 - space);

            Console.WriteLine($"{liters :f2}" );


        }
    }
}