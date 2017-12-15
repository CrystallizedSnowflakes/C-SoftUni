using System;

class CalculateTriangleArea
{
    static void Main()
    {
        double baseTriangle = double.Parse(Console.ReadLine());
        double heightTriangle = double.Parse(Console.ReadLine());
        double area = GetTriangleArea(baseTriangle, heightTriangle);
        Console.WriteLine(area);
    }

    static double GetTriangleArea(double baseTriangle, double heightTriangle)
    {
        return baseTriangle * heightTriangle / 2;
    }
}
