using System;

class StringConcatenation
{
    static void Main()
    {
        char delimiter = char.Parse(Console.ReadLine());
        string evenOrOdd = Console.ReadLine();
        byte n = byte.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            string word = Console.ReadLine();
            if (i % 2 == 0 && evenOrOdd == "even")
            {
                result += word + delimiter;                ;
            }
            else if (i % 2 == 1 && evenOrOdd == "odd")
            {
                result += word + delimiter;
            }
        }
        Console.WriteLine(result.Remove(result.Length - 1));
    }
}

