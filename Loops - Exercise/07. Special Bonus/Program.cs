namespace _07._Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNum = int.Parse(Console.ReadLine());
            int preventNum = stopNum;
            

            while (true)
            {
                int num = int.Parse(Console.ReadLine()) ;
                if (num == stopNum)
                {
                   
                    Console.WriteLine(preventNum * 1.2);
                    break;
                }

                preventNum = num;
            }
        }
    }
}