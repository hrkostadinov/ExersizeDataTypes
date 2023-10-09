namespace _05._Division_to_2__3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNum = int.Parse(Console.ReadLine());
            double count2 = 0;
            double count3 = 0; 
            double count4 = 0;


            for (int number = 1; number <= countNum; number++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    count2 ++;
                }
                if (value % 3 == 0)
                {
                    count3 ++;
                }
                if (value % 4 == 0)
                {
                    count4 ++;   
                }
            }

            double percent2 = count2 / countNum * 100 ;
            double percent3 = count3 / countNum * 100 ;
            double percent4 = count4 / countNum * 100 ;

            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");

        }
    }
}