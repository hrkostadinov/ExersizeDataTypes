namespace _05._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool inRange = num >= 1 && num <= 100;
            
            while (!inRange)
            {
                num = int.Parse(Console.ReadLine());
                inRange = num >= 1 && num <= 100; // прочита се и се проверява наново
            }
            Console.WriteLine(num);
        }
    }
}