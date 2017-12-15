using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string hello = Console.ReadLine();
        string world = Console.ReadLine();

        object together = hello + " " + world;

        string sentence = (string)together;

        Console.WriteLine(sentence);
    }
}

