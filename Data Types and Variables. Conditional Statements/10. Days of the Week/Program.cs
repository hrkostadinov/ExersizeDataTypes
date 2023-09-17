namespace _09._Numbers__Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Monday");
            }
            if (num == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (num == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (num == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (num == 5)
            {
                Console.WriteLine("Friday");
            }
            if (num == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (num == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (num > 7)
            {
                Console.WriteLine("Error");
            }
            if (num < 1)
            {
                Console.WriteLine("Error");
            }


        }
    }
}