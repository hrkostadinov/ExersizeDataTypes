int n = int.Parse(Console.ReadLine());

for (int firstNumber = 1; firstNumber <= 9; firstNumber++)
{
    for (int secondNumber = 0; secondNumber <= 9; secondNumber++)
    {
        for (int thirdNumber = 0; thirdNumber <= 9; thirdNumber++)
        {
            if (firstNumber * secondNumber * thirdNumber == n)
            {
                Console.Write($"{firstNumber}{secondNumber}{thirdNumber} ");
            }
            
        }
    }
}