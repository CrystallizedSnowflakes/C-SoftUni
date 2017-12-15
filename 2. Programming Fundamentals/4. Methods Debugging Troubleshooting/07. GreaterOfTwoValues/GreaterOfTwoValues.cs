using System;

class GreaterOfTwoValues
{
    static void Main()
    {
        string type = Console.ReadLine();
        if (type == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int max = GetMAx(first, second);
            Console.WriteLine(max);
        }
        else if (type == "char")
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char max = (char)GetMAx(first, second);
            Console.WriteLine(max);
        }
        else if (type == "string")
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string max = GetMAx(first, second);
            Console.WriteLine(max);
        }
    }

    static int GetMAx(int first, int second)
    {
        return Math.Max(first, second);
    }

    static char GetMAx(char first, char second)
    {
        return (char)Math.Max(first, second);
    }

    static string GetMAx(string first, string second)
    {
        if (first.CompareTo(second) > 0)
        {
            return first;
        }
        else if (first.CompareTo(second) < 0)
        {
            return second;
        }
        else
        {
            return first;
        }
    }
}

