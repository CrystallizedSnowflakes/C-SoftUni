using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine($"{word[i]} -> {(int)word[i] - (int)'a'}");
        }
    }
}

