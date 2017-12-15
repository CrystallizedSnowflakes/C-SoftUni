using System;

class Program

{
    static void Main()
    {
        long allPictures = long.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        long filterFactorInPercentage = long.Parse(Console.ReadLine());
        long uploadedTime = long.Parse(Console.ReadLine());

        long uploadedPictures = (long)(Math.Ceiling(allPictures * (filterFactorInPercentage * 0.01)));
        long allFilterTime = allPictures * filterTime;
        long allUploadedTime = uploadedPictures * uploadedTime;

        long seconds = (allFilterTime + allUploadedTime);
        long minutes = 0;
        long hours = 0;
        long days = 0;
        if (seconds >= 60)
        {
            minutes = seconds / 60;
            seconds = seconds % 60;
        }
        if (minutes >= 60)
        {
            hours = minutes / 60;
            minutes = minutes % 60;         
        }
        if (hours >= 24)
        {
            days = hours / 24;
            hours = hours % 24;
        }
        Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, seconds);
    }
}

