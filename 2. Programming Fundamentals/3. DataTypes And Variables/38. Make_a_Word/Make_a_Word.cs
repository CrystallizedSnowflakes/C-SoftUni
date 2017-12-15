using System;

class Make_a_Word
{
    static void Main()
    {
        int wordSize = int.Parse(Console.ReadLine());
        char[] letter = new char[wordSize];
        for (int i = 0; i < wordSize; i++)
        {
            letter[i] = char.Parse(Console.ReadLine());
        }
        string word = new string(letter);
        Console.WriteLine($"The word is: {word}");
    }
}

