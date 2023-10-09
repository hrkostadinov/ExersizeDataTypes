namespace _03._Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNum = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;

            for (int n = 1;n <= countNum; n++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value > maxNum)
                {
                    maxNum = value;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}