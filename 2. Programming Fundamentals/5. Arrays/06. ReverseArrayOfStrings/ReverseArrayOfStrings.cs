using System;
using System.Linq;

class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(' ');
        //for (int i = 0; i < arr.Length / 2; i++) // reverse half of the array
        //{
        //    string temp = arr[i];
        //    arr[i] = arr[arr.Length - 1 - i];
        //    arr[arr.Length - 1 - i] = temp;
        //}
        //for (int j = 0; j < arr.Length; j++) // print the reversed array
        //{
        //    Console.Write(arr[j] + " ");
        //}
        //Console.WriteLine();
        Console.WriteLine(string.Join(" ", arr.Reverse()));
    }
}
