using System;

class PrintingTriangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            PrintNumbers(1, i);
        }
        for (int i = n - 1; i >= 1; i--)
        {
            PrintNumbers(1, i);
        }
    }

    static void PrintNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

