using System;

class DrawFilledSquare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintLineMinus(n);
        for (int i = 0; i < n - 2; i++)
        {
            PrintLineV(n);
        }
        PrintLineMinus(n);
    }

    static void PrintLineV(int size)
    {
        Console.Write("-");
        for (int i = 0; i < size - 2 / 2; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }

    static void PrintLineMinus(int size)
    {
        Console.WriteLine(new String('-', 2 * size));
    }
}

