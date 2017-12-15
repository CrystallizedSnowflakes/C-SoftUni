using System;


namespace _06.CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            double area = (Math.PI * r * r);
            /*double area = (Math.PI * Math.Pow(r, 2));*/

            double perimeter = (2 * Math.PI * r);

            Console.WriteLine("Area = {0:F4}", area);
            Console.WriteLine("Perimeter = {0:F4}", perimeter);
        }
    }
}
