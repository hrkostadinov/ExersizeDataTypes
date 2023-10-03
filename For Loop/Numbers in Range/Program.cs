namespace Numbers_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());


            for (int i = n1;  i <= n2; i+=1)
            {
                Console.WriteLine(i);
            }
        }
    }
}