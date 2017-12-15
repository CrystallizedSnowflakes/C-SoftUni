using System;


class PhotoGallery
{
    static void Main(string[] args)
    {
        int photoNum = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();
        string month = Console.ReadLine();
        string year = Console.ReadLine();
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        double bytes = double.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        string resolution = "";
        string size = "";

        if (bytes < 1024)
        {
            size = "B";
        }
        else if (bytes >= 1024 && bytes < 1048576)
        {
            bytes *= 0.001;
            size = "KB";
        }
        else if (bytes >= 1048567 && bytes < 1073741824)
        {
            bytes *= 0.000001;
            size = "MB";
        }

        if (width > height)
        {
            resolution = "landscape";
        }
        else if (width < height)
        {
            resolution = "portrait";
        }
        else
        {
            resolution = "square";
        }

        Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNum);
        Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2:D4} {3:D2}:{4:D2}", day, month, year, hours, minutes);
        Console.WriteLine($"Size: {bytes}{size}");
        Console.WriteLine($"Resolution: {width}x{height} ({resolution})");
    }
}

