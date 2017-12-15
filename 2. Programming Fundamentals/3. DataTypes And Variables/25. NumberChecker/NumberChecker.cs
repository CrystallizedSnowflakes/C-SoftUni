using System;

class NumberChecker
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        bool isInteger = (number >= -9223372036854775808 && number <= 9223372036854775807
            && number % 1 == 0);

        Console.WriteLine(isInteger ? "integer" : "floating-point");
    }
}

