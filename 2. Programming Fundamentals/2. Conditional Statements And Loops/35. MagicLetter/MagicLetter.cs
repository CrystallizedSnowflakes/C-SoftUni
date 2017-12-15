using System;


class MagicLetter
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine().ToLower());
        char secondLetter = char.Parse(Console.ReadLine().ToLower());
        char ignoredLetter = char.Parse(Console.ReadLine().ToLower());

        for (char s1 = firstLetter; s1 <= secondLetter; s1++)
        {
            for (char s2 = firstLetter; s2 <= secondLetter; s2++)
            {
                for (char s3 = firstLetter; s3 <= secondLetter; s3++)
                {
                    if (s1 != ignoredLetter && s2 != ignoredLetter && s3!= ignoredLetter)
                    {
                        Console.Write($"{s1}{s2}{s3}" + " ");
                    }
                }
            }
        }
        Console.WriteLine();

    }
}

