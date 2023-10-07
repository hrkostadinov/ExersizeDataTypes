namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
           
            for(int i = 1; i <= num; i++)
            {
                double inNum = double.Parse(Console.ReadLine());
                sum += inNum;
            }
            Console.WriteLine(sum);


        }

    }
}