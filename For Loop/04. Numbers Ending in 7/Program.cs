using System.Diagnostics.CodeAnalysis;

namespace _04._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
  
            for (int i = 7; i <= num; i +=10 )
            {
                Console.WriteLine(i);
            }
            
        }
    }
}