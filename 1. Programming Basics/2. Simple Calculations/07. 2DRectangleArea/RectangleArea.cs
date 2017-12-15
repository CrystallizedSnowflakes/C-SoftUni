using System;


namespace _07._2DRectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a = Math.Max(x1, x2) - Math.Min(x1, x2);
            // Max Value - Min Value
            //double a = Math.Abs(x1 - x2);
            //return posotove Value
            double b = Math.Max(y1, y2) - Math.Min(y1, y2);
            //double b = Math.Abs(y1 - y2);
            double area = a * b;
            double perimeter = 2 * (a + b);

            Console.WriteLine("Area is: " + area);
            Console.WriteLine("Perimeter is: " + perimeter);
            // ctrl + K + D - format code
            // ctrl + K + C - comment
            // ctrl + K + U - uncomment
            //Alt + scroll
        }
    }
}
