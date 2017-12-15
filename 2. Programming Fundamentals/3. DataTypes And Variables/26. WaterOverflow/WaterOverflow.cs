using System;

class WaterOverflow
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int littersInTheTank = 0;

        for (int i = 0; i < lines; i++)
        {
            int littersWaterforPoor = int.Parse(Console.ReadLine());
            littersInTheTank += littersWaterforPoor;
            if (littersInTheTank > 255)
            {
                Console.WriteLine("Insufficient capacity!");
                littersInTheTank -= littersWaterforPoor;
            }
        }
        Console.WriteLine($"{littersInTheTank}");
    }
}

