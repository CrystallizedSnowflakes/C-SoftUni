using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(PrintFactoriel(num));
    }

    static BigInteger PrintFactoriel(int num)
    {
        BigInteger factorial = 1;
        //for (int i = 1; i <= num; i++)
        //{
        //    factorial *= i;
        //}
        //return factorial;

        for (int i = num; i >= 1; i--)
        {
            factorial *= i;
        }
        return factorial;
    }
}

