using System;

class PrimeChecker
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        bool isPrime = IsPrime(num);
        Console.WriteLine(isPrime);
    }

    static bool IsPrime(long num)
    {
        if (num == 0 || num == 1)
        {
            return false;
        }
        if (num == 2)
        {
            return true;
        }
        var maxNum = Math.Sqrt(num);
        for (int currentNum = 2; currentNum <= maxNum; currentNum++)
        {
            if (num % currentNum == 0)
            {
                return false;
            }
        }
        return true;
    }
}

