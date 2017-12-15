using System;


class GameOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicNum = int.Parse(Console.ReadLine());

        int counter = 0;
        string lastCombination = string.Empty;
        int i = 0;
        int j = 0;

        for (i = n; i <= m; i++)
        {
            for (j = n; j <= m; j++)
            {
                counter++;
                if (i + j == magicNum && i > j)
                {
                    lastCombination = $"Number found! {i} + {j} = {magicNum}";
                }
            }
        }
        if (lastCombination == string.Empty)
        {
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
        else
        {
            Console.WriteLine(lastCombination);
        }
    }
}
