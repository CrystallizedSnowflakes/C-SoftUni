using System;


class CountIntegers
{
    static void Main()
    {
        int counter = 0;
        try
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                counter++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(counter);
        }
    }
}

