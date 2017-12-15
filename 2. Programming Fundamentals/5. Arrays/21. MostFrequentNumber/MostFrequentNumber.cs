using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int maxCount = 0;
        int frequentNumber = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int currentCount = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    currentCount++;
                }
            }

            if (currentCount > maxCount)
            {
                frequentNumber = arr[i];
                maxCount = currentCount;
            }
        }
        Console.WriteLine(frequentNumber);
    }
}

