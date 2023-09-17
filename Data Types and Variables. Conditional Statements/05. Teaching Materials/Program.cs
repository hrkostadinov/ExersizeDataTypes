namespace _05._Teaching_Materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packOfPens = int.Parse(Console.ReadLine());
            int packOfMarkers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePackOfPens = packOfPens * 5.80;
            double priceOfMarkers = packOfMarkers * 7.20;
            double priceOfBoardCleaner = boardCleaner * 1.2;
            double count = pricePackOfPens + priceOfMarkers + priceOfBoardCleaner;
            double priceWithDiscount = count - (count * discount / 100);

            Console.WriteLine(priceWithDiscount);
            
        }
    }
}