int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

// chetno chislo 
for (int firstDigit = 2; firstDigit <= max1; firstDigit += 2)
{
   for (int secondDigit = 1; secondDigit <= max2; secondDigit++)
    {
        if (secondDigit == 2 || secondDigit == 3 || secondDigit == 7 || secondDigit == 5)
        {
            for (int thirdDigit = 2; thirdDigit <= max3; thirdDigit += 2)
            {
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
            }
        }
        
    }
}


// chetno chislo 