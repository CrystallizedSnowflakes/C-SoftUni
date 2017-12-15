using System;

class BeerKegs
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        double biggestKeg = 0d;
        string biggestModel = string.Empty;
        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double volume = Math.PI * radius * radius * height;
            if (volume > biggestKeg)
            {
                biggestKeg = volume;
                biggestModel = model;
            }
        }
        Console.WriteLine(biggestModel);
    }
}

