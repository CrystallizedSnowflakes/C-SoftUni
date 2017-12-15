using System;


class OddNumber
{
    static void Main()
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));

        while (true) //n % 2 == 0 even
        {
            if (n % 2 == 1) // odd
            { 
                break;
            }
            Console.WriteLine("Please write an odd number.");
            n = Math.Abs(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine("The number is: " + n);
    }
}

