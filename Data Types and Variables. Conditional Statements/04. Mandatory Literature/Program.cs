namespace _04._Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalpages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalHour = totalpages / pagesPerHour;
            int hoursPerDay = totalHour / days;

            Console.WriteLine(hoursPerDay);

        }
    }
}