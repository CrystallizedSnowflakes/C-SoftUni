using System;

class FibonacciNumbers
{
    static void Main()
    {
        int num = Math.Abs(int.Parse(Console.ReadLine()));
        long fibonacciNum = GetFibonacciNum(num);
        Console.WriteLine(fibonacciNum);
    }

    static long GetFibonacciNum(int num)
    {
        long previousNumber = 1;
        long currrentNumber = 0;
        for (int i = 0; i <= num; i++)
        {
            long temp = currrentNumber;
            currrentNumber += previousNumber;
            previousNumber = temp;
        }
        return currrentNumber;
    }
}

