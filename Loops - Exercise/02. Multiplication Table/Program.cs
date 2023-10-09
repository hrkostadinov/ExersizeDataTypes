namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int result = 0;

            while (i <= 10)
            {
                result = num * i;
                Console.WriteLine($"{num} x {i} = {result}");
                i++;
            }
        }
    }
}