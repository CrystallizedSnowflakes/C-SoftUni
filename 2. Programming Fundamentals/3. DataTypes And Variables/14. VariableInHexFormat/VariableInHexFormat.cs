using System;

class VariableInHexFormat
{
    static void Main()
    {
        string hex = Console.ReadLine();
        // Convert it back to a number.
        int number = Convert.ToInt32(hex, 16);
        Console.WriteLine(number);
    }
}

