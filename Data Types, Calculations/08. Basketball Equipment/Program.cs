namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            double sneakers = trainingFee * 0.60;
            double team = sneakers * 0.8;
            double basketball = team * 0.25;
            double accessories = basketball * 0.20;

            double totalPrice = trainingFee + sneakers + team + basketball + accessories;

            Console.WriteLine(totalPrice);

        }
    }
}