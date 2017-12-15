using System;


class Xfigure
{
    static void Main()
    {
        int odd = int.Parse(Console.ReadLine());
        for (int i = 0; i < odd / 2; i++)
        {
            Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', odd - 2 - 2 * i));
        }
        Console.WriteLine("{0}x{0}", new string(' ', odd / 2));
        for (int i = 1; i <= odd / 2; i++)
        {
            Console.WriteLine("{0}x{1}x{0}", new string(' ', odd / 2 - i), new string(' ', 2 * i - 1));
        }
    }
}

