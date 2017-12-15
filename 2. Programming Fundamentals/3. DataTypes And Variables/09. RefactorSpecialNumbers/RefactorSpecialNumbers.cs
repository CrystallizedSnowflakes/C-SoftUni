using System;

class RefactorSpecialNumbers
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
       
        for (int digit = 1; digit <= n; digit++)
        {
            int sumOfDigit = SumOfDigit(digit);
            bool isSpecial = (sumOfDigit == 5) || (sumOfDigit == 7) || (sumOfDigit == 11);
            Console.WriteLine($"{digit} -> {isSpecial}");
        }
    }

    static int SumOfDigit(int digit)
    {
        int sumOfDigit = 0;
        while (digit > 0)
        {
            sumOfDigit += digit % 10;
            digit = digit / 10;
        }
        return sumOfDigit;
    }
}
