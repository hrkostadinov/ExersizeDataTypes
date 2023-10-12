namespace _02._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter an integer number: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                for (int power = 0; power <= n; power += 2)
                {
                    long result = (long)Math.Pow(2, power);
                    Console.WriteLine( result);
                }
            }
            
        }
    }
}