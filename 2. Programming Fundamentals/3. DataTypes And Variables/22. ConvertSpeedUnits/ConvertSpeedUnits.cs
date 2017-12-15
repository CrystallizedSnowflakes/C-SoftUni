using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        uint meters = uint.Parse(Console.ReadLine());
        byte hours = byte.Parse(Console.ReadLine());
        byte minutes = byte.Parse(Console.ReadLine());
        byte seconds = byte.Parse(Console.ReadLine());

        ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds);

        float meterSpeed = (float)meters / time;
        float kilometerSpeed = ((float)meters / 1000) / ((float)time / 3600);
        float mileSpeed = ((float)meters / 1609) / ((float)time / 3600);

        Console.WriteLine("{0:0.#######}", meterSpeed);
        Console.WriteLine("{0:0.#######}", kilometerSpeed);
        Console.WriteLine("{0:0.#######}", mileSpeed);
    }   
}

