namespace _02._First_N_Numbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            { 
                sum += i;
                Console.Write(i);
                if (i <= num - 1)
                {
                    Console.Write("+");
                }
                else if (i == num)
                {
                    Console.Write($"={sum}");
                }
               

            }
        }
    }
}