using System;

class BooleanVariable
{
    static void Main()
    {
        string name = Console.ReadLine();

        bool isBoolean = Convert.ToBoolean(name);

        Console.WriteLine(isBoolean ? "Yes" : "No");
    }
}
