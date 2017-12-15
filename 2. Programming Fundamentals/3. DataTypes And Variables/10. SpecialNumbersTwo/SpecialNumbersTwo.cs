using System;


class SpecialNumbersTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            bool special = IsNumberSpecial(i);
            Console.WriteLine("{0} -> {1}", i, special);
        }
    }

    private static bool IsNumberSpecial(int num)
    {
        int sumOfDigit = CalcSumOfDigits(num);
        bool special =
            (sumOfDigit == 5) ||
            (sumOfDigit == 7) ||
            (sumOfDigit == 11);
        return special;
    }

    private static int CalcSumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += (num % 10);
            num = num / 10;
        }
        return sum;
    }
}

