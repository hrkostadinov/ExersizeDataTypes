namespace _03._Sequence_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i = 1;

            while (num >= i)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }
        }
    }
}