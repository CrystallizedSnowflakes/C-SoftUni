using System;
using System.Numerics;

class FactorialTrailingZeroes
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        BigInteger factorial = PrintFactoriel(num);
        int zeroes = PrintFactorialTrailingZeroes(factorial);
        Console.WriteLine(zeroes);
    }

    static int PrintFactorialTrailingZeroes(BigInteger factorial)
    {
        int count = 0;
        bool hasZeroes = true;
        while (hasZeroes == true)
        {
            BigInteger lastDigit = factorial % 10;
            factorial = factorial / 10;
            if (lastDigit == 0)
            {            
                count++;
            }
            else
            {
                hasZeroes = false;
            }
        }
        return count;
    }

    static BigInteger PrintFactoriel(int num)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

