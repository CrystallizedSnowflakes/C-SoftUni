using System;

class MultiplyEvensByOdds
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultipleOfEvensAndOdds(number));
    }

    static int GetMultipleOfEvensAndOdds(int number)
    {
        int sumEvens = GetSumOfEvenDigits(number);
        int sumOdds = GetSumOfOddDigits(number);
        return sumEvens * sumOdds;
    }

    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        while (Math.Abs(number) > 0)
        {
            int lastDigit = number % 10;
            if (lastDigit % 2 != 0)
            {
                sum += lastDigit;
            }
            number /= 10;
        }
        return sum;
    }

    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        while (Math.Abs(number) > 0)
        {
            int lastDigit = number % 10;
            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }
            number /= 10;
        }
        return sum;
    }
}

