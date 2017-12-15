using System;



class BackInThirtyMinutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes = minutes + 30;

        if (minutes >= 60)
        {
            hours ++;
            minutes = minutes % 60; //minutes -= 60;
        }
        if (hours >= 24)
        {
            hours -= 24;
        }
        Console.WriteLine("{0}:{1:D2}", hours, minutes);
    }
}

