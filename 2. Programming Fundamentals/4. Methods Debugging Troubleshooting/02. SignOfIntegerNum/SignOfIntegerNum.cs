using System;

class SignOfIntegerNum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintSign(number);
    }

    static void PrintSign(int number)
    {
        IsNumGreaterZero(number);
        IsNumZero(number);
        IsNumLessZero(number);
    }

    static void IsNumLessZero(int number)
    {
        if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
    }

    static void IsNumZero(int number)
    {
        if (number == 0)
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }

    static void IsNumGreaterZero(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
    }
}
