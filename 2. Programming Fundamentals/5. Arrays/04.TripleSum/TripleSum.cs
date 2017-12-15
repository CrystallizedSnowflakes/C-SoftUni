using System;
using System.Linq;

class TripleSum
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' '); //read nums from console separate by " "-> 4 2 8 6
        long[] arr = new long[numbers.Length]; // declare the Length of the array
        for (int i = 0; i < numbers.Length; i++)
        {
            arr[i] = int.Parse(numbers[i]); // fill the array with the numbers-> 4 2 8 6 
        }
        //long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        var counter = 0;

        for (int a = 0; a < arr.Length; a++) //pass trought all four index 0 1 2 3 for a = 4 2 8 6
        {
            for (int b = a + 1; b < arr.Length; b++) //pass trought all four index 0 1 2 3 for b = 4 2 8 6
            {
                for (int c = 0; c < arr.Length; c++) //pass trought all four index 0 1 2 3 for c = 4 2 8 6
                {
                    if (arr[a] + arr[b] == arr[c]) // index a=0=4 + b=1=2 = c=3=6
                    {
                        Console.WriteLine(arr[a] + " + " + arr[b] + " == " + arr[c]);
                        counter++;
                        break;
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}

