using System;

class DecryptingMessage
{
    static void Main()
    {
        byte keyNum = byte.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        string message = string.Empty;

        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            message += (char)(letter + keyNum);
        }
        Console.WriteLine(message);
    }
}

