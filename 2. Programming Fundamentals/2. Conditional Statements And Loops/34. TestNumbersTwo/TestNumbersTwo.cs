using System;

class TestNumbersTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int maxSum = int.Parse(Console.ReadLine());

        int count = 0;

        int totalSum = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                totalSum += (i * j) * 3;
                count++;
                if (totalSum >= maxSum)
                {
                    Console.WriteLine($"{count} combinations");
                    Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                    return;
                }
            }
        }
        Console.WriteLine($"{count} combinations");
        Console.WriteLine($"Sum: {totalSum}");
    }
}

