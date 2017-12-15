using System;

class LastKNumbersSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long[] arr = new long[n];
        arr[0] = 1;

        for (int currentIndex = 1; currentIndex < n; currentIndex++)
        {
            long sum = 0;
            for (int previousIndex = Math.Max(0, currentIndex - k); previousIndex <= currentIndex - 1; previousIndex++)
            {
                sum += arr[previousIndex];
            }
            arr[currentIndex] = sum;
        }
        Console.WriteLine(String.Join(" ", arr));
    }
}

