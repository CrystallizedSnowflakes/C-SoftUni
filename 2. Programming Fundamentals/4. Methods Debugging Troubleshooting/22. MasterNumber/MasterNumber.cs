using System;

class MasterNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (IsContainsEvenDigitAndSumDivisibleBySeven(i) == true && IsPalindrome(i) == true)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool IsPalindrome(int num)
    {
        int inputDigits = num;
        string array = num.ToString();
        bool symmetric = true;
        for (int i = 0; i < array.Length / 2; i++)
        {
            int index = array[i];
            if (array[i] != array[array.Length - i - 1])
            {
                symmetric = false;
            }
        }
        return symmetric;
    }
    private static bool IsContainsEvenDigitAndSumDivisibleBySeven(int num)
    {
        bool hasEvenDigit = false;
        int sum = 0;
        while (num > 0)
        {
            int lastDigit = num % 10;
            num /= 10;
            if (lastDigit % 2 == 0)
            {
                hasEvenDigit = true;
            }
            sum += lastDigit;
        }
        if (sum % 7 == 0 && hasEvenDigit == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

