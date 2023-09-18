using System.Runtime.InteropServices;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double incom = 0.0;

            if (type == "Premiere")
            {
                incom = rows * colums * 12.00;
            }
            else if (type == "Normal")
            {
                incom = rows * colums * 7.50;
            }
            else if (type == "Discount")
            {
                incom = rows * colums * 5.00;
            }

            Console.WriteLine($"{incom:F2} leva");

        }
    }
}