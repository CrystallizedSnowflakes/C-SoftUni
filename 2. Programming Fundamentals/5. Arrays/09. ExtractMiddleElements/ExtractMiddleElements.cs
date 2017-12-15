using System;
using System.Linq;

class ExtractMiddleElements
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        TyprMiddleSector(arr);
    }

    static void TyprMiddleSector(int[] arr)
    {
        int n = arr.Length;
        if (n == 1)
        {
            GetOneMiddleElement(arr);
        }
        else if (n % 2 == 0)
        {
            GetTwoEvenElements(arr);
        }
        else
        {
            GetThreOddElements(arr);
        }
    }

    static void GetThreOddElements(int[] arr)
    {
        Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]}");
    }

    static void GetTwoEvenElements(int[] arr)
    {
        Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}");
    }

    static void GetOneMiddleElement(int[] arr)
    {
        Console.WriteLine(arr[0]);
    }
}

