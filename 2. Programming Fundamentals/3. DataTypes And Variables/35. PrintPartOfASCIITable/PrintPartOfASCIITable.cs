﻿using System;

class PrintPartOfASCIITable
{
    static void Main()
    {
        int firstChar = int.Parse(Console.ReadLine());
        int lastChar = int.Parse(Console.ReadLine());

        for (int i = firstChar; i <= lastChar; i++)
        {
            Console.Write($"{(char)i} ");
        }
        Console.WriteLine();
    }
}

