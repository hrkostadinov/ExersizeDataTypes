namespace _06._Number_Processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string com = Console.ReadLine();

            while (com != "End")
            {
                if (com == "Inc")
                {
                    num = num + 1;
                }
                else if (com == "Dec")
                {
                    num = num - 1;
                }
                com = Console.ReadLine();

            }
            Console.WriteLine(num);


        }
    }
}