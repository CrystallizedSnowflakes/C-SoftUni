using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine()); //reading array from the console
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = length - 1; i >= 0; i--) // reverse the array - print from last to first
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        //Console.WriteLine(String.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).ToArray().Reverse()));

        //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //int[] reversed = new int[nums.Length];
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    reversed[i] = nums[nums.Length - i - 1];
        //}
        //Console.WriteLine(String.Join(" ", reversed));
    }
}

