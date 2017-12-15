using System;
using System.Linq;
using System.Collections.Generic;

class RotateAndSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rotationCount = int.Parse(Console.ReadLine());

        int[] rotated = new int[numbers.Length];

        for (int i = 0; i < rotationCount; i++)
        {
            int temp = numbers[numbers.Length - 1];
            for (int j = numbers.Length - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }
            numbers[0] = temp;
            for (int l = 0; l < numbers.Length; l++)
            {
                rotated[l] += numbers[l];
            }
        }
        Console.WriteLine(string.Join(" ", rotated));
    }
}

