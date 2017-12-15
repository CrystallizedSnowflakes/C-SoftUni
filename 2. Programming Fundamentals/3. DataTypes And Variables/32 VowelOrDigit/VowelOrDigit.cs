using System;

class VowelOrDigit
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());
        if (symbol >= 48 && symbol <= 57)
        {
            Console.WriteLine("digit");
        }
        else if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

