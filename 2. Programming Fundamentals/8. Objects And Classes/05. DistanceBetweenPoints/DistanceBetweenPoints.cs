using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DistanceBetweenPoints
{

    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double distance = CalculateDistance(p1, p2);
            Console.WriteLine($"{distance:f3}");

        }

        static Point ReadPoint()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point point = new Point() { x = input[0], y = input[1] };
            //point.X = input[0];
            //point.Y = input[1];
            return point;
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            double deltaX = p2.x - p1.x;
            double deltaY = p2.y - p1.y;
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return distance;
        }
    }
}
