using System;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); //2 10 3
        while (nums.Length > 1) // first time 12 13 // second time 25
        {
            int[] condensed = new int[nums.Length - 1];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];           
            }
            nums = condensed;
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}

