using System;

class LongerLine
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        double lengthOfFirstPair = LineLength(x1, y1, x2, y2);
        double lengthOfSecondPair = LineLength(x3, y3, x4, y4);

        if (lengthOfFirstPair >= lengthOfSecondPair)
        {
            Console.WriteLine(PointIsCloserToCenter(x1, y1, x2, y2));
        }
        else
        {
            Console.WriteLine(PointIsCloserToCenter(x3, y3, x4, y4));
        }
    }

    static double LineLength(double x1, double y1, double x2, double y2)
    {
        double differenceBetwenX = Math.Abs(x1 - x2);
        double differenceBetwenY = Math.Abs(y1 - y2);
        double line = Math.Sqrt(Math.Pow(differenceBetwenX, 2) + Math.Pow(differenceBetwenY, 2));
        return line;
    }

    static string PointIsCloserToCenter(double x1, double y1, double x2, double y2)
    {
        var distance1 = CalculateDistanceBetweenPoints(x1, y1, 0, 0);
        var distance2 = CalculateDistanceBetweenPoints(x2, y2, 0, 0);
        string coordinates = "";
        if (distance1 <= distance2)
        {
            coordinates = $"({x1}, {y1})({x2}, {y2})";
        }
        else
        {
            coordinates = $"({x2}, {y2})({x1}, {y1})";
        }
        return coordinates;
    }

    private static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
    {
        var distance = Math.Sqrt(Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2);
        return distance;
    }
}

