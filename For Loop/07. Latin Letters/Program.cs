namespace _07._Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            for (char c = first; c <= second; c++)
            {
                Console.Write(c + " ");
            }
        }
    }
}