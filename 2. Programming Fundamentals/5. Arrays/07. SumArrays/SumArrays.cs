using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] sumOfArrays = new int[Math.Max(arrayOne.Length, arrayTwo.Length)];

        for (int i = 0; i < sumOfArrays.Length; i++)
        {
            sumOfArrays[i] = arrayOne[i % arrayOne.Length] + arrayTwo[i % arrayTwo.Length];
        }
        Console.WriteLine(string.Join(" ", sumOfArrays));
    }
}

