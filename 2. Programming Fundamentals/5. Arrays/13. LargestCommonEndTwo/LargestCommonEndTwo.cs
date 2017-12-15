using System;
using System.Linq;

class LargestCommonEndTwo
{
    static void Main()
    {
        string[] arrOne = Console.ReadLine().Split();
        string[] arrTwo = Console.ReadLine().Split();
        int leftCounter = 0;
        int rightCounter = 0;
        int smallerArrLenght = Math.Min(arrOne.Length, arrTwo.Length);
        for (int i = 0; i < smallerArrLenght; i++)
        {
            if (arrOne[i] == arrTwo[i])
            {
                leftCounter++;
            }
            if (arrOne[arrOne.Length - 1 - i] == arrTwo[arrTwo.Length - 1 - i])
            {
                rightCounter++;
            }
        }
        Console.WriteLine(Math.Max(leftCounter, rightCounter));
    }
}

