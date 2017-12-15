using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ClosestTwoPoints
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            }
            return closestTwoPoints;
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        static Point ReadPoint()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point point = new Point() { x = input[0], y = input[1] };
            return point;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double deltaX = p1.x - p2.x;
            double deltaY = p1.y - p2.y;
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return distance;
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.x, point.y);
        }
    }
}
