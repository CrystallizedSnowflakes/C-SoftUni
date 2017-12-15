using System;

class CatchTheThief
{
    static void Main()
    {
        string numeralType = Console.ReadLine();
        int numID = int.Parse(Console.ReadLine());

        long maxValue = 0;
        long result = long.MinValue;

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
        Console.WriteLine(result);
    }
}

