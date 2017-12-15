using System;

class GeometryCalculator
{
    static void Main()
    {
        string figure = Console.ReadLine();
        GetGeometricFigureArea(figure);
    }

    static void GetGeometricFigureArea(string figure)
    {
        switch (figure)//triangle, square, rectangle and circle
        {
            case "triangle":
                GetTriangleArea();
                break;
            case "square":
                GetSquareArea();
                break;
            case "rectangle":
                GetRectangleArea();
                break;
            case "circle":
                GetCircleArea();
                break;
        }
    }

    static void GetTriangleArea()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = side * height / 2;
        Console.WriteLine($"{area:F2}");
    }

    static void GetSquareArea()
    {
        double side = double.Parse(Console.ReadLine());
        double area = Math.Pow(side, 2);
        Console.WriteLine($"{area:F2}");
    }

    static void GetRectangleArea()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        Console.WriteLine($"{area:F2}");
    }

    static void GetCircleArea()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"{area:F2}");
    }
}

