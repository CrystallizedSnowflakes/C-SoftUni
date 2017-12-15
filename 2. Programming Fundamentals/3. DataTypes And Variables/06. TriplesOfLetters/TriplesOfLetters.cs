using System;

class TriplesOfLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // n = 3

        for (int i = 0; i <= n - 1; i++)
        {
            for (int j = 0; j <= n - 1; j++)
            {
                for (int k = 0; k <= n - 1; k++)
                {
                    char letter1 = (char)('a' + i); // i = 0, 1, 2 -> a, b, c
                    char letter2 = (char)('a' + j); // j = 0, 1, 2 -> a, b, c
                    char letter3 = (char)('a' + k); // k = 0, 1, 2 -> a, b, c
                    Console.WriteLine($"{letter1}{letter2}{letter3}");
                }
            }
        }
        Console.WriteLine();
    }
}
