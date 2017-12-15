using System;
using System.Linq;

class RotateAndSumTwo
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rotationCount = int.Parse(Console.ReadLine());

        int[] sumArray = new int[arr.Length];

        for (int i = 0; i < rotationCount; i++)
        {
            RoatateArray(arr);
            for (int j = 0; j < arr.Length; j++)
            {
                sumArray[j] += arr[j];
            }
        }
        Console.WriteLine(string.Join(" ", sumArray));
    }

    private static void RoatateArray(int[] arr)
    {
        int lastElement = arr[arr.Length - 1];
        for (int i = arr.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[0] = lastElement;
    }
}

