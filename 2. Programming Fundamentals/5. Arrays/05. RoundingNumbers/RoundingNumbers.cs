using System;
using System.Linq;

class RoundingNumbers
{
    static void Main()
    {
        double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
        //}
        for (int i = 0; i < arr.Length; i++)
        {
            bool isNegative = true;
            double abs = Math.Truncate(Math.Abs(arr[i]) + 0.5);
            if (arr[i] >= 0)
            {
                isNegative = false;
            }
            Console.WriteLine("{0} => {1}", arr[i], isNegative ? -abs : abs);
        }
    }
}

