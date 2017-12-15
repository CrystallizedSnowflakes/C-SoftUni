using System;


namespace _14.Classroom
{
    class Classroom
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double lengthSeats = (int)(length * 100 / 120); //Math.Truncate
            double widthSeats = (int)(((width * 100) - 100) / 70);
            double numSeats = (int)(lengthSeats * widthSeats) - 3;

            Console.WriteLine(numSeats);
        }
    }
}
