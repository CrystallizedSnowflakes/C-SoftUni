using System;

class HelloName
{
    static void Main()
    {
        string name = Console.ReadLine();
        PrintGreeting(name);
    }

    static void PrintGreeting(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

