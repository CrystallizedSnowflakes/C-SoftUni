using System;
using System.Collections.Generic;
using System.Linq;

class EqualSums
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isFound = false;

        for (int i = 0; i < arr.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = i - 1; j >= 0; j--)
            {
                leftSum += arr[j];
            }

            for (int j = i + 1; j < arr.Length; j++)
            {
                rightSum += arr[j];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                isFound = true;
                break;
            }
        }
        if (!isFound) Console.WriteLine("no");
    }
}

