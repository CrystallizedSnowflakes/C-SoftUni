using System;



class BPMCounter
{
    static void Main()
    {
        int beatsPerMinute = int.Parse(Console.ReadLine());
        int numberBeats = int.Parse(Console.ReadLine());

        double bars = Math.Round(numberBeats / 4.0, 1);

        double beatsPerSecond = beatsPerMinute / 60.0;
        double totalSeconds = (numberBeats / beatsPerSecond);

        int minutes = (int)totalSeconds / 60;
        int seconds = (int)totalSeconds % 60;

        Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
    }
}

