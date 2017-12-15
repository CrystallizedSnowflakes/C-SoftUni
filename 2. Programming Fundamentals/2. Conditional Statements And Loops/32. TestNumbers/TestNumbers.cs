using System;


class TestNumbers
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
                if (totalSum <= maxSum)
                {
                    totalSum += (i * j) * 3;
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (totalSum >= maxSum)
            {
                break;
            }
        }
        Console.WriteLine($"{count} combinations");
        if (totalSum >= maxSum)
        {
            Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
        }
        else
        {
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}

