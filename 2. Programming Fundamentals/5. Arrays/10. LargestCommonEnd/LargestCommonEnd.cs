using System;
using System.Linq;

class LargestCommonEnd
{
    static void Main()
    {
        string[] arrOne = Console.ReadLine().Split(' ');
        string[] arrTwo = Console.ReadLine().Split(' ');
        int leftCounter = 0;
        int rightCounter = 0;

        for (int i = 0; i <= Math.Min(arrOne.Length, arrTwo.Length) - 1; i++)
        {
            if (arrOne[i] == arrTwo[i])
            {
                leftCounter++;
            }
            else
            {
                break;
            }
        }
        for (int i = 0; i <= Math.Min(arrOne.Length, arrTwo.Length) - 1; i++)
        {
            if (arrOne[arrOne.Length - 1 - i] == arrTwo[arrTwo.Length - 1 - i])
            {
                rightCounter++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(Math.Max(leftCounter, rightCounter));
    }
}

