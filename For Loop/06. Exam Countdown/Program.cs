namespace _06._Exam_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            //int dayCount = 0;

            for(int i = day; i >= 1; i--)
            {
                //dayCount += i;
                Console.WriteLine($"{i} days before the exam");
                
            }
            Console.WriteLine("The exam has come");

        }
    }
}