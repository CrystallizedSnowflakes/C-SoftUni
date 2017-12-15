using System;

class SentenceTheThief
{
    static void Main()
    {
        string numeralType = Console.ReadLine();
        int numID = int.Parse(Console.ReadLine());

        long maxValue = 0;
        long result = long.MinValue;
        double years = 0.0;

        if (numeralType == "sbyte")
        {
            maxValue = sbyte.MaxValue;
        }
        else if (numeralType == "int")
        {
            maxValue = int.MaxValue;
        }
        else if (numeralType == "long")
        {
            maxValue = long.MaxValue;
        }
        for (int i = 0; i < numID; i++)
        {
            long num = long.Parse(Console.ReadLine());
            if (num <= maxValue && num > result) //overwrite the number in the result
            {
                result = num;
            }
        }
        if (result < 0)
        {
            years = Math.Ceiling(result / -128d);
        }
        else
        {
            years = Math.Ceiling(result / 127d);
        }
        if (years > 1)
        {
            Console.WriteLine($"Prisoner with id {result} is sentenced to {years} years");
        }
        else
        {
            Console.WriteLine($"Prisoner with id {result} is sentenced to {years} year");
        }
    }
}

