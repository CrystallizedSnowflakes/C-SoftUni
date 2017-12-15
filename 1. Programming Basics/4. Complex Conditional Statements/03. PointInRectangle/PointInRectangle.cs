using System;


namespace _03.PodoubleInRectangle
{
    class PodoubleInRectangle
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (((x1 <= x) && (x2 >= x)) && ((y1 <= y) && (y2 >= y))) //the podouble is in rectangle
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
